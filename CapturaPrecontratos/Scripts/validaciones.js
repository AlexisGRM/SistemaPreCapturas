
$('#DropDownList3').select(
    function () {
        $(this).submit();
    }
);

//para validar una CURP
function curpValida(curp) {
    var re = /^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$/,
        validado = curp.match(re);

    if (!validado)  //Coincide con el formato general?
        return false;

    //Validar que coincida el dígito verificador
    function digitoVerificador(curp17) {
        //Fuente https://consultas.curp.gob.mx/CurpSP/
        var diccionario = "0123456789ABCDEFGHIJKLMNÑOPQRSTUVWXYZ",
            lngSuma = 0.0,
            lngDigito = 0.0;
        for (var i = 0; i < 17; i++)
            lngSuma = lngSuma + diccionario.indexOf(curp17.charAt(i)) * (18 - i);
        lngDigito = 10 - lngSuma % 10;
        if (lngDigito == 10) return 0;
        return lngDigito;
    }

    if (validado[2] != digitoVerificador(validado[1]))
        return false;

    return true; //Validado
}


//Handler para el evento cuando cambia el input
//Lleva la CURP a mayúsculas para validarlo
function validarInputCURP(input) {
    var curp = input.value.toUpperCase(),
        resultado = document.getElementById("resultadocurp"),
       

        valido = "No válido";

    if (curpValida(curp)) { // Acá se comprueba
        valido = "Válido";
        resultado.classList.remove("alert-danger");

        resultado.classList.add("alert-success");
    } else {
        resultado.classList.remove("alert-success");

        resultado.classList.add("alert-danger");

    }

    resultado.innerText = "CURP: " + curp + "\nFormato: " + valido;
}

function rfcValido(rfc, aceptarGenerico = true) {
    const re = /^([A-ZÑ&]{3,4}) ?(?:- ?)?(\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])) ?(?:- ?)?([A-Z\d]{2})([A\d])$/;
    var validado = rfc.match(re);

    if (!validado)  //Coincide con el formato general del regex?
        return false;

    //Separar el dígito verificador del resto del RFC
    const digitoVerificador = validado.pop(),
        rfcSinDigito = validado.slice(1).join(''),
        len = rfcSinDigito.length,

        //Obtener el digito esperado
        diccionario = "0123456789ABCDEFGHIJKLMN&OPQRSTUVWXYZ Ñ",
        indice = len + 1;
    var suma,
        digitoEsperado;

    if (len == 12) suma = 0
    else suma = 481; //Ajuste para persona moral

    for (var i = 0; i < len; i++)
        suma += diccionario.indexOf(rfcSinDigito.charAt(i)) * (indice - i);
    digitoEsperado = 11 - suma % 11;
    if (digitoEsperado == 11) digitoEsperado = 0;
    else if (digitoEsperado == 10) digitoEsperado = "A";

    //El dígito verificador coincide con el esperado?
    // o es un RFC Genérico (ventas a público general)?
    if ((digitoVerificador != digitoEsperado)
        && (!aceptarGenerico || rfcSinDigito + digitoVerificador != "XAXX010101000"))
        return false;
    else if (!aceptarGenerico && rfcSinDigito + digitoVerificador == "XEXX010101000")
        return false;
    return rfcSinDigito + digitoVerificador;
}


//Handler para el evento cuando cambia el input
// -Lleva la RFC a mayúsculas para validarlo
// -Elimina los espacios que pueda tener antes o después
function validarInputRFC(input) {
    var rfc = input.value.trim().toUpperCase(),
        resultado = document.getElementById("resultadorfc"),
        valido;

    var rfcCorrecto = rfcValido(rfc);   // ⬅️ Acá se comprueba

    if (rfcCorrecto) {
        valido = "Válido";
        resultado.classList.remove("alert-danger");

        resultado.classList.add("alert-success");
    } else {
        valido = "No válido"
        resultado.classList.remove("alert-success");

        resultado.classList.add("alert-danger");
    }
    resultado.innerText = "RFC: " + rfc
        + "\nResultado: " + rfcCorrecto
        + "\nFormato: " + valido;
}
function validarCodigoPostal(cp) {
    var input = cp.value.trim().toUpperCase();
    var resultado = document.getElementById("resultadocp"), valido;

    console.log(parseInt(input))
    if (input.length == 5 && parseInt(input) >= 1000 && parseInt(input) <= 99999) {
        valido = 'valido';
        resultado.classList.remove("alert-danger");
        resultado.classList.add("alert-success");
    }
    else {
        valido = 'No Valido'
        resultado.classList.remove("alert-success");
        resultado.classList.add("alert-danger");
    }
    resultado.innerText = "CP: "  + input
        + "\nFormato: " + valido;
}