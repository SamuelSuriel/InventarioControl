using System.ComponentModel.DataAnnotations;

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
        public string? UltimaConexion { get; set; }
        public string? Perfil { get; set; }
    }
}
