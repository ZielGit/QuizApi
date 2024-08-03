using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.Models;

namespace QuizApi.Persistence.Context
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
