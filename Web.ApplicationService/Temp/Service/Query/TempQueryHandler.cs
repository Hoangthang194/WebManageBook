using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Temp.Repository.Query;
using Web.Integration.Temp.Query;

namespace Web.ApplicationService.Temp.Service.Query
{
    public class TempQueryHandler : IRequestHandler<TempQuery, TempQueryResult>
    {
        private readonly ITempQueryRepository repository;
        public TempQueryHandler(ITempQueryRepository repository)
        {
            this.repository = repository;
        }
        public Task<TempQueryResult> Handle(TempQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
