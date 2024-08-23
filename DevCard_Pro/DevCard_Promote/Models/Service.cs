namespace DevCard_Promote.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string name { get; set; }

        public Service(int id, string name)
        {
            Id = id;
            this.name = name;
        }
    }
}
