namespace Room_Services.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public int Order_Id { get; set; }
        public int User_Id { get; set; }
        public long Offer_Price { get; set; }
        public bool Offer_Status_Done { get; set; }
        public bool Offer_Status_Submited { get; set; }
        public bool Offer_Status_Accepted { get; set; }
        public string Description { get; set; }
    }
}
