using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Register.Entity.Command;
using Web.Domain.Register.Repository.Command;
using Web.Integration.Register.Command;

namespace Web.ApplicationService.Register.Service.Command
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterCommandResult>
    {
        private readonly IRegisterCommandRepository repository;
        public RegisterCommandHandler(IRegisterCommandRepository repository)
        {
            this.repository = repository;
        }
        public async Task<RegisterCommandResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var entity = request.Adapt<RegisterCommandEntity>();
            var result = await repository.Add(entity);
            if(result != 0)
            {
                return new RegisterCommandResult { Status = true };
            }
            return new RegisterCommandResult();
        }
    }
}
