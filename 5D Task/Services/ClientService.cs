
using Microsoft.EntityFrameworkCore;

namespace _5D_Task.Services
{
    public class ClientService : IClientService
    {

        private readonly ApplicationDbContext _dbContext;

        public ClientService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Client> Add(Client client)
        {
            await _dbContext.AddAsync(client);
            _dbContext.SaveChanges();

            return client;
        }

        public Client Delete(Client client)
        {
            _dbContext.Remove(client);
            _dbContext.SaveChanges();
            return client;
        }

        public async Task<IEnumerable<Client>> GetAll()
        { 
            return await _dbContext.Clients.ToListAsync();
        }

        public async Task<Client> GetById(int id)
        {
            return await _dbContext.Clients.FindAsync(id);
        }

        public Client Update(Client client)
        {
            _dbContext.Update(client);

            _dbContext.SaveChanges();
            return client;
        }
    }
}
