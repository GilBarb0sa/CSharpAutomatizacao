using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infraestrutura
{
    public class DbConnection : DbContext
    {
       public DbSet<Aluno> Alunos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=portal_do_aluno;User Id=postgres;Password=Saskaroth;");
    }
}
