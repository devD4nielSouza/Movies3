namespace Movies.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public virtual Category? Category { get; set; }

        public string Classification { get; set; } = string.Empty;
        public int Duration { get; set; }
    }
}
