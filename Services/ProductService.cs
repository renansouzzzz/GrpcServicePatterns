using GrpcServicePatterns.Protos;

namespace GrpcServicePatterns.Services
{
    public class ProductService : ProductProtoService.ProductProtoServiceBase
    {
        private readonly ILogger<ProductService> _logger;
        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        public Task<ProductModel> GetProductModel()
        {
            return Task.FromResult(new ProductModel
            {
                Id = ProductModel.IdFieldNumber,
                Name = ProductModel.NameFieldNumber,
                Price = ProductModel.PriceFieldNumber,
                ProductType = ProductModel.ProductTypeFieldNumber,
            });
        }
    }
}
