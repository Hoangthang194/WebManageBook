using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Command;
using Web.Domain;
using Web.Domain.UpdateBookAdmin.Entity.Command;
using Web.Domain.UpdateBookAdmin.Repository.Command;

namespace Web.ApplicationService.UpdateBookAdmin.Repository.Command
{
    public class UpdateBookAdminCommandRepository: CommandRepository<UpdateBookAdminCommandEntity>, IUpdateBookAdminCommandRepository
    {
        private readonly IDapperContext context;
        public UpdateBookAdminCommandRepository(IDapperContext context):base(context)
        {
            this.context = context;
        }
    }
}
