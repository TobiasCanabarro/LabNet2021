import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../models/Product';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HeaderFactory } from '../models/factory/HeaderFactory';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private readonly _header = HeaderFactory.create();
  private readonly _path_controller = "products/"; 

  constructor(private http : HttpClient) {}


  deleteProduct(id : number) : Observable<any>{
    try{

      return this.http.delete<any>(environment.product + this._path_controller + id, {headers : this._header});
    }
    catch(error){
      
      console.log(error.value);
      return error;
    }  
  }

  readProduct(id : number) : Observable<any>{

    try {

      return this.http.get<any>(environment.product + this._path_controller + id, {headers : this._header});

    } catch (error) {

      console.log(error.value);
      return error;
    }  
  }

  readProductResponse() : Observable<Product[]>{

    try {
      
      return this.http.get<Product[]>(environment.product + this._path_controller, {headers : this._header});

    } catch (error) {

      console.log(error);
      return error;
    }
  }

  postProduct(request : Product) : Observable<Product>{

    try {
      
      return this.http.post<Product>(environment.product + this._path_controller, request);

    } catch (error) {

      console.log(error.value);
      return error;
    }   
  }

  putProduct(request : Product) : Observable<Product>{

    try {

      return this.http.put<Product>(environment.product + this._path_controller, request);

    } catch (error) {

      console.log(error.value);
      return error;
    }   
  }
}
