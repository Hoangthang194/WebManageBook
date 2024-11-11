using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Core.Command;
using Web.Domain;
using Web.Domain.Temp.Entity.Command;
using Web.Domain.Temp.Repository.Command;

namespace Web.ApplicationService.Temp.Repository.Command
{
    public class TempCommandRepository: CommandRepository<TempCommandEntity>, ITempCommandRepository
    {
        private readonly IDapperContext context;
        public TempCommandRepository(IDapperContext context):base(context)
        {
            this.context = context;
        }
    }
}
