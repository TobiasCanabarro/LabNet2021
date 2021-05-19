
export class Product {

    ProductID!: number;
    ProductName !: string;
    UnitPrice !: number;
    UnitsInStock !: number;

    public constructor(productName : string, unitPrice : number, unitsInStock : number){
        this.ProductName = productName;
        this.UnitPrice = unitPrice;
        this.UnitsInStock = unitsInStock;
    }
}