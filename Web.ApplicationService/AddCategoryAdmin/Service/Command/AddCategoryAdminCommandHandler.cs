using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Web.Domain.AddCategoryAdmin.Entity.Command;
using Web.Domain.AddCategoryAdmin.Repository.Command;
using Web.Integration.AddCategoryAdmin.Command;

namespace Web.ApplicationService.AddCategoryAdmin.Service.Command
{
    public class AddCategoryAdminCommandHandler : IRequestHandler<AddCategoryAdminCommand, AddCategoryAdminCommandResult>
    {
        private readonly IAddCategoryAdminCommandRepository repository;
        public AddCategoryAdminCommandHandler(IAddCategoryAdminCommandRepository repository)
        {
            this.repository = repository;
        }
        public async Task<AddCategoryAdminCommandResult> Handle(AddCategoryAdminCommand request, CancellationToken cancellationToken)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);

                var entity = new AddCategoryAdminCommandEntity
                {
                    CategoryName = request.CategoryName
                };
                var result = await repository.Add(entity);
                transactionScope.Complete();
                if (result != 0)
                {
                    return new AddCategoryAdminCommandResult
                    {
                        Status = true
                    };
                }
                return new AddCategoryAdminCommandResult();
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
