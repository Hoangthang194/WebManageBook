using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Command;
using Web.Domain.UpdateCategoryAdmin.Entity.Command;

namespace Web.Domain.UpdateCategoryAdmin.Repository.Command
{
    public interface IUpdateCategoryAdminCommandRepository : ICommandRepository<UpdateCategoryAdminCommandEntity>
    {
    }
}
