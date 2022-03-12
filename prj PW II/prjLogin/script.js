var botao = document.getElementById("button").addEventListener("click", function pegarValores(){
    var email = document.getElementById("email").value;
    var password = document.getElementById("password").value;
    verificarCampos(email, password);
})


function verificarCampos(email, password){

    if (email == "matheusmaximos452@gmail.com" && password == "12345678"){
        window.alert("Login com sucesso")
    } else {
        window.alert("Login ou senha não detectados")
    }
}

