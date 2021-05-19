import { Product } from "../Product";

export class ProductFactory {
    

    public static create(productName : string, unitPrice : number, unitsInStock : number){
        return new Product(productName, unitPrice, unitsInStock);
    }

}