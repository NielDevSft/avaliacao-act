import { TipoTransacao } from "./TipoTransacao";

export default class Lancamento {
  constructor(
    public id: number,
    public desLancamento: string,
    public indEntradaSaida: TipoTransacao,
    public valLancamento: number,
    public dtaLancamento: Date,
    public dtaCreatedAt: Date,
    public dtaUpdatedAt: Date
  ) {}
}
