using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario_Datos
{
    public class Productos : Base 
    {
        [Key]
        public int IdProducto { get; set; }
        public string? NombreProducto { get; set; }
        public string? CodigoProducto { get; set; }
        public string? Descripcion { get; set; }
        public int CantidadStock { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }

    }
}
