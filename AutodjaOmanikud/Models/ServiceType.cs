namespace AutodjaOmanikud.Models
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public ICollection<Service> Services { get; set; } = new List<Service>();
    }
}