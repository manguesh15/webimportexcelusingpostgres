using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webimportexcelusingpostgres.DbModels
{
    [Table("user")]
    public class User
    {
        [Key,Required]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserAddress { get; set; }
    }
}
