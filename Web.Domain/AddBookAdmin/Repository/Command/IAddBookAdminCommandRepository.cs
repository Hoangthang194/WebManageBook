using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Command;
using Web.Domain.AddBookAdmin.Entity.Command;

namespace Web.Domain.AddBookAdmin.Repository.Command
{
    public interface IAddBookAdminCommandRepository : ICommandRepository<AddBookAdminCommandEntity>
    {
    }
}
