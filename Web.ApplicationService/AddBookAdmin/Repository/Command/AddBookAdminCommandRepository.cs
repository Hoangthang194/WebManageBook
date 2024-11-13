using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Command;
using Web.Domain;
using Web.Domain.AddBookAdmin.Entity.Command;
using Web.Domain.AddBookAdmin.Repository.Command;

namespace Web.ApplicationService.AddBookAdmin.Repository.Command
{
    public class AddBookAdminCommandRepository: CommandRepository<AddBookAdminCommandEntity>, IAddBookAdminCommandRepository
    {
        private readonly IDapperContext context;
        public AddBookAdminCommandRepository(IDapperContext context):base(context)
        {
            this.context = context;
        }
    }
}
