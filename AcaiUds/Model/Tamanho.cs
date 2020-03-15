using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiUds.Model
{
    [Table("Tamanho")]
    public class Tamanho
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse Item é obrigatorio")]
        public string Nome { get; set; }

        public string DescricaoItem { get; set; }

        public int TempoPreparo { get; set; }

        public decimal Valor { get; set; }

        public Sabores Sabor { get; set; }
    }
}
