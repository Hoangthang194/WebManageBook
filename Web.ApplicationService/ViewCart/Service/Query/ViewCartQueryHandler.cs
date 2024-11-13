using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.ViewCart.Repository.Query;
using Web.Integration.ViewCart.Query;

namespace Web.ApplicationService.ViewCart.Service.Query
{
    public class ViewCartQueryHandler : IRequestHandler<ViewCartQuery, ViewCartQueryResult>
    {
        private readonly IViewCartQueryRepository repository;
        public ViewCartQueryHandler(IViewCartQueryRepository repository)
        {
            this.repository = repository;
        }
        public Task<ViewCartQueryResult> Handle(ViewCartQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
