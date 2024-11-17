using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.GetAllStatusBook.Entity.Query
{
    [Table("StatusBook")]
    public class GetAllStatusBookQueryEntity
    {
        [Key]
        public string? StatusId {  get; set; }
        public string? StatusName { get; set; }
    }
}
