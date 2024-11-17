using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Web.Domain.AddBookAdmin.Entity.Command;
using Web.Domain.AddBookAdmin.Repository.Command;
using Web.Integration.AddBookAdmin.Command;

namespace Web.ApplicationService.AddBookAdmin.Service.Command
{
    public class AddBookAdminCommandHandler : IRequestHandler<AddBookAdminCommand, AddBookAdminCommandResult>
    {
        private readonly IAddBookAdminCommandRepository repository;
        public AddBookAdminCommandHandler(IAddBookAdminCommandRepository repository)
        {
            this.repository = repository;
        }
        public async Task<AddBookAdminCommandResult> Handle(AddBookAdminCommand request, CancellationToken cancellationToken)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                // Calculate price new
                var priceNew = request.PriceOld - (request.PriceOld * request.PercentVourcher) / 100;
                var entity = request.Adapt<AddBookAdminCommandEntity>();
                entity.PriceNew = priceNew;
                var result = await repository.Add(entity);
                transactionScope.Complete();
                if(result != 0)
                {
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
