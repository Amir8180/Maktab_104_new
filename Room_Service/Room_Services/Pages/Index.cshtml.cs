using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RoomService_Context;

namespace Room_Services.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DB_Context _context;
        public IndexModel(DB_Context context)
        {
            _context = context;
        }

        public void OnGet()
        {
            var order = new Order (45);
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
