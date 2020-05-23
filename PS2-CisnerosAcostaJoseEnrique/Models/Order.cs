using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PS2_CisnerosAcostaJoseEnrique.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Numero de Orden")]
        public int NoOrden { get; set; }
        [Display(Name = "Nombre de Cliente")]
        public string NombreCliente { get; set; }
        [Display(Name = "Alimento")]
        public int MenuID { get; set; }
        [ForeignKey("MenuID")]
        public Menu Menu { get; set; }
    }
}