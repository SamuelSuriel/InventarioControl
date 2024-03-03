using System.ComponentModel.DataAnnotations;

namespace ControlInventario_Datos
{
    public class AlertasStock : Base
    {
        [Key]
        public int AlertaID { get; set; }
        public int IdProducto { get; set; }
        public int? NivelStockBajo { get; set; }
        public DateTime? FechaAlerta { get; set; }
    }
}
