
using EXAMENP1_VIÑANSACA.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EXAMENP1_VIÑANSACA.Comunes
{

    public class ConexionBD
    {
        public static SqlConnection conexion;

        public static SqlConnection abrirConexion()
        {
            //conexion = new SqlConnection("Server=LT-EMANOSALVAS\\SQLEXPRESS;Database=PROYECTO_1;Trusted_Connection=True;");
            conexion = new SqlConnection("Server=JKV\\SQLEXPRESS;Database=EXAMEN;User Id=sa;Password=0417;TrustServerCertificate=True;");
            conexion.Open();
            return conexion;
        }

        public static List<Futbolista> Futbolistas()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = abrirConexion();
            cmd.CommandText = "spConsultarFutbolistasActivos";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return llenarfutbolistas(dataSet.Tables[0]);
        }


        private static List<Futbolista> llenarfutbolistas(DataTable dataTable)
        {
            List<Futbolista> lRespuesta = new List<Futbolista>();
            Futbolista objeto = new Futbolista();
            foreach (DataRow dr in dataTable.Rows)
            {
                objeto = new Futbolista();
                objeto.Id = Convert.ToInt32(dr["Id"]);
                objeto.Nombre = dr["Nombre"].ToString();
                objeto.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                objeto.Nacionalidad = dr["Nacionalidad"].ToString();
                objeto.Posicion = dr["Posicion"].ToString();
                objeto.Altura = Convert.ToInt32(dr["Altura"]);
                objeto.Peso = Convert.ToInt32(dr["Peso"]);
                objeto.Estado = dr["Estado"].ToString();
                lRespuesta.Add(objeto);
            }
            return lRespuesta;



        }

        public static Futbolista Jugador(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = abrirConexion();
            cmd.CommandText = "spConsultarFutbolista";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return llenarfutbolistas(dataSet.Tables[0])[0];

        }

        public static void PostFutbolista(Futbolista obJFutbolista)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = abrirConexion();
            cmd.CommandText = "spCrearFutbolista";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", obJFutbolista.Nombre);
            cmd.Parameters.AddWithValue("@FechaNacimiento", obJFutbolista.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Nacionalidad", obJFutbolista.Nacionalidad);
            cmd.Parameters.AddWithValue("@Posicion", obJFutbolista.Posicion);
            cmd.Parameters.AddWithValue("@Altura", obJFutbolista.Altura);
            cmd.Parameters.AddWithValue("@Peso", obJFutbolista.Peso);
            cmd.ExecuteNonQuery();

        }

        public static void PutFutbolista(int Id, Futbolista obJFutbolista)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = abrirConexion();
            cmd.CommandText = "spActualizarFutbolista";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Nombre", obJFutbolista.Nombre);
            cmd.Parameters.AddWithValue("@FechaNacimiento", obJFutbolista.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Nacionalidad", obJFutbolista.Nacionalidad);
            cmd.Parameters.AddWithValue("@Posicion", obJFutbolista.Posicion);
            cmd.Parameters.AddWithValue("@Altura", obJFutbolista.Altura);
            cmd.Parameters.AddWithValue("@Peso", obJFutbolista.Peso);
            cmd.Parameters.AddWithValue("@Estado", obJFutbolista.Estado);

            cmd.ExecuteNonQuery();
        }

        public static void DeleteFutbolista(int Id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = abrirConexion();
            cmd.CommandText = "spEliminarFutbolista";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
        }

        public static List<HistoricoEquipos> GetHistoricoEquipos(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = abrirConexion();
            cmd.CommandText = "spConsultarHistoricoEquipos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FutbolistaId", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return llenarHistorico(dataSet.Tables[0]);
        }

        public static List<HistoricoEquipos> llenarHistorico(DataTable dataTable)
        {
            List<HistoricoEquipos> lRespuesta = new List<HistoricoEquipos>();
            foreach (DataRow dr in dataTable.Rows)
            {
                HistoricoEquipos objeto = new HistoricoEquipos();
                objeto.NombreFutbolista = dr["NombreFutbolista"].ToString();
                objeto.NombreEquipo = dr["NombreEquipo"].ToString();
                objeto.FechaInicio = Convert.ToDateTime(dr["FechaInicio"].ToString());
                objeto.FechaFin = Convert.ToDateTime(dr["FechaFin"].ToString());
                lRespuesta.Add(objeto);
            }
            return lRespuesta;

        }

    }
}