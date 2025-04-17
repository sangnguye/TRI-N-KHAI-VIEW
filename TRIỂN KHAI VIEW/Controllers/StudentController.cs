using TRIỂN_KHAI_VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace TRIỂN_KHAI_VIEW.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ListAll()
        {
            // Goi model ket noi CSDL lay thong tin sinh vien
            List<Student> ListStudents = new List<Student>()
            {
                new Student { Id = 1, Name = "Đức Đạt", Age = 19, Gender = true, ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxBWVQ6dDIcviaXW6DyFPut5IxXQHEB3zGBEyGoQZinHlvIkss&s", Des = "Mô tả thông tin sinh viên" },
                new Student { Id = 2, Name = "Thùy Trâm", Age = 25, Gender = false, ImgUrl = "https://clipart-library.com/img/1421105.png", Des = "Mô tả thông tin sinh viên" },
                new Student { Id = 3, Name = "Nhã Phương", Age = 23, Gender = false, ImgUrl = "https://clipart-library.com/img/1421195.png", Des = "Mô tả thông tin sinh viên" },
                new Student { Id = 4, Name = "Thanh Viễn", Age = 20, Gender = true, ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxBWVQ6dDIcviaXW6DyFPut5IxXQHEB3zGBEyGoQZinHlvIkss&s", Des = "Mô tả thông tin sinh viên" },
                new Student { Id = 5, Name = "Hoàng Việt", Age = 19, Gender = true, ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxBWVQ6dDIcviaXW6DyFPut5IxXQHEB3zGBEyGoQZinHlvIkss&s", Des = "Mô tả thông tin sinh viên" }
            };
            return View(ListStudents);
        }

        public string ListOnlyStudent()
        {
            return "Liệt kê một sinh viên có id cụ thể";
        }

        public string EditStudent()
        {
            return "Chỉnh sửa thông tin một sinh viên có id cụ thể";
        }

        public string AddStudent()
        {
            return "Thêm thông tin một sinh viên";
        }
    }
}
