using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Domain.Contact;

namespace Web.Domain.Login.Entity
{
	public class LoginEntity : BaseEntity
	{
		public string? UserId {  get; set; }	
		public string? UserFullName { set; get; }	
		public string? UserEmail { set; get; }	
		public string? UserFirstName { set; get; }	
		public string? UserLastName { set; get; } 
		public string? UserImg { set; get; }		
		public string? UserPassword { set; get; }	
		public string? RoleId { set; get; }		
	}
}
