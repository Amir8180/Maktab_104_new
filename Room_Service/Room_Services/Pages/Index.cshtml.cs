using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Room_Services._2_Infrastructure;

namespace Room_Services.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DB_Context _context;
        public IndexModel(DB_Context context)
        {
            _context = context;
        }

        #region Model

        #endregion
        public void OnGet()
        {
            var order = new Order(86);
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        [HttpPost]
        public void OnPost()
        {

        }
    }
}
