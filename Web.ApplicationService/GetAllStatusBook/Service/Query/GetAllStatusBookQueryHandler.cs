using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.GetAllStatusBook.Repository.Query;
using Web.Integration.GetAllStatusBook.Query;

namespace Web.ApplicationService.GetAllStatusBook.Service.Query
{
    public class GetAllStatusBookQueryHandler : IRequestHandler<GetAllStatusBookQuery, GetAllStatusBookQueryResult>
    {
        private readonly IGetAllStatusBookQueryRepository repository;
        public GetAllStatusBookQueryHandler(IGetAllStatusBookQueryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<GetAllStatusBookQueryResult> Handle(GetAllStatusBookQuery request, CancellationToken cancellationToken)
        {
            var result = await repository.GetAll();
            return new GetAllStatusBookQueryResult { Status = result.ToList() };
        }
    }
}
