using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Query;
using Web.Domain;
using Web.Domain.GetAllBook.Entity.Query;
using Web.Domain.GetAllBook.Repository.Query;
using Web.Domain.GetAllBookAdmin.Entity.Query;

namespace Web.ApplicationService.GetAllBook.Repository.Query
{
    public class GetAllBookQueryRepository : QueryRepository<GetAllBookQueryEntity>, IGetAllBookQueryRepository
    {
        private readonly IDapperContext context;
        public GetAllBookQueryRepository(IDapperContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<List<GetAllBookQueryEntity>> GetAllInforBookk()
        {
            var sql = @"
            SELECT
            *
            FROM Book
            WHERE IsDeleted=0
            ";
            var result = await context.Connection.QueryAsync<GetAllBookQueryEntity>(sql);
            return result.ToList();
        }

    }
}
