import { Component, OnInit  } from '@angular/core';
import { Observable } from 'rxjs';
import { ProductService } from '../product.service';  
import { Product } from '../product';  
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {

  public show:boolean = false;
  public showInsert:boolean = false;
  public showUpdate:boolean = false;
  public nombreBoton:any = "Ver";
  public nombreBotonInsert:any = "Ingresar";
  allProducts!: Observable<Product[]>;
  formUpdate!: FormGroup;
  formGet!: FormGroup;
  ProductIdUpdate!: number;

  get productIDCtrl(): AbstractControl {
    return this.formUpdate.get('IDG');
  }
  get productoUCtrl(): AbstractControl {
    return this.formUpdate.get('productoU');
  }

  get cantidadUCtrl(): AbstractControl {
    return this.formUpdate.get('cantidadU');
  }

  get precioUCtrl(): AbstractControl {
    return this.formUpdate.get('precioU');
  }

  get unidadesUCtrl(): AbstractControl {
    return this.formUpdate.get('unidadesU');
  }

  constructor(private productService:ProductService, private toastr: ToastrService, private formB: FormBuilder, /*private formG: FormBuilder*/) { }

  ngOnInit() {
    this.formUpdate = this.formB.group({
      IDG: new FormControl('', Validators.required),
      productoU: new FormControl (''),
      cantidadU: new FormControl (''),
      precioU: new FormControl (''),
      unidadesU: new FormControl ('')
    });
    this.loadAllProducts();
  }

  loadAllProducts() {
    this.allProducts! = this.productService.getAllProducts();
  }

  deleteProduct(ProductID: number){
    if (confirm("¿Seguro que quiere borrar esto?")){
      this.productService.deleteProductById(ProductID).subscribe(() => {
        this.toastr.success("Producto eliminado.", 'Listo');
        this.loadAllProducts();
      });
    }
  }

  showAll() {
    this.show = !this.show;

    if (this.show)
      this.nombreBoton = "Cerrar";
    else
      this.nombreBoton = "Ver";

  }

  showI(){
    this.showInsert = !this.showInsert;

    if (this.showInsert)
      this.nombreBotonInsert = "Cerrar";
    else 
      this.nombreBotonInsert = "Ingresar";
  }

  showU(ProductID: number){
    if (confirm("¿Desea editar este producto?")){
      alert("Abajo encontrará la información a editar.");
      this.showAll();
      this.showUpdate = !this.showUpdate;
      this.productService.getProductById(ProductID).subscribe(
        product => {
          console.log(product);
          this.formUpdate.controls['IDG'].setValue(product.ProductID);
          this.formUpdate.controls['productoU'].setValue(product.ProductName);
          this.formUpdate.controls['cantidadU'].setValue(product.QuantityPerUnit);
          this.formUpdate.controls['precioU'].setValue(product.UnitPrice);
          this.formUpdate.controls['unidadesU'].setValue(product.UnitsInStock);
        });
    }
  }


  onSubmitUpdate() {
    var formData = new Product();
    formData.ProductID = this.productIDCtrl.value;
    formData.ProductName = this.productoUCtrl.value;
    formData.QuantityPerUnit = this.cantidadUCtrl.value;
    formData.UnitPrice = this.precioUCtrl.value;
    formData.UnitsInStock = this.unidadesUCtrl.value;
    console.log(formData);
    this.productService.updateProduct(formData).subscribe({
      next: data => {
        this.toastr.success("Cliente actualizado correctamente.", 'Actualización.');
      },
      error: error => {
        this.toastr.error("No se ha actualizado.", 'Error.');
      }
    });
    this.formUpdate.reset();
    this.onClickCancelar();
  }

  onClickCancelar() {
    this.showUpdate = !this.showUpdate;
  }

}
