using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Temp.Repository.Command;
using Web.Integration.Temp.Command;

namespace Web.ApplicationService.Temp.Service.Command
{
    public class TempCommandHandler : IRequestHandler<TempCommand, TempCommandResult>
    {
        private readonly ITempCommandRepository repository;
        public TempCommandHandler(ITempCommandRepository repository)
        {
            this.repository = repository;
        }
        public Task<TempCommandResult> Handle(TempCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
