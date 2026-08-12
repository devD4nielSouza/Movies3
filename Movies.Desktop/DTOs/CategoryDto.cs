namespace Movies.Desktop.DTOs
{
    public class CategoriaResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int GameCount { get; set; }
    }

    public class CreteCategoryDto
    {
        public string Name { get; set; } = string.Empty;
    }

    public class UpdateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
    }

}
