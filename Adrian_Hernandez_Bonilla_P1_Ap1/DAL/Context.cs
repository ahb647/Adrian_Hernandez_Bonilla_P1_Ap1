using Adrian_Hernandez_Bonilla_P1_Ap1.Models;
using Microsoft.EntityFrameworkCore; 
namespace Adrian_Hernandez_Bonilla_P1_Ap1.Context
{

public class Contexto : DbContext    
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Aportes> aportes { get; set; }
    
    }


}