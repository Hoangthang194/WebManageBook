using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetUserByEmail.Param.Query;
using Web.Domain.GetUserByEmail.Repository.Query;
using Web.Integration.GetUserByEmail.Query;

namespace Web.ApplicationService.GetUserByEmail.Service.Query
{
    public class GetUserByEmailQueryHandler : IRequestHandler<GetUserByEmailQuery, GetUserByEmailQueryResult>
    {
        private readonly IGetUserByEmailQueryRepository repository;
        public GetUserByEmailQueryHandler(IGetUserByEmailQueryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<GetUserByEmailQueryResult> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
        {
            var param = request.Adapt<GetUserByEmailQueryParam>();
            var result = await repository.GetUserByEmail(param);
            return new GetUserByEmailQueryResult
            {
                User = result
            };
        }
    }
}
