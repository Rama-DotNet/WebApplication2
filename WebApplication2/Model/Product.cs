namespace WebApplication2.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }
        public int Price { get; set; }
    }
}
