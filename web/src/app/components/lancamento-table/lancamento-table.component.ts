import { Component, OnInit } from '@angular/core';
import Lancamento from 'src/app/models/Lancamentos';
import { LancamentoService } from '../../services/lancamento.service';

@Component({
  selector: 'app-lancamento-table',
  templateUrl: './lancamento-table.component.html',
  styleUrls: ['./lancamento-table.component.scss']
})
export class LancamentoTableComponent implements OnInit {

  constructor(
    private faturamentoService: LancamentoService,
  ) { }
  displayedColumns: string[] = [
    'id',
    'desLancamento',
    'indEntradaSaida',
    'valLancamento',
    'dtaTransacao'
  ]
  dataSource: Lancamento[] = []

ngOnInit(): void {
    console.log('nada',this.faturamentoService)
    this.faturamentoService.getAll().subscribe((resp)=> {
      this.dataSource = resp
    })
  }

}
