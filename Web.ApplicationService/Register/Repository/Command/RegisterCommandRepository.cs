using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Command;
using Web.Domain;
using Web.Domain.Register.Entity.Command;
using Web.Domain.Register.Repository.Command;

namespace Web.ApplicationService.Register.Repository.Command
{
    public class RegisterCommandRepository: CommandRepository<RegisterCommandEntity>, IRegisterCommandRepository
    {
        private readonly IDapperContext context;
        public RegisterCommandRepository(IDapperContext context):base(context)
        {
            this.context = context;
        }
    }
}
