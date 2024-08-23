using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public DateTime Order_Date { get; set; }

        public Order(int user_Id)
        {
            User_Id = user_Id;
            Order_Date = DateTime.Now;
        }
    }
}
