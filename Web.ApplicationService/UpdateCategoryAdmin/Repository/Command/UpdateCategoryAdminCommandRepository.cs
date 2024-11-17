using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Command;
using Web.Domain;
using Web.Domain.UpdateCategoryAdmin.Entity.Command;
using Web.Domain.UpdateCategoryAdmin.Repository.Command;

namespace Web.ApplicationService.UpdateCategoryAdmin.Repository.Command
{
    public class UpdateCategoryAdminCommandRepository: CommandRepository<UpdateCategoryAdminCommandEntity>, IUpdateCategoryAdminCommandRepository
    {
        private readonly IDapperContext context;
        public UpdateCategoryAdminCommandRepository(IDapperContext context):base(context)
        {
            this.context = context;
        }
    }
}
