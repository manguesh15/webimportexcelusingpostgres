using ExcelDataReader;
using Microsoft.AspNetCore.Mvc;
using webimportexcelusingpostgres.DbModels;
using webimportexcelusingpostgres.Models;
using webimportexcelusingpostgres.Service;

namespace webimportexcelusingpostgres.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View(new List<Users>());
        }



        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            List<User> users = new List<User>();
            var fileName = "./Users.xlsx";
            // For .net core, the next line requires the NuGet package, 
            // System.Text.Encoding.CodePages
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    while (reader.Read()) //Each row of the file
                    {
                        users.Add(new User
                        {
                             UserName = reader.GetValue(0).ToString(),
                            UserAddress = reader.GetValue(1).ToString(),
                           
                        });


                    }
                }
            }

            

             var s=  _userService.AddUsers(users);

            return View(s);
        }
    }
}
