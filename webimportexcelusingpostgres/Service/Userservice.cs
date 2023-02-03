using webimportexcelusingpostgres.DbModels;
using webimportexcelusingpostgres.Models;

namespace webimportexcelusingpostgres.Service
{
    public class Userservice : IUserService
    {
        private readonly UserDbContext _userDbContext;

        public Userservice(UserDbContext userDbContext)
        {
           _userDbContext = userDbContext;
        }
        public List<User> AddUsers(List<User> users)
        {
         
            foreach (var item in users)
            {
                _userDbContext.MyProperty.Add(item);
                _userDbContext.SaveChanges();
            }

            return users;
        }
    }
}
