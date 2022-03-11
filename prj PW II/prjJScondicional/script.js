/* estrutura condicional */
/* IF e ELSE */


var botao = document.getElementById("botaoOK").addEventListener("click", function pegarValores(){
    var campo1  = document.getElementById("campo1").value;
    var campo2  = document.getElementById("campo2").value;
    verificarCampos(campo1, campo2);
})

function verificarCampos(campoNumero1, campoNumero2){

    console.log(campoNumero1, campoNumero2);

    if (campoNumero1 == "" || campoNumero2 == "") {
        window.alert("Seu tongo, preencha os campos bunda mole!")
    } else {
        converterParaInteiro(campoNumero1, campoNumero2);
    }
}

function converterParaInteiro(valorConverter1, valorConverter2){
    var resultado = parseInt(valorConverter1) * parseInt(valorConverter2);
    var h1 =document.getElementById("h1Resultado").innerText = resultado;
    window.alert(resultado);
}