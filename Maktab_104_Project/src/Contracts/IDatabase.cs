using Entities;

namespace Contracts
{
    public interface IDatabase
    {
        List<Ticket> GetTicket();
        int AddTicket(Ticket ticket);
    }
}
