using ECO.Service.Basket.Protos;
using Grpc.Core;

namespace ECO.Service.Basket.Grpc
{
    public class BasketGrpcService : BasketProtoService.BasketProtoServiceBase
    {
        private readonly ILogger<BasketGrpcService> _logger;

        public BasketGrpcService(ILogger<BasketGrpcService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
