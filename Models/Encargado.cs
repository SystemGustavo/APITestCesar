namespace APITestCesar.Models
{
    public class Encargado
    {
        public int EncargadoId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public int DistritoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public List<DetalleProyecto>? DetalleProyecto { get; set; }
    }
}
