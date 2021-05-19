import { HttpHeaders } from "@angular/common/http";

export class HeaderFactory {

    public static create(){
        return new HttpHeaders()
        .set("Type-content", "application/Json");
    }

}