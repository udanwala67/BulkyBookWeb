namespace BulkyBookWeb.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DispalyOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
