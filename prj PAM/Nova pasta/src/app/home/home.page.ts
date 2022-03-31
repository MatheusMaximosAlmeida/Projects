import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {
  quantidadeCigarro: number = null;
  quantidadeAnoFumando: number = null;
  tempoVidaPerdido: number = 0;

  constructor() {}

  calcularTempoVidaPerdida(){
    let totalDiasPorAno = 360;
    const minutosPerdidoPorCigarro = 10;
    const totalMinutosPorDia = 1440;
    let totalDiasFumando = this.quantidadeAnoFumando * 360;
    let totalCigarroFumado = totalDiasFumando * this.quantidadeCigarro;
    this.tempoVidaPerdido = totalCigarroFumado *minutosPerdidoPorCigarro;
    this.tempoVidaPerdido = this.tempoVidaPerdido / totalMinutosPorDia;

  }
}
