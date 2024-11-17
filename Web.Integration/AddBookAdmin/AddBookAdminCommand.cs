using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Integration.AddBookAdmin.Command
{
    public class AddBookAdminCommand : IRequest<AddBookAdminCommandResult>
    {
        public string? BookName { get; set; }
        public string? BookSubDes { get; set; }
        public string? BookBrand { get; set; }
        public string? BookDes { get; set; }
        public int BookStatus { get; set; }
        public decimal PriceOld { get; set; }
        public decimal PriceNew { get; set; }
        public int PercentVourcher { get; set; }
        public int BookNumber { get; set; }
        public string? CategoryId { get; set; }
    }
}
