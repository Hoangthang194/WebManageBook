using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetAllBookAdmin.Repository.Query;
using Web.Integration.GetAllBookAdmin.Query;

namespace Web.ApplicationService.GetAllBookAdmin.Service.Query
{
    public class GetAllBookAdminQueryHandler : IRequestHandler<GetAllBookAdminQuery, GetAllBookAdminQueryResult>
    {
        private readonly IGetAllBookAdminQueryRepository repository;
        public GetAllBookAdminQueryHandler(IGetAllBookAdminQueryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<GetAllBookAdminQueryResult> Handle(GetAllBookAdminQuery request, CancellationToken cancellationToken)
        {
            var result = await repository.GetAllInforBook();

            return new GetAllBookAdminQueryResult
            {
                Books = result.ToList()
            };
        }
    }
}
