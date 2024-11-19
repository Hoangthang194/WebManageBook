using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetAllBook.Repository.Query;
using Web.Integration.GetAllBook.Query;
using Web.Integration.GetAllBookAdmin.Query;

namespace Web.ApplicationService.GetAllBook.Service.Query
{
    public class GetAllBookQueryHandler : IRequestHandler<GetAllBookQuery, GetAllBookQueryResult>
    {
        private readonly IGetAllBookQueryRepository repository;
        public GetAllBookQueryHandler(IGetAllBookQueryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<GetAllBookQueryResult> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            var result = await this.repository.GetAllInforBookk();

            return new GetAllBookQueryResult
            {
                Books = result.ToList()
            };
        }
    }
}
