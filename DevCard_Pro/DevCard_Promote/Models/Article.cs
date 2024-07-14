namespace DevCard_Promote.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrtption { get; set; }
        public string Image { get; set; }

        public Article(int id, string title, string descrtption, string image)
        {
            Id = id;
            Title = title;
            Descrtption = descrtption;
            Image = image;
        }
    }
}
