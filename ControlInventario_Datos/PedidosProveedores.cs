using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario_Datos
{
    public class PedidosProveedores : Base
    {
        [Key]
        public int PedidoID { get; set; }
        public int IdProveedor { get; set; }
        public int Idproducto { get; set; }
        public int IdEstatusPedido { get; set; }
        public DateTime? FechaPedido { get; set; }
        public int? CantidadProductos { get; set; }

    }
}
