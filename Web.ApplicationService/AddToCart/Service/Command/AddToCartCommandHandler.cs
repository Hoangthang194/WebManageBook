using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Web.Domain.AddToCart.Param.Command;
using Web.Domain.AddToCart.Repository.Command;
using Web.Integration.AddToCart.Command;

namespace Web.ApplicationService.AddToCart.Service.Command
{
    public class AddToCartCommandHandler : IRequestHandler<AddToCartCommand, AddToCartCommandResult>
    {
        private readonly IAddToCartCommandRepository repository;
        public AddToCartCommandHandler(IAddToCartCommandRepository repository)
        {
            this.repository = repository;
        }
        public async Task<AddToCartCommandResult> Handle(AddToCartCommand request, CancellationToken cancellationToken)
        {
            var param = new AddToCartCommandParam
            {
                UserId = request.UserId,
            };
            try
            {
                using var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                var result = await this.repository.AddToCart(param);
                transaction.Complete();
                if (result != null || result != 0)
                {
                    return new AddToCartCommandResult();
                }
                return new AddToCartCommandResult();
            }
            catch
            {
                throw;
            }
        }
    }
}
