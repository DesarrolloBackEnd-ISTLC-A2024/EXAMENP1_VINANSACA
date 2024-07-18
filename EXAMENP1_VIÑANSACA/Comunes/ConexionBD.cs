
using Microsoft.Data.SqlClient;

namespace EXAMENP1_VIÑANSACA.Comunes
{

    public class ConexionBD
    {
        public static SqlConnection conexion;

        public static SqlConnection abrirConexion()
        {
            //conexion = new SqlConnection("Server=LT-EMANOSALVAS\\SQLEXPRESS;Database=PROYECTO_1;Trusted_Connection=True;");
            conexion = new SqlConnection("Server=JKV\\SQLEXPRESS;Database=;User Id=sa;Password=0417;TrustServerCertificate=True;");
            conexion.Open();
            return conexion;
        }

    }
}