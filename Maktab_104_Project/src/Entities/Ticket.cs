using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Ticket
    {
        [Display(Name = "شناسه")]

        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "توضیحات")]

        public string Description { get; set; }
        public int SubmitedBy { get; set; }
        public DateTime SubmitedAt { get; set; }
        public PriorityEnum Priority { get; set; }
        public string DepartmentName { get; set; }

    }

}
