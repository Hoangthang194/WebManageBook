using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetAllCategoryAdmin.Param.Query;
using Web.Domain.GetAllCategoryAdmin.Repository.Query;
using Web.Integration.GetAllCategoryAdmin.Query;

namespace Web.ApplicationService.GetAllCategoryAdmin.Service.Query
{
    public class GetAllCategoryAdminQueryHandler : IRequestHandler<GetAllCategoryAdminQuery, GetAllCategoryAdminQueryResult>
    {
        private readonly IGetAllCategoryAdminQueryRepository repository;
        public GetAllCategoryAdminQueryHandler(IGetAllCategoryAdminQueryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<GetAllCategoryAdminQueryResult> Handle(GetAllCategoryAdminQuery request, CancellationToken cancellationToken)
        {
            var result = await repository.GetAll();
            return new GetAllCategoryAdminQueryResult { Categories = result.ToList() };
        }
    }
}
