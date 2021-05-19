import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { fromEventPattern, Observable } from 'rxjs';
import { Product } from './product';

@Injectable()

export class ProductService {

  constructor(private http: HttpClient) { }

  getAllProducts(): Observable<Product[]> {
    return this.http.get<Product[]>('/api/Products/AllProductsDetails');
  }

  getProductById(ProductID : number): Observable<Product> {
    return this.http.get<Product>('/api/Products/GetProductDetailsById/' + ProductID)
  }

  createProduct(product : Product): Observable<Product>{
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };
    return this.http.post<Product>('/api/Products/InsertProductDetails', product, httpOptions);
  }

  updateProduct(product : Product): Observable<Product>{
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };
    return this.http.put<Product>('/api/Products/UpdateProductDetails?id=' + product.ProductID, product, httpOptions)
  }

  deleteProductById(ProductID : number): Observable<number>{
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };
    return this.http.delete<number>('/api/Products/DeleteProductDetails?id=' + ProductID, httpOptions);
  }

}
