using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetUserById.Repository.Query;
using Web.Integration.GetUserById.Query;

namespace Web.ApplicationService.GetUserById.Service.Query
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, GetUserByIdQueryResult>
    {
        private readonly IGetUserByIdQueryRepository repository;
        public GetUserByIdQueryHandler(IGetUserByIdQueryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<GetUserByIdQueryResult> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await repository.GetById(request.UserId);

            return new GetUserByIdQueryResult { User = result };
        }
    }
}
