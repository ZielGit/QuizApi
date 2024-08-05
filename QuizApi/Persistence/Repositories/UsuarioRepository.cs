using QuizApi.Domain.IRepositories;
using QuizApi.Domain.Models;
using QuizApi.Persistence.Context;

namespace QuizApi.Persistence.Repositories
{
    public class UsuarioRepository: IUsuarioRepository
    {
        private readonly AplicationDbContext _context;
        public UsuarioRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveUser(Usuario usuario)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
        }
    }
}
