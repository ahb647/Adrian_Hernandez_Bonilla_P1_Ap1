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
            optionsBuilder.UseSqlServer("workstation id=Examen_Aplicada_1.mssql.somee.com;packet size=4096;user id=Ahb32_SQLLogin_1;pwd=np7poppci4;data source=Examen_Aplicada_1.mssql.somee.com;persist security info=False;initial catalog=Examen_Aplicada_1;TrustServerCertificate=True");

            return new Contexto(optionsBuilder.Options);
        }
    }
}