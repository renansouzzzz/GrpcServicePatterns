namespace GrpcServicePatterns.Entity.Singleton
{
    public class ProductSingleton : Product
    {
        private static readonly ProductSingleton INSTANCE = new ProductSingleton();

        private static ProductSingleton Instance
        {
            get
            {
                return INSTANCE;
            }
        }
    }
}
