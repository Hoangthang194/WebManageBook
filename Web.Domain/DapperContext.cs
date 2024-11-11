using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Web.Domain
{
    public class DapperContext : IDapperContext
    {
        private readonly IConnectionStringProvider connectionStringProvider;
        private IDbConnection? connection;

        public DapperContext(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        // Lazy load connection chỉ khi nào được gọi
        public IDbConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connectionStringProvider.GetConnectionString());
                    connection.Open();
                }
                return connection;
            }
        }

        public TransactionScope BeginTransaction() => new TransactionScope(TransactionScopeOption.Required);

        // Đảm bảo việc dispose connection đúng cách
        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose();
                connection = null;
            }
        }
    }
    public interface IDapperContext
    {
        IDbConnection Connection { get; }
        TransactionScope BeginTransaction();

    }
}
