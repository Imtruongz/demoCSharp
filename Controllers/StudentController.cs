using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class StudentController : Controller
    {
        static List<Models.Student> lst = new List<Models.Student>();
        public IActionResult Index()
        {
            lst.Add(new Models.Student
            {
                Id = "123",
                Password = "123456",
                FullName = "Nguyễn Văn A",
                Gender = true,
                BirthDay = new DateTime(2003, 10, 10),
                Note = "Test hệ thống!"
            });
            lst.Add(new Models.Student
            {
                Id = "234",
                Password = "789456",
                FullName = "Đỗ Thị B",
                Gender = false,
                BirthDay = new DateTime(2003, 9, 9),
                Note = "Test hệ thống 123!"
            });
            return View(lst);
        }

        public IActionResult Create()
        {            
            return View();
        }

        public IActionResult Edit(string Id)
        {
            Models.Student obj = lst.FirstOrDefault(x => x.Id == Id); // Linq Query
            return View(obj);
        }
    }
}
