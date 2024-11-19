using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Web.Domain.UpdateBookAdmin.Entity.Command;
using Web.Domain.UpdateBookAdmin.Repository.Command;
using Web.Domain.UpdateCategoryAdmin.Entity.Command;
using Web.Integration.UpdateBookAdmin.Command;
using Web.Integration.UpdateCategoryAdmin.Command;

namespace Web.ApplicationService.UpdateBookAdmin.Service.Command
{
    public class UpdateBookAdminCommandHandler : IRequestHandler<UpdateBookAdminCommand, UpdateBookAdminCommandResult>
    {
        private readonly IUpdateBookAdminCommandRepository repository;
        public UpdateBookAdminCommandHandler(IUpdateBookAdminCommandRepository repository)
        {
            this.repository = repository;
        }
        public async Task<UpdateBookAdminCommandResult> Handle(UpdateBookAdminCommand request, CancellationToken cancellationToken)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                var entity = request.Adapt<UpdateBookAdminCommandEntity>();
                var result = await repository.Update(entity);
                transactionScope.Complete();

                if (result != 0)
                {
                    return new UpdateBookAdminCommandResult { Status = true };
                }
                return new UpdateBookAdminCommandResult();
            }
            catch
            {
                throw new NotImplementedException();

            }
        }
    }
}
