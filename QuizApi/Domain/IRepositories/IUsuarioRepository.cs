using QuizApi.Domain.Models;

namespace QuizApi.Domain.IRepositories
{
    public interface IUsuarioRepository
    {
        Task SaveUser(Usuario usuario);
    }
}
