namespace Evaluacion.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int DepartamentoId { get; set; }
        public Departamentos Departamentos { get; set; } // Relación con Departamento
    }
}
