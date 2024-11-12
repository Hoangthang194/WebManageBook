using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Register.Entity.Command;

namespace Web.Integration.Register.Command
{
    /// <summary>
    /// Dữ liệu đầu vào 
    /// </summary>
    public class RegisterCommand : IRequest<RegisterCommandResult>
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? UserEmail { get; set; }
    }
}
