namespace GrpcServicePatterns.Entity.Builder
{
    public class ProductBuilder
    {
        private readonly Product _product;

        public ProductBuilder()
        {
            _product = new Product();
        }

        public ProductBuilder Name(string name)
        {
            _product.name = name;
            return this;
        }

        public ProductBuilder Price(decimal price)
        {
            _product.price = price;
            return this;
        }

        public ProductBuilder Type(ProductType type)
        {
            _product.type = type;
            return this;
        }
    }
}