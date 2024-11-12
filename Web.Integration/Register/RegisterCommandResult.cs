using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.Register.Command
{
    public class RegisterCommandResult
    {
        public bool Status { get; set; } = false;
		public string? UserId { get; set; }
	}
}
