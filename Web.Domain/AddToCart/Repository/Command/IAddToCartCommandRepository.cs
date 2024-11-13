using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Core.Command;
using Web.Domain.AddToCart.Entity.Command;
using Web.Domain.AddToCart.Param.Command;

namespace Web.Domain.AddToCart.Repository.Command
{
    public interface IAddToCartCommandRepository : ICommandRepository<AddToCartCommandEntity>
    {
        public Task<int?> AddToCart(AddToCartCommandParam param);
    }
}
