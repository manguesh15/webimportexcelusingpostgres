using AutoMapper;
using System;
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
        public List<Users> AddUsers(List<User> users)
        {
         //dell
            foreach (var item in users)
            {
                _userDbContext.MyProperty.Add(item);
                _userDbContext.SaveChanges();
            }

            List<Users> userModel = new List<Users>();
            foreach (var item in users)
            {
                userModel.Add(new Users()
                {

                    UserAddress = item.UserAddress,
                    UserName = item.UserName,
                });
            }


            var s1 = userModel;

            return userModel;
        }
    }
}
