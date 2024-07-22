namespace APITestCesar.Models
{
    public class Proyecto
    {
        public int ProyectoId { get; set; }
        public DateTime FechaProyecto { get; set; }
        public decimal Monto { get; set; }
        public List<DetalleProyecto>? DetalleProyecto { get; set; }
    }
}
