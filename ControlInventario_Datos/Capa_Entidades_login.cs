using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario_Datos
{
    public class Capa_Entidades_login
    {
        [Key]

        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public int PerfilID { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime UltimaConexion { get; set; }
    }
}
