using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.GetUserById.Entity.Query
{
    public class GetUserByIdQueryEntity
    {
        public string? UserId { get; set; }
        public string? UserFullName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPassword { get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserDisplayName { get; set; }
        public string? UserImg { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public string? RoleId { get; set; }

    }
}
