using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.IRepositories;
using QuizApi.Domain.Models;
using QuizApi.Persistence.Context;

namespace QuizApi.Persistence.Repositories
{
    public class LoginRepository: ILoginRepository
    {
        private readonly AplicationDbContext _context;
        public LoginRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> ValidateUser(Usuario usuario)
        {
            var user = await _context.Usuarios.Where(x => x.NombreUsuario == usuario.NombreUsuario && x.Password == usuario.Password).FirstOrDefaultAsync();
            return user;
        }
    }
}
