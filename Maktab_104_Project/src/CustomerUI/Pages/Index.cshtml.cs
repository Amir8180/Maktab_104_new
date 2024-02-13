using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            tickets = new List<Ticket>()
            {
                new Ticket()
                {
                    Id = 1,
                    Title = "درخواست 1",
                    Description = "شرح درخواست اول"
                },
                new Ticket()
                {
                    Id = 2,
                    Title = "درخواست 2",
                    Description = "شرح درخواست دوم"
                }
            };

        }







        #region Model

        public List<Ticket> tickets { get; set; }

        #endregion

        public void OnGet()
        {

        }
        [HttpPost]
        public void OnPost()
        {

        }
    }
}
