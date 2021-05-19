import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';
import { ProductFactory } from '../models/factory/ProductFactory';
import { Validator } from '../models/Validator';
import { ProductService } from '../product-service/product-service.service';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {

  product : any;
  form !: FormGroup;

  constructor(private readonly fb : FormBuilder, private readonly productService : ProductService) {}

  ngOnInit(): void {
    this.form = this.fb.group({
      productName: ['', Validators.required],
      unitPrice: ['', Validators.required],
      unitsInStock: ['', Validators.required]
      });
  }

  onSubmit() : void {
    
    var resultProductName = this.getProductName;
    var resultUnitPrice = this.getUnitPrice;
    var resultUnitsInStock = this.getUnitsInStock;

    var value = Validator.isValid(resultProductName, resultUnitPrice, resultUnitsInStock) &&
      Validator.isLengthValidProductName(resultProductName);

    if(value){
      var product = ProductFactory.create(resultProductName, resultUnitPrice, resultUnitsInStock);
      product.ProductName = resultProductName;
      this.productService.postProduct(product).subscribe(resp => this.product);
    }
    else {
      alert(Validator._isInvalid);
    }  
  }

  onClickClear() : void{
    this.form.get('productName')?.setValue('');
    this.form.get('unitPrice')?.setValue('');
    this.form.get('unitsInStock')?.setValue('');
  }

  public get getProductName() {
    return this.form.get('productName')?.value;
  }

  public get getUnitPrice() {
    return this.form.get('unitPrice')?.value;
  }

  public get getUnitsInStock() {
    return this.form.get('unitsInStock')?.value;
  }

}
