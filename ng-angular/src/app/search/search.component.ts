import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Validator } from '../models/Validator';
import { ProductService } from '../product-service/product-service.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  form !: FormGroup;
  found = false;
  product : any;

  constructor(private readonly fb : FormBuilder, private productService : ProductService) {}

  ngOnInit(): void {
    this.form = this.fb.group({
      productID : ['', Validators.required]
    });
  }

  get() : void {
    var id = this.productID;

    if(!isNaN(id)){
      this.productService.readProduct(id).subscribe(
        resp =>
        {
          if(resp.entity != null){
            this.product = resp.entity;
            this.found = true;       
            console.log(resp.entity);  
          }
          else {
            alert(Validator._notFound);
          }         
        });   
    }
    else {
      alert(Validator._isNaN);
    }
  }

  clear() : void {
    this.form.get('productID')?.setValue('');
    this.found = false;
  }

  public get productID (){
    return this.form.get('productID')?.value
  }

}
