using YourNamespace.Models;

namespace Evaluacion.Models
{

    public class Departamentos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Proyectos> Proyectos { get; set; }
    }
}
