namespace HPlusport.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<Product> Products { get; set; }
    }
}
