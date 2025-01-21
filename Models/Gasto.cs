namespace MiniCore_Backend.Models
{
    public class Gasto
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Description { get; set; }
        public decimal Monto { get; set; }
        public int IDEmpleado { get; set; }
        public int IDDept { get; set; }
    }
}
