using webimportexcelusingpostgres.DbModels;
using webimportexcelusingpostgres.Models;

namespace webimportexcelusingpostgres.Service
{
    public interface IUserService
    {

        List<User> AddUsers(List<User> users);
    }
}
