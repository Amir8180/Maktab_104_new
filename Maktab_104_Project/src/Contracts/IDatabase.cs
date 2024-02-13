using Entities;

namespace Contracts
{
    public interface IDatabase
    {
        List<Ticket> GetTickets();
        int AddTicket(Ticket ticket);
    }
}
