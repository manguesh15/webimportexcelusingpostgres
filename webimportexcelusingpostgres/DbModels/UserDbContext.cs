using Microsoft.EntityFrameworkCore;

namespace webimportexcelusingpostgres.DbModels
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) :base(options){ }


        public DbSet<User> MyProperty { get; set; }
    }
}
