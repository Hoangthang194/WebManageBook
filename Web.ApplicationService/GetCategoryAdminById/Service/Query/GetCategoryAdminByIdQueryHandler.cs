using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetCategoryAdminById.Repository.Query;
using Web.Integration.GetCategoryAdminById.Query;

namespace Web.ApplicationService.GetCategoryAdminById.Service.Query
{
    public class GetCategoryAdminByIdQueryHandler : IRequestHandler<GetCategoryAdminByIdQuery, GetCategoryAdminByIdQueryResult>
    {
        private readonly IGetCategoryAdminByIdQueryRepository repository;
        public GetCategoryAdminByIdQueryHandler(IGetCategoryAdminByIdQueryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<GetCategoryAdminByIdQueryResult> Handle(GetCategoryAdminByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await repository.GetById(request.CategoryId);
            return new GetCategoryAdminByIdQueryResult { Category = result };
        }
    }
}
