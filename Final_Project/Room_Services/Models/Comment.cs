namespace Room_Services.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int Order_Id { get; set; }
        public int Score { get; set; }
        public string Discription { get; set; }
    }
}
