using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BoleteandoShared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
      
        
        [Display(Name = "Fecha de uso")]               
        public DateTime DateUsed { get; set; } = DateTime.MinValue;


        [Display(Name = "Estado")]          
        public bool State { get; set; } = false!;


        [Display(Name = "Porteria")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]        
        public string Goal { get; set; } = null!;

    }
}