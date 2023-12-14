using Grpc.Core;
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

        //public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        //{
        //    return Task.FromResult(new HelloReply
        //    {
        //        Message = "Hello " + request.Name
        //    });
        //}
    }
}
