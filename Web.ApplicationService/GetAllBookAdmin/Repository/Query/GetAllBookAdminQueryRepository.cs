using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Query;
using Web.Domain;
using Web.Domain.GetAllBookAdmin.Entity.Query;
using Web.Domain.GetAllBookAdmin.Repository.Query;

namespace Web.ApplicationService.GetAllBookAdmin.Repository.Query
{
    public class GetAllBookAdminQueryRepository: QueryRepository<GetAllBookAdminQueryEntity>, IGetAllBookAdminQueryRepository
    {
        private readonly IDapperContext context;
        public GetAllBookAdminQueryRepository(IDapperContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<GetAllBookAdminQueryEntity>> GetAllInforBook()
        {
            var sql = @"
                SELECT *
                  FROM Book b
                  INNER JOIN Category c
                  ON b.CategoryId = c.CategoryId
            ";
            var result = await context.Connection.QueryAsync<GetAllBookAdminQueryEntity>(sql);
            return result.ToList();
        }
    }
}
