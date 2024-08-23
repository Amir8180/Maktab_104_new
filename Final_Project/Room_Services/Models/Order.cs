namespace Room_Services.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public DateTime Order_Date { get; set; }

        public Order(int user_Id)
        {
            User_Id = user_Id;
            Order_Date = DateTime.Now;
        }
    }
}
