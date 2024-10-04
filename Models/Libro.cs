namespace Biblioteca2API.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string NombreAutor { get; set; }
        public string Publicacion { get; set; }
        public string Editorial { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }


    }
}
