using Facturas.Utils;
using System;
using System.ComponentModel.DataAnnotations;

namespace Facturas.Models
{
    public class FacturaModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [IsPositive(ErrorMessage = "El campo {0} debe ser positivo")]
        public int Id { get; set; }

        [IsPositive(ErrorMessage = "El campo {0} debe ser positivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Nit { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Descripcion { get; set; }

        [IsPositive(ErrorMessage = "El campo {0} debe ser positivo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal ValorTotal { get; set; }

        [Range(0, 100, ErrorMessage = "El rango permitodo es entre {0} y {1}")]
        public int Porcentaje { get; set; }
    }
}
