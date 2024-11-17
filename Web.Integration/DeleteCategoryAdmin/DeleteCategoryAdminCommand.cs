using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.DeleteCategoryAdmin.Command
{
    public class DeleteCategoryAdminCommand : IRequest<DeleteCategoryAdminCommandResult>
    {
        public string? CategoryId { get; set; }
    }
}
