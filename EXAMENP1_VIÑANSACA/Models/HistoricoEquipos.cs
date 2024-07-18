namespace EXAMENP1_VIÑANSACA.Models
{
    public class HistoricoEquipos
    {
        public int Id { get; set; }
        public int FutbolistaId { get; set; }
        public int EquipoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string NombreEquipo { get; set; }
    }
}
