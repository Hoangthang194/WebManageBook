using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Web.Domain.AddBookAdmin.Entity.Command;
using Web.Domain.AddBookAdmin.Param.Command;
using Web.Domain.AddBookAdmin.Repository.Command;
using Web.Integration.AddBookAdmin.Command;
using Web.Integration.GetAllBookAdmin.Query;

namespace Web.ApplicationService.AddBookAdmin.Service.Command
{
    public class AddBookAdminCommandHandler : IRequestHandler<AddBookAdminCommand, AddBookAdminCommandResult>
    {
        private readonly IAddBookAdminCommandRepository repository;
        private readonly IMediator mediator;
        public AddBookAdminCommandHandler(IAddBookAdminCommandRepository repository, IMediator mediator)
        {
            this.repository = repository;
            this.mediator = mediator;
        }
        public async Task<AddBookAdminCommandResult> Handle(AddBookAdminCommand request, CancellationToken cancellationToken)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                var entity = request.Adapt<AddBookAdminCommandEntity>();
                var result = await repository.Add(entity);
                transactionScope.Complete();

                if (result != 0)
                {
                    // Get all book
                    var query = new GetAllBookAdminQuery();
                    var books = await mediator.Send(query);
                    return new AddBookAdminCommandResult { Status = true };
                }
                return new AddBookAdminCommandResult();
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
    }
}
