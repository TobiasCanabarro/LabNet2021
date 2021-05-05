
	/**
	 * Esta funcion se usa cuando se completa el formulario.
	 */
	$(document).ready(function(){
		$("#submit").click(function(){			
			var result = "";
			result = isValid();
		
			if(result != ""){
				alert(result + $("#alert").text());
			}else {
				alert("Gracias por completar el formulario!");
				window.location.href = "https://www.google.com.ar";
			} 	
		});
	});

	/**
	 * Esta funcion se usa para borrar todo el contendio de los inputs.
	 */
	$(document).ready(function(){
		$("#clear").click(function(){
			document.getElementById("name").value = "";
			document.getElementById("lastname").value = "";
			document.getElementById("age").value = "";
			document.getElementById("exampleCheck1").value = "";
			document.getElementById("exampleCheck2").value = "";
			document.getElementById("exampleCheck3").value = "";
			document.getElementById("textarea").value = "";
		})
	});

