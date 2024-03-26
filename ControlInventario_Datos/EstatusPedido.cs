using System.ComponentModel.DataAnnotations;

namespace ControlInventario_Datos
{
    public class EstatusPedido : Base
    {
        [Key]
        public int IdEstatusPedido { get; set; }
        public string Estatus { get; set; }
    }
}
