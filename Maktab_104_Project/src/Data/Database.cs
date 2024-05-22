using Contracts;
using Entities;

namespace Data
{
    public  class Database : IDatabase
    {
        private static List<Ticket> _tickets = new List<Ticket>();
        public List<Ticket> GetTicket()
        {
            return _tickets;
        }
        public int AddTicket(Ticket ticket)
        {
            ticket.Id = 1;
            if (_tickets.Any())
            {
                ticket.Id = _tickets.Max(m => m.Id) + 1;
            }
            _tickets.Add(ticket);
            return ticket.Id;
        }
    }
}
