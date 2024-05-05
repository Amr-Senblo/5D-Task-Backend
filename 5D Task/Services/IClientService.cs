namespace _5D_Task.Services
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAll();
        Task<Client> GetById(int id);
        Task<Client>Add (Client client); 
        Client Update (Client client); 
        Client Delete (Client client); 
    }
}
