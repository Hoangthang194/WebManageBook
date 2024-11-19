using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Command;
using Web.Domain.UpdateBookAdmin.Entity.Command;

namespace Web.Domain.UpdateBookAdmin.Repository.Command
{
    public interface IUpdateBookAdminCommandRepository : ICommandRepository<UpdateBookAdminCommandEntity>
    {
    }
}
