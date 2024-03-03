using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario_Datos
{
    public class Proveedores : Base
    {
        [Key]
        public int IdProveedor { get; set; }
        public required string NombreProveedor { get; set; }
        public string? DireccionProveedor { get; set; }
        public string? TelefonoProveedor { get; set; }
        public string? CorreoProveedor { get; set; }
        public int? IdProductosSuministra { get; set; }

    }
}
