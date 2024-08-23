using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderDetail_Task
    {
        public int Id { get; set; }

        public int Order_Id { get; set; }
        public int Task_Id { get; set; }

    }
}
