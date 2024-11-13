using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Command;
using Web.Domain.DeleteCart.Entity.Command;

namespace Web.Domain.DeleteCart.Repository.Command
{
    public interface IDeleteCartCommandRepository : ICommandRepository<DeleteCartCommandEntity>
    {
    }
}
