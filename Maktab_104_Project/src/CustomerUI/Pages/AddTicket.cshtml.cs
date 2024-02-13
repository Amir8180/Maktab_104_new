using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerUI.Pages
{
    public class AddTicketModel : PageModel
    {

        public AddTicketModel()
        {
            
        }

        #region Model
        [BindProperty]
        public Ticket ticket { get; set; }
        #endregion


        public void OnGet()
        {

        }

        [HttpPost]
        public void OnPost()
        {
            Database.tickets.Add(ticket);

        }

    }
}
