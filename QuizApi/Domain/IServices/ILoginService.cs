using QuizApi.Domain.Models;

namespace QuizApi.Domain.IServices
{
    public interface ILoginService
    {
        Task<Usuario> ValidateUser(Usuario usuario);
    }
}
