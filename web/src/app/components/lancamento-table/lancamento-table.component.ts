import { Component, OnInit } from '@angular/core';
import Lancamentos from 'src/app/models/Lancamentos';

@Component({
  selector: 'app-lancamento-table',
  templateUrl: './lancamento-table.component.html',
  styleUrls: ['./lancamento-table.component.scss']
})
export class LancamentoTableComponent implements OnInit {

  constructor() { }
  displayedColumns: string[] = [
    'id',
    'desLancamento',
    'indEntradaSaida',
    'valLancamento',
    'dtaTransacao'
  ]
  dataSource: Lancamentos[] = []
  ELEMENT_DATA: Lancamentos[] = [
    {
      id: 0,
      desLancamento: 'teste',
      indEntradaSaida: 1,
      valLancamento: 1.3,
      dtaTransacao: '01/01/1997'}
];
ngOnInit(): void {
  this.dataSource = this.ELEMENT_DATA
  }

}
