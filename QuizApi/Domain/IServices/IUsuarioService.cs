﻿using QuizApi.Domain.Models;

namespace QuizApi.Domain.IServices
{
    public interface IUsuarioService
    {
        Task SaveUser(Usuario usuario);
        Task<bool> ValidateExistence(Usuario usuario);
    }
}
