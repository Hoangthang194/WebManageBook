using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.DeleteCart.Repository.Command;
using Web.Integration.DeleteCart.Command;

namespace Web.ApplicationService.DeleteCart.Service.Command
{
    public class DeleteCartCommandHandler : IRequestHandler<DeleteCartCommand, DeleteCartCommandResult>
    {
        private readonly IDeleteCartCommandRepository repository;
        public DeleteCartCommandHandler(IDeleteCartCommandRepository repository)
        {
            this.repository = repository;
        }
        public Task<DeleteCartCommandResult> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
