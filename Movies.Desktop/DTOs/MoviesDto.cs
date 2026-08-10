namespace Movies.Desktop.DTOs
{
    public class MovieResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }

    public class CreateMovieDto
    {
        public string Title { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseDate { get; set; }
        public int CategoryId { get; set; }
    }


    public class UpdateMovieDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseDate { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
    }
}
