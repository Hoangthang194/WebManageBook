using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Login.Repository.Query;
using Web.Integration.Login.Query;

namespace Web.ApplicationService.Login.Service.Query
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, LoginQueryResult>
    {
        private readonly ILoginQueryRepository repository;
        public LoginQueryHandler(ILoginQueryRepository repository)
        {
            this.repository = repository;
        }
        public Task<LoginQueryResult> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
