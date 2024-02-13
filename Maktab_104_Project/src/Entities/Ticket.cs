namespace Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SubmitedBy { get; set; }
        public DateTime SubmitedAt { get; set; }
        public PriorityEnum Priority { get; set; }
        public string DepartmentName { get; set; }

    }

}
