import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {
peso: number;
altura: number;
imc: number;
classificacao: string;

  constructor() {}

  calcularIMC(){
    const altFixo = this.altura / 100;
    this.imc = this.peso / (altFixo * altFixo)

    if (this.imc < 18.5){
      this.classificacao = "Seu IMC está abaixo de 18.5 - Abaixo do peso";
    }
    else if (this.imc <= 24.9 ){
      this.classificacao = "Seu IMC está entre 18.5 e 24.9 - Peso normal";
    }
    else if (this.imc <=29.9){
      this.classificacao = "Seu IMC está entre 25 e 29.9 - Sobrepeso";
    }
    else if (this.imc <= 34.9){
      this.classificacao = "Seu IMC está entre 30 e 34.9 - Obesidade I";
    }
    else if (this.imc <= 39.9){
      this.classificacao = "Seu IMC está entre 35 e 39.9 - Obesidade II";
    }
    else{
      this.classificacao = "seu IMC está entre 40 ou maior -  Peso Mórbido"
    }
    
  }
}
