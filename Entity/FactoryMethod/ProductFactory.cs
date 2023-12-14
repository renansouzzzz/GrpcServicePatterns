namespace GrpcServicePatterns.Entity.FactoryMethod
{
    public class ProductFactory
    {
        public static Product Instance(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.Composit:

                    var productComposit = new Product();
                    productComposit.type = ProductType.Composit;
                    return productComposit;

                case ProductType.NotComposit:

                    var productNotComposit = new Product();
                    productNotComposit.type = ProductType.NotComposit;
                    return productNotComposit;

                default:
                    throw new NotImplementedException("Seu deve haver um tipo composto ou não!");
            }
        }
    }
}
