using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiUds.Model
{
    [Table("Sabores")]
    public class Sabores
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatorio Colocar o nome do sabor")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        //public Tamanho Tamanho { get; set; }
    }
}
