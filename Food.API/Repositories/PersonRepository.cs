using Food.API.Models;

namespace Food.API.Repositories
{
    public class PersonRepository
    {
        public static readonly List<Person> People = new ()
        {
            new Person() {Id = 1, FirstName = "Gerardo", LastName = "Martinez"}, 
            new Person(){Id = 2, FirstName = "Gerald", LastName = "Otanga"}
        };
    }
}
