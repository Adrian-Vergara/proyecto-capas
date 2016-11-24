using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cliente
    {
        public Cliente()
        {
            Proyectos = new List<Proyecto>();
            Facturas = new List<Facturas>();
        }
        
        public int ClienteId { get; set; }
        
        [Required]
        [StringLength(35)]
        // [Column("Fecha", TypeName = "datetime2", Order = 1)]
        public string Nombre { get; set; }
        
        public string Telefono { get; set; }
        public string Direccion { get; set; }
     
        public virtual List<Proyecto> Proyectos { get; set; }
        public virtual List<Facturas> Facturas { get; set; }
    }
}
