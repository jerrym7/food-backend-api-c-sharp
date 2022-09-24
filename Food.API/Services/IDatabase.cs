using Food.API.Models;

namespace Food.API.Services
{
    public interface IDatabase
    {
        Task<IEnumerable<Person>> GetPeople();
        Task<Person?> GetPersonById(int id);
    }
}
