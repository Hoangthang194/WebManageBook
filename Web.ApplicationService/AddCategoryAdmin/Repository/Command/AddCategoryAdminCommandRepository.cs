using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Command;
using Web.Domain;
using Web.Domain.AddCategoryAdmin.Entity.Command;
using Web.Domain.AddCategoryAdmin.Repository.Command;

namespace Web.ApplicationService.AddCategoryAdmin.Repository.Command
{
    public class AddCategoryAdminCommandRepository: CommandRepository<AddCategoryAdminCommandEntity>, IAddCategoryAdminCommandRepository
    {
        private readonly IDapperContext context;
        public AddCategoryAdminCommandRepository(IDapperContext context):base(context)
        {
            this.context = context;
        }
    }
}
