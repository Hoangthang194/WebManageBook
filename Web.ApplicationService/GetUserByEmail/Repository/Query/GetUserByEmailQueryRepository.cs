using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Query;
using Web.Domain;
using Web.Domain.GetUserByEmail.Entity.Query;
using Web.Domain.GetUserByEmail.Param.Query;
using Web.Domain.GetUserByEmail.Repository.Query;

namespace Web.ApplicationService.GetUserByEmail.Repository.Query
{
    public class GetUserByEmailQueryRepository: QueryRepository<GetUserByEmailQueryEntity>, IGetUserByEmailQueryRepository
    {
        private readonly IDapperContext context;
        public GetUserByEmailQueryRepository(IDapperContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<GetUserByEmailQueryEntity> GetUserByEmail(GetUserByEmailQueryParam param)
        {
            var sql = 
            @"
            SELECT * 
            FROM Users
            WHERE UserEmail = @UserEmail;
            ";
            var result = await context.Connection.QueryFirstOrDefaultAsync<GetUserByEmailQueryEntity>(sql, param);
            return result;
        }
    }
}
