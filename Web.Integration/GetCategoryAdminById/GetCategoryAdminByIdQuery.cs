using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.GetCategoryAdminById.Query
{
    public class GetCategoryAdminByIdQuery: IRequest<GetCategoryAdminByIdQueryResult>
    {
        public string? CategoryId { get; set; }
    }
}
