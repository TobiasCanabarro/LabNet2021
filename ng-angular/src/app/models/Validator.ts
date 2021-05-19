
export class Validator {

    public static readonly _isInvalid = "[ERROR] The fields don't haven the expected formats or product name exceed 40 characters!";
    public static readonly _isNaN = "[ERROR] The field needs to be a number!";
    public static readonly _undefined = "[ERROR] The field is empty!";
    public static readonly _notFound = "[ERROR] not product found with that ID";
    private static readonly _max_lenght = 40;


    public static isValid (productName : any, unitPrice : any, unitsInStock : any){
        return isNaN(productName) && !isNaN(unitPrice) && !isNaN(unitsInStock);
    }

    public static isValidWithID (productID : any, productName : any, unitPrice : any, unitsInStock : any){
        return !isNaN(productID) && isNaN(productName) && !isNaN(unitPrice) && !isNaN(unitsInStock);
    }

    public static isLengthValidProductName(productName : string){
        return productName.length < this._max_lenght;
    }


}