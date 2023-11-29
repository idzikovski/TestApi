using Microsoft.EntityFrameworkCore;

namespace TestApi.Models
{
    [PrimaryKey(nameof(Id))]
    public class User(string firstName, string lastName)
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
    }
}
