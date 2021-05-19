import { Component } from '@angular/core';
import { ProductService } from './product.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [ProductService]
})
export class AppComponent {
  title = 'ejercicio-angular';

  constructor(private productSvc: ProductService){}

  ngOnInit(){
    this.productSvc.getAllProducts().subscribe(res => {
      console.log(res);
    });
  }




}


