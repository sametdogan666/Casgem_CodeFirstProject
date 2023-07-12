namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string DestinationName { get; set; }
        public string DayNight { get; set; }
        public byte Capacity { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }

    }
}