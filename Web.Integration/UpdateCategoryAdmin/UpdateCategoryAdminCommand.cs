using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.UpdateCategoryAdmin.Command
{
    public class UpdateCategoryAdminCommand : IRequest<UpdateCategoryAdminCommandResult>
    {
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        

    }
}
