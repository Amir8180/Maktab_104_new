using Contracts;
using Entities;

namespace Data
{
    public  class Database : IDatabase
    {
        private static List<Ticket> _tickets = new List<Ticket>();
        
        public int AddTicket(Ticket ticket)
        {
            ticket.Id = _tickets.Max(m => m.Id) + 1;
            _tickets.Add(ticket);
            return ticket.Id;
        }

        public List<Ticket> GetTickets()
        {
            return _tickets;
        }
    }
}
