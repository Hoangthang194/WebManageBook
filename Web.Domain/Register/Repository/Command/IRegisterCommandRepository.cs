using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Command;
using Web.Domain.Register.Entity.Command;

namespace Web.Domain.Register.Repository.Command
{
    public interface IRegisterCommandRepository : ICommandRepository<RegisterCommandEntity>
    {

    }
}
