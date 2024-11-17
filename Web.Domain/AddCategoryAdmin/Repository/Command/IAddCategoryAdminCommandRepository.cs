using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Command;
using Web.Domain.AddCategoryAdmin.Entity.Command;

namespace Web.Domain.AddCategoryAdmin.Repository.Command
{
    public interface IAddCategoryAdminCommandRepository : ICommandRepository<AddCategoryAdminCommandEntity>
    {
    }
}
