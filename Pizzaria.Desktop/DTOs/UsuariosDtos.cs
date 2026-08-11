namespace SenacGames.Desktop.DTOs
{
    public class UsuarioResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;

        public List<string> Roles { get; set; } = new();

        public string PerfilPrincipal =>
            Roles.Contains("Admin") ? "Administrador" :
            Roles.Count > 0 ? string.Join(", ", Roles) : "Usuário Comum";
    }

    public class CreateUsuarioDto
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string ConfirmarSenha { get; set; } = string.Empty;
        public string Role { get; set; } = "User";
    }

    public class ResetPasswordDto
    {
        public string UserId { get; set; } = string.Empty;
        public string NovaSenha { get; set; } = string.Empty;
        public string ConfirmarSenha { get; set; } = string.Empty;
    }

    public class AssignRoleDto
    {
        public string UserId { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }

}
