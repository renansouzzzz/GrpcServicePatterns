namespace GrpcServicePatterns.Entity
{
    public class Product
    {
        public int id { get; set; }

        public string name { get; set; }

        public decimal price { get; set; }

        public ProductType type { get; set; }
    }
}
