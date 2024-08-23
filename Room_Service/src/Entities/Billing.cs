using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Billing
    {
        public int Id { get; set; }
        public int Order_Id { get; set; }
        public long Payment { get; set; }

    }
}
