using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Login.Param.Query;
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
        public async Task<LoginQueryResult> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
			var param = request.Adapt<LoginQueryParam>();
			var result = await this.repository.GetLoginInformation(param);
			var response = new LoginQueryResult
			{
				LoginEntity = result,
			};
			return response;
		}
    }
}
