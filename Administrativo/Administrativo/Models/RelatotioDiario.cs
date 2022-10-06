using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Administrativo.Models
{
    public class RelatotioDiario
    {
        [Display(Name = "Valor entrada")]
        public decimal ValEntrada { get; set; }
        [Display(Name = "Valor saída")]
        public decimal ValSaida { get; set; }
        [Display(Name = "Saldo")]
        public decimal Saldo { get; set; }
        [Display(Name = "Dia de referência")]
        public DateTime DiaReferencia { get; set; }
        [Display(Name = "Todos lancamentos do dia")]
        public List<Lancamento> Lancamentos { get; set; }
        public Lancamento Lancamento { get; set; }

        public RelatotioDiario(List<Lancamento> lancamentos)
        {
            Lancamentos = lancamentos;
        }
    }
}
