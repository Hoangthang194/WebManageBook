using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Web.Domain.Register.Entity.Command;
using Web.Domain.Register.Repository.Command;
using Web.Integration.GetUserByEmail.Query;
using Web.Integration.GetUserById.Query;
using Web.Integration.Register.Command;

namespace Web.ApplicationService.Register.Service.Command
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterCommandResult>
    {
        private readonly IRegisterCommandRepository repository;
        private readonly IMediator mediator;
        public RegisterCommandHandler(IRegisterCommandRepository repository, IMediator mediator)
        {
            this.repository = repository;
            this.mediator = mediator;   
        }
        public async Task<RegisterCommandResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                //Check email đã tồn tại chưa
                var queryExístEmail = new GetUserByEmailQuery
                {
                    UserEmail = request.UserEmail,
                };
                var userExist = await mediator.Send(queryExístEmail);
                if (userExist.User != null) {
                    return new RegisterCommandResult
                    {
                        Status = false
                    };
                }
                var entity = request.Adapt<RegisterCommandEntity>();
                var result = await repository.Add(entity);
                // Get user id by email
                var query = new GetUserByEmailQuery
                {
                    UserEmail = request.UserEmail,
                };
                var user = await mediator.Send(query);
                transactionScope.Complete();
                if (result != 0)
                {
                    return new RegisterCommandResult { Status = true, UserId = user.User.UserId };
                }
                return new RegisterCommandResult();
            }
            catch
            {
                return new RegisterCommandResult();

            }

        }
    }
}
