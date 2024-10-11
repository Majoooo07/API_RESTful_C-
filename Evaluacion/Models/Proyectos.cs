namespace Evaluacion.Models
{
    public class Proyectos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int DepartamentoId { get; set; }
        public Departamentos Departamentos { get; set; }
        public int? UsuarioId { get; set; } // Puede ser null si no tiene asignado usuario
        public Usuario Usuario { get; set; }
    }
}
