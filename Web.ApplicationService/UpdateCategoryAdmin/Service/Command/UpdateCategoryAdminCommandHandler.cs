using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Web.Domain.UpdateCategoryAdmin.Entity.Command;
using Web.Domain.UpdateCategoryAdmin.Repository.Command;
using Web.Integration.UpdateCategoryAdmin.Command;

namespace Web.ApplicationService.UpdateCategoryAdmin.Service.Command
{
    public class UpdateCategoryAdminCommandHandler : IRequestHandler<UpdateCategoryAdminCommand, UpdateCategoryAdminCommandResult>
    {
        private readonly IUpdateCategoryAdminCommandRepository repository;
        public UpdateCategoryAdminCommandHandler(IUpdateCategoryAdminCommandRepository repository)
        {
            this.repository = repository;
        }
        public async Task<UpdateCategoryAdminCommandResult> Handle(UpdateCategoryAdminCommand request, CancellationToken cancellationToken)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                var entity = request.Adapt<UpdateCategoryAdminCommandEntity>();
                var result = await repository.Update(entity);
                transactionScope.Complete();

                if (result != 0)
                {
                    return new UpdateCategoryAdminCommandResult { Status = true };
                }
                return new UpdateCategoryAdminCommandResult();
            }
            catch
            {
                throw new NotImplementedException();

            }
        }
    }
}
