using System.ComponentModel.DataAnnotations;

namespace ControlInventario_Datos
{
    public class Informes : Base
    {
        [Key]
        public int InformeID { get; set; }
        public string? TipoInforme { get; set; }
        public string? Detalles { get; set; }
        public DateTime? FechaGeneracion { get; set; }
    }
}
