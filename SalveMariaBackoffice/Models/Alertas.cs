using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalveMariaBackoffice.Models
{
    [Table("alertas")]
    public class Alertas
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("endereco")]
        public string Endereco { get; set; }
        [Column("latitude")]
        public string Latitude { get; set; }
        [Column("longitude")]
        public string Longitude { get; set; }
    }
}
