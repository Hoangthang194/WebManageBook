using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Command;
using Web.Domain.Temp.Entity.Command;

namespace Web.Domain.Temp.Repository.Command
{
    public interface ITempCommandRepository : ICommandRepository<TempCommandEntity>
    {
    }
}
