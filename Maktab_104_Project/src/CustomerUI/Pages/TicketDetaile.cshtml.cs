using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerUI.Pages
{
    public class TicketDetaileModel : PageModel
    {
        public TicketDetaileModel()
        {

        }

        #region Model
        [BindProperty]
        public int Id { get; set; }
        #endregion

        public void OnGet(int id)
        {
            this.Id = id;
        }
    }
}
