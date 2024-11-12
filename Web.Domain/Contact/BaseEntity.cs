using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.Contact
{
    public class BaseEntity
    {
        public bool IsDeleted { get; set; } = false;
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public string? CreateBy { get; set; }
    }
}
