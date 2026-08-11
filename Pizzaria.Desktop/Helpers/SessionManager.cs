using Pizzaria.Desktop.DTOs;
using Pizzaria.Desktop.DTOs;

namespace Pizzaria.Desktop.Helpers
{
    public sealed class SessionManager
    {
        private static readonly Lazy<SessionManager> _instance =
            new(() => new SessionManager());

        public static SessionManager Instance => _instance.Value;

        private SessionManager() { }

        public UsuarioResponseDto? UsuarioAtual { get; private set; }

        public bool IsAuthencticated => UsuarioAtual != null;

        public bool IsAdmin => UsuarioAtual?.IsAdmin ?? false;

        public void SetUser(UsuarioResponseDto user)
        {
            UsuarioAtual = user;
        }
  
        public void Clear()
        {
            UsuarioAtual = null;
        }

        public string GetEmail() => UsuarioAtual?.Email ?? string.Empty;

        public string GetDisplayName()
        {
            var email = GetEmail();
            if (string.IsNullOrEmpty(email)) return "Usuário";
            var at = email.IndexOf("@");
            return at > 0 ? email[..at] : email; 
        }
    }
}
