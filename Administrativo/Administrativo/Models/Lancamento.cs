using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Administrativo.Models
{
    [Table("tab_lancamento")]
    public class Lancamento
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("des_lancamento")]
        [Display(Name = "Descrição Lancamento")]
        public string? DesLancament { get; set; }

        [Column("ind_entrada_saida")]
        [Display(Name = "Tipo transação")]
        public TipoTransacao IndEntradaSaida { get; set; }

        [Column("val_lancamento")]
        [Display(Name="Valor")]
        public decimal ValLancamento { get; set; }

        [Column("dta_lancamento"), DataType("Date")]
        [Display(Name="Data")]
        public DateTime DtaLancamento { get; set; }
        
        [Column("dta_create_at")]
        [Display(Name = "Dia do registro")]
        public DateTime DtaCreateAt { get; set; }

        [Column("dta_updated_at")]
        [Display(Name = "Ultima atualização")]
        public DateTime DtaUpdatedAt { get; set; }
    }
    public enum TipoTransacao
    {
        Entrada = 1,
        Saida = 2
    }


}
