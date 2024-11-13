using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Command;
using Web.Domain;
using Web.Domain.AddToCart.Entity.Command;
using Web.Domain.AddToCart.Param.Command;
using Web.Domain.AddToCart.Repository.Command;

namespace Web.ApplicationService.AddToCart.Repository.Command
{
    public class AddToCartCommandRepository: CommandRepository<AddToCartCommandEntity>, IAddToCartCommandRepository
    {
        private readonly IDapperContext context;
        public AddToCartCommandRepository(IDapperContext context):base(context)
        {
            this.context = context;
        }
        public async Task<int?> AddToCart(AddToCartCommandParam param)
        {
            var sql = @"
            INSERT INTO Carts
                  ([CartId], [UserId], [TotalNumberBook], [TotalMoney])
            VALUES
                  (@CartId , @UserId , @TotalNumber , @TotalMoney );
            ";
            try
            {
                var result = await this.context.Connection.ExecuteAsync(sql, param);
                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
