import { Component } from '@angular/core';
import {Product} from './models/Product';
import { ProductService } from './product-service/product-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

   title = "home"
   create = false;
   update = false;
   delete = false;
   getProd = false;

  public products !: Product[];

  constructor(private productService : ProductService) {}

  ngOnInit() : void{
    this.updateListProd();
  }

  updateListProd () : void {
    this.productService.readProductResponse().subscribe(
      resp =>
      {
        this.products = resp;
      });
  }
}
