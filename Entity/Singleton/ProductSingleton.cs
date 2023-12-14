namespace GrpcServicePatterns.Entity.Singleton
{
    public class ProductSingleton : Product
    {
        private static ProductSingleton INSTANCE = new ProductSingleton();

        private static ProductSingleton getInstance()
        { 
            return INSTANCE;
        }
    }
}
