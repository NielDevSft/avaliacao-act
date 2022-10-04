export default class Lancamentos {
  constructor(
    public id: number,
    public desLancamento: string,
    public indEntradaSaida: number,
    public valLancamento: number,
    public dtaTransacao: string,
  ) {}
}
