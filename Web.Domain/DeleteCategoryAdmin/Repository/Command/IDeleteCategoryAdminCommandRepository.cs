using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Command;
using Web.Domain.DeleteCategoryAdmin.Entity.Command;

namespace Web.Domain.DeleteCategoryAdmin.Repository.Command
{
    public interface IDeleteCategoryAdminCommandRepository : ICommandRepository<DeleteCategoryAdminCommandEntity>
    {
    }
}
