import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';
import { AppComponent } from '../app.component';
import { Validator } from '../models/Validator';
import { ProductService } from '../product-service/product-service.service';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.css']
})
export class DeleteComponent implements OnInit {

  form !: FormGroup;

  constructor(private readonly fb : FormBuilder, private productService : ProductService) {}

  ngOnInit(): void {
    this.form = this.fb.group({
      productID : ['', Validators.required]
    });
  }

  onSubmit(): void {
    var id =  this.getProductID;
    var response : any;

    if(!isNaN(id) && id > 0){
      response = this.productService.deleteProduct(id).subscribe(
        resp => 
        {
          if(resp.TypeEx == null){
            response = resp;
            alert("SUSCCESS");
            this.form.get("productID")?.setValue('');
            var app = new AppComponent(this.productService);
            app.updateListProd();
          }
          else {
            alert("ERROR");
          }
        });      
    }
    else {
      alert(Validator._isNaN);
    }
  }

  public get getProductID (){
    return this.form.get("productID")?.value;
  }

}
