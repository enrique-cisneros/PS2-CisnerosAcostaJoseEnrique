using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PS2_CisnerosAcostaJoseEnrique.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [Display(Name = "Tipo de Alimento")]
        public string TipoAlimento { get; set; }
        [Display(Name = "Nombre")]
        public string Producto { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Calorias")]
        public int Calorias { get; set; }
        [Display(Name = "Precio")]
        public float Precio { get; set; }
    }
}