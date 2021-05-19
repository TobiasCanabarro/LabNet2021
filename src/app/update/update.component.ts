import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AppComponent } from '../app.component';
import { ProductFactory } from '../models/factory/ProductFactory';
import { Validator } from '../models/Validator';
import { ProductService } from '../product-service/product-service.service';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

  product : any;
  form !: FormGroup; 

  constructor(private readonly fb : FormBuilder, private readonly productService : ProductService) {}

  ngOnInit(): void {
    this.form = this.fb.group({
      productID: ['', Validators.required],
      productName: ['', Validators.required],
      unitPrice: ['', Validators.required],
      unitsInStock: ['', Validators.required]
    });
  }

  onSubmit() : void {

    var resultProductID = this.getProductID;
    var resultProductName = this.getProductName;
    var resultUnitPrice = this.getUnitPrice;
    var resultUnitsInStock = this.getUnitsInStock;

    var value = Validator.isValidWithID(resultProductID, resultProductName, resultUnitPrice, resultUnitsInStock) &&
      Validator.isLengthValidProductName(resultProductName) && resultProductID > 0;

    if(value){
      var product = ProductFactory.create(resultProductName, resultUnitPrice, resultUnitsInStock);
      product.ProductID = resultProductID;
      product.ProductName = resultProductName;
      this.productService.putProduct(product).subscribe(resp => product = resp);
      var app = new AppComponent(this.productService);
      app.updateListProd();
    }
    else {
      alert(Validator._isInvalid);
    }  
  }

  onClickClear(): void {
    this.form.get('productID')?.setValue('');
    this.form.get('productName')?.setValue('');
    this.form.get('unitPrice')?.setValue('');
    this.form.get('unitsInStock')?.setValue('');
  }

  public get getProductID () {
    return this.form.get('productID')?.value;
  }

  public get getProductName () {
    return this.form.get('productName')?.value;
  }

  public get getUnitPrice () {
    return this.form.get('unitPrice')?.value;
  }

  public get getUnitsInStock () {
    return this.form.get('unitsInStock')?.value;
  }
}
