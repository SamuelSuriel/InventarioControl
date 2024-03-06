using ControlInventario_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlInventario_Datos;

namespace ControlInventario_Negocio
{
    public class CN_Login
    {
        ControlInventario_Datos.Login_usuarios objd = new ControlInventario_Datos.Login_usuarios();

        public DataTable N_login(ControlInventario_Datos.Capa_Entidades_login obje)
        {
            return objd.D_login(obje);
        }

            
    }
}
