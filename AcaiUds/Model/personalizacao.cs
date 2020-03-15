using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiUds.Model
{
    [Table("Personalizacao")]
    public class personalizacao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nome obrigatório!")]
        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
