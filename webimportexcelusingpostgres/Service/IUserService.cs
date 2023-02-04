using webimportexcelusingpostgres.DbModels;
using webimportexcelusingpostgres.Models;

namespace webimportexcelusingpostgres.Service
{
    public interface IUserService
    {

        List<Users> AddUsers(List<User> users);
    }
}
