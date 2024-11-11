using Web.Domain;

namespace Web.Infrastructure
{
    public class DbContextProvider : IConnectionStringProvider
    {
        private readonly IConfiguration configuration;
        private readonly string? connectionString;
        public DbContextProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.connectionString = this.configuration.GetConnectionString("Connection");
        }

        public string? GetConnectionString()
        {
            return this.connectionString;
        }
    }
}
