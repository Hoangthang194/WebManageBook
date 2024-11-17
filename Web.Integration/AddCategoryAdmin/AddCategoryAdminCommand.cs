using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.AddCategoryAdmin.Command
{
    public class AddCategoryAdminCommand : IRequest<AddCategoryAdminCommandResult>
    {
        public string? CategoryName { get; set; }

    }
}
