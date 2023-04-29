using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BoleteandoShared.DTO
{
    public class TicketDTO
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de uso")]
        [Required(ErrorMessage = "Debe proporcionar la fecha de uso")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime DateUsed { get; set; }


        [Display(Name = "Estado")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string State { get; set; } = null!;


        [Display(Name = "Porteria")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Goal { get; set; } = null!;
    }
}
