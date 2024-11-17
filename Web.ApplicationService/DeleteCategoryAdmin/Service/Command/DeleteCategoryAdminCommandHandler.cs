using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Web.Domain.DeleteCategoryAdmin.Entity.Command;
using Web.Domain.DeleteCategoryAdmin.Repository.Command;
using Web.Integration.DeleteCategoryAdmin.Command;

namespace Web.ApplicationService.DeleteCategoryAdmin.Service.Command
{
    public class DeleteCategoryAdminCommandHandler : IRequestHandler<DeleteCategoryAdminCommand, DeleteCategoryAdminCommandResult>
    {
        private readonly IDeleteCategoryAdminCommandRepository repository;
        public DeleteCategoryAdminCommandHandler(IDeleteCategoryAdminCommandRepository repository)
        {
            this.repository = repository;
        }
        public async Task<DeleteCategoryAdminCommandResult> Handle(DeleteCategoryAdminCommand request, CancellationToken cancellationToken)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);

                var entity = new DeleteCategoryAdminCommandEntity
                {
                    CategoryId = request.CategoryId,
                    IsDeleted = true
                };
                var result = await repository.Update(entity);
                transactionScope.Complete();
                if(result!= 0)
                return new DeleteCategoryAdminCommandResult { Status = true };
                return new DeleteCategoryAdminCommandResult();
            }
            catch
            {
                throw new NotImplementedException();

            }
        }
    }
}
