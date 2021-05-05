
const ERROR_NAME = "[ERROR] El nombre no tiene el formato deseado (Este campo no puede contener numeros, simbolos o estar vacio)\n";
const ERROR_LASTNAME = "[ERROR] El apellido no tiene el formato deseado => Este campo no puede contener numeros, simbolos o estar vacio\n";
const ERROR_AGE = "[ERROR] Formato de la edad es incorrecto (Este campo no puede contener letras, simbolos o estar vacio)\n";
const ERROR_GENDER = "[ERROR] Error al seleccionar el genero (Tiene que seleccionar uno)\n";
const PATTERN_ONLY_LETTERS = /\d/i;
const PATTERN_ONLY_NUMBERS = /^([0-9])*$/;

/* Esta funcion verifica si la variable esta vacia*/
let isEmpty = (p) => {
	return p == "";
}

/**
 * Esta funcion valida el formato del nombre ingresado por el usuario
 * En caso de que el formato no sea el deseado retorna un string con el error.
 * De lo contrario retorna una cadena vacia.
 * @returns {string}
 */

let isNameValid = () => {

	var name = document.getElementById('name').value;
	var pattern = PATTERN_ONLY_LETTERS;
	var result = "";

	if(name == "" || pattern.test(name)){
		result =  ERROR_NAME;
	}
	return result;
}

/**
 * Esta funcion valida el formato del apellido ingresado por el usuario
 * En caso de que el formato no sea el deseado retorna un string con el error.
 * De lo contrario retorna una cadena vacia.
 * @returns {string}
 */

let isLastnameValid = () => {

	var lastname = document.getElementById("lastname").value;
	var pattern = PATTERN_ONLY_LETTERS;
	var result = "";

	if(isEmpty(lastname) || pattern.test(lastname)){
		result = ERROR_LASTNAME;
	}
	return result;
}

/**
 * Esta funcion valida el formato de la edad ingresada por el usuario
 * En caso de que el formato no sea el deseado retorna un string con el error.
 * De lo contrario retorna una cadena vacia.
 * @returns {string}
 */

let isAgeValid = () => {

	var age = document.getElementById("age").value;
	var pattern = PATTERN_ONLY_NUMBERS;
	var value = age <= 0 || !pattern.test(age) || isEmpty(age);
	var result = "";

	if(value){
		result = ERROR_AGE;
	}
	return result;
}

/**
 * Esta funcion valida el genero seleccionado por el usuario
 * En caso de que el formato no sea el deseado retorna un string con el error.
 * De lo contrario retorna una cadena vacia.
 * @returns {string}
 */

let isGenerValid = (checkbox1, checkbox2, checkbox3) => {

	var checked1 = document.getElementById("checkbox1").checked;
	var checked2 = document.getElementById("checkbox2").checked;
	var checked3 = document.getElementById("checkbox3").checked;
	var result = "";

	if(checked1 == false && checked2 == false && checked3 == false){
		result = ERROR_GENDER;
	}

	return result;
}

/**
 * Esta funcion llama a todas las funciones que validan los inputs
 * En caso de que alguno de los formatos no se respete retornara el error correspondiente.
 * De lo contrario retorna una cadena vacia.
 * @returns {string}
 */

let isValid = () => {
	var resultName = isNameValid();
	var resultLastname = isLastnameValid();
	var resultAge = isAgeValid();
	var resultCheckbox = isGenerValid();
	return resultName + resultLastname + resultAge + resultCheckbox;
}