namespace Movies.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public virtual Category? Category { get; set; }
    }
}
