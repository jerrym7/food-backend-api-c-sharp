using Food.API.Models;
using Food.API.Repositories;

namespace Food.API.Services
{

    public class PersonDatabase : IDatabase
    {
        public async Task<IEnumerable<Person>> GetPeople() => await Task.FromResult(PersonRepository.People);

        public async Task<Person?> GetPersonById(int id) 
        {
            var person = await Task.FromResult(PersonRepository.People.SingleOrDefault(person => person.Id == id));
            return person;
        }

    }
}