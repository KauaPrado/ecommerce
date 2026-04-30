namespace EcommerceAPI.Application.Services
{
    public interface IAuthService
    {
        Task<string?> LoginAsync(string email, string password);
        Task<bool> RegisterAsync(string name, string email, string password, string role);
    }
}