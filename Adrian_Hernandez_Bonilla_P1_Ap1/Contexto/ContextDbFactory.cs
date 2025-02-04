using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Adrian_Hernandez_Bonilla_P1_Ap1.Context
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {
            // Configura el DbContext usando la cadena de conexión de Somee.
            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();
            optionsBuilder.UseSqlServer("workstation id=AdrianDB.mssql.somee.com;packet size=4096;user id=AHB_SQLLogin_1;pwd=419y65tsvd;data source=AdrianDB.mssql.somee.com;persist security info=False;initial catalog=AdrianDB;TrustServerCertificate=True");

            return new Contexto(optionsBuilder.Options);
        }
    }
}