﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario_Datos
{
    public class RegistroVentas : Base
    {
        [Key]
        public int IdRegistroVenta { get; set; }
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public int? CantidadVendida { get; set; }
        public double PrecioVenta { get; set; }
        public DateTime? FechaVenta { get; set; }
        public string ClienteVenta { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public int? IdUsuarioModificacion { get; set; }

    }
}
