namespace MyMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; //nullable type
        public string Description { get; set; } = string.Empty;
    }
}
