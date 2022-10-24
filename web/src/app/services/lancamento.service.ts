import { Injectable } from "@angular/core";
import { HttpClient, HttpResponse } from '@angular/common/http';
import { environment } from './../../environments/environment';
import { Observable } from "rxjs";
import Lancamento from '../models/Lancamentos';


@Injectable({
  providedIn: 'root'
})
export class LancamentoService {
  readonly path = `${environment.apiUrl}/lancamento`
  /**
   *
   */
  constructor(private http: HttpClient) {
  }
  getAll(): Observable<Lancamento[]> {
    return this.http.get<Lancamento[]>(this.path);
}
}
