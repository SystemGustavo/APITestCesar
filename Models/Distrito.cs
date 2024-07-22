namespace APITestCesar.Models
{
    public class Distrito
    {
        public int DistritoId { get; set; }
        public string Nombre { get; set; }
        public List<Cliente>? Cliente { get; set; }
    }
}
