using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Command;
using Web.Domain;
using Web.Domain.DeleteCategoryAdmin.Entity.Command;
using Web.Domain.DeleteCategoryAdmin.Repository.Command;

namespace Web.ApplicationService.DeleteCategoryAdmin.Repository.Command
{
    public class DeleteCategoryAdminCommandRepository: CommandRepository<DeleteCategoryAdminCommandEntity>, IDeleteCategoryAdminCommandRepository
    {
        private readonly IDapperContext context;
        public DeleteCategoryAdminCommandRepository(IDapperContext context):base(context)
        {
            this.context = context;
        }
    }
}
