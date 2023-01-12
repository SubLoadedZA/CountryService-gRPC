﻿using Apress.Sample.gRPC;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static Apress.Sample.gRPC.CountryService;

namespace CountryService.Web.Services
{
    public class CountryGrpcService : CountryServiceBase
    {
        public override async Task GetAll(Empty request, IServerStreamWriter
       <CountryReply> responseStream, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, ""));
        }
        public override async Task<CountryReply> Get(CountryIdRequest request,
       ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, ""));
        }
        public override async Task<Empty> Delete(IAsyncStreamReader<CountryIdRequest> requestStream, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, ""));
        }
        public override async Task<Empty> Update(CountryUpdateRequest request,
       ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, ""));
        }
        public override async Task Create(IAsyncStreamReader<CountryCreationRequest> requestStream, IServerStreamWriter<CountryCreationReply>
responseStream, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, ""));
        }
    }

}
