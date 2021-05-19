import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, FormGroupDirective, NgForm, Validators } from '@angular/forms';
import { matFormFieldAnimations } from '@angular/material/form-field';
import { Observable, observable } from 'rxjs';
import { Product } from 'src/app/product';
import { ProductService } from 'src/app/product.service';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-insert',
  templateUrl: './insert.component.html',
  styleUrls: ['./insert.component.scss']
})
export class InsertComponent implements OnInit {

  form!: FormGroup;
  allProducts!: Observable<Product[]>;
  

  get productoCtrl(): AbstractControl {
    return this.form.get('producto');
  }

  get cantidadCtrl(): AbstractControl {
    return this.form.get('cantidad');
  }

  get precioCtrl(): AbstractControl {
    return this.form.get('precio');
  }

  get unidadesCtrl(): AbstractControl {
    return this.form.get('unidades');
  }


  constructor(private fb: FormBuilder, private productSvc: ProductService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      producto: new FormControl ('', Validators.required),
      cantidad: new FormControl ('', Validators.required),
      precio: new FormControl ('', Validators.required),
      unidades: new FormControl ('', Validators.required)
    });
  } 

  onSubmit(){
    var formData = new Product();

    formData.ProductName = this.productoCtrl.value;
    formData.QuantityPerUnit = this.cantidadCtrl.value;
    formData.UnitPrice = this.precioCtrl.value;
    formData.UnitsInStock = this.unidadesCtrl.value;
    console.log(formData);
    this.productSvc.createProduct(formData).subscribe();
    this.form.reset();
    this.toastr.success("Nuevo producto guardado. Revise la lista de nuevo.", '¡Listo!');
    this.loadAllProducts();

  }

  loadAllProducts() {
    this.allProducts! = this.productSvc.getAllProducts();
  }

  onClickLimpiar(): void {
    this.form.reset();    
  }


}
