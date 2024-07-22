namespace APITestCesar.Models
{
    public class DetalleProyecto
    {
        public int ProyectoId { get; set; }
        public int ClienteId { get; set; }
        public int EncargadoId { get; set; }
        public string Descripcion { get; set; }
        public Proyecto? Proyecto { get; set; }
        public Cliente? Cliente { get; set; }
        public Encargado? Encargado { get; set; }
    }
}
