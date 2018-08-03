using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiOData.Models
{
    [Table("Vagas")]
    public class Vaga
    {
        public int Id {get;set;}

        [Required]
        public string Titulo { get; set; }

        [Required]
        public decimal Salario { get; set; }

        [Required]
        public string Local { get; set; }
    }
}