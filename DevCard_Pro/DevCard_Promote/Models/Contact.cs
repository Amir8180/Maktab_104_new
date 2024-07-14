
using System.ComponentModel.DataAnnotations;

namespace DevCard_Promote.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MinLength(3, ErrorMessage ="حداقل طول مجاز 3 کاراکتر است")]
        [MaxLength(100, ErrorMessage ="حداکثر طول کاراکتر 100 است")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage ="لطفا فرمت ایمیل را رعایت کنید")]
        public string Email { get; set; }

        [MaxLength(450, ErrorMessage = "حداکثر طول کاراکتر 450 است")]
        public string Message { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Services { get; set; }
    }
}
