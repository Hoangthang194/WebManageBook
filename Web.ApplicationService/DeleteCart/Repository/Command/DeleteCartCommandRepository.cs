using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Command;
using Web.Domain;
using Web.Domain.DeleteCart.Entity.Command;
using Web.Domain.DeleteCart.Repository.Command;

namespace Web.ApplicationService.DeleteCart.Repository.Command
{
    public class DeleteCartCommandRepository: CommandRepository<DeleteCartCommandEntity>, IDeleteCartCommandRepository
    {
        private readonly IDapperContext context;
        public DeleteCartCommandRepository(IDapperContext context):base(context)
        {
            this.context = context;
        }
    }
}
