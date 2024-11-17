using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Query;
using Web.Domain;
using Web.Domain.GetAllStatusBook.Entity.Query;
using Web.Domain.GetAllStatusBook.Repository.Query;

namespace Web.ApplicationService.GetAllStatusBook.Repository.Query
{
    public class GetAllStatusBookQueryRepository: QueryRepository<GetAllStatusBookQueryEntity>, IGetAllStatusBookQueryRepository
    {
        private readonly IDapperContext context;
        public GetAllStatusBookQueryRepository(IDapperContext context) : base(context)
        {
            this.context = context;
        }
    }
}
