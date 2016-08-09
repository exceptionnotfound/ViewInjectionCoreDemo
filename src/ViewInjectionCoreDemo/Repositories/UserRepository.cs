using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewInjectionCoreDemo.Repositories
{
public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}
public interface IUserRepository
{
    List<User> GetAll();
}

public class UserRepository : IUserRepository
{
    public List<User> GetAll()
    {
        return new List<User>()
        {
            new User()
            {
                FirstName = "Jyn",
                LastName = "Erso",
                DateOfBirth = new DateTime(1983, 10, 17)
            },
            new User()
            {
                FirstName = "Cassion",
                LastName = "Andor",
                DateOfBirth = new DateTime(1979, 12, 29)
            },
            new User()
            {
                FirstName = "Bodhi",
                LastName = "Rook",
                DateOfBirth = new DateTime(1982, 12, 1)
            }
        };
    }
}
}
