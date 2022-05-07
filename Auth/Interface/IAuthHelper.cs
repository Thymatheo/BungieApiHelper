using System.Threading.Tasks;

namespace BungieApiHelper.Auth.Interface {
    public interface IAuthHelper {
        Task<AuthResponse> GetToken(string code);
        string InitAuth(string state);
        string RandomString();
        Task<AuthResponse> RefreshToken(string refreshToken);
    }
}