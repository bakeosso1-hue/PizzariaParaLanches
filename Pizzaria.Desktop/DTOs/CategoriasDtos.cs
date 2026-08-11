namespace Pizzaria.Desktop.DTOs
{
    public class CategoriaResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int GameCount { get; set; }
    }

    public class CreateCategoriaDto
    {
        public string Name { get; set; } = string.Empty;
    }

    public class UpdateCategoriaDto
    {
        public string Name { get; set; } = string.Empty;
    }
}
