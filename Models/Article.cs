namespace DevCard.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string image { get; set; }

        public Article(long id, string title, string description, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            this.image = image;
        }
    }
}
