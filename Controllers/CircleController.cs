using CircleWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CircleWebApp.Controllers
{
    public class CircleController : Controller
    {
        // Hiển thị form nhập bán kính
        public IActionResult Index()
        {
            return View();
        }

        // Xử lý tính toán khi form được submit
        [HttpPost]
        public IActionResult Calculate(double radius)
        {
            if (radius <= 0)
            {
                ViewBag.Error = "Bán kính phải lớn hơn 0!";
                return View("Index");
            }

            var result = new CircleResult
            {
                ChuVi = 3.14 * 2 * radius,
                DienTich = 3.14 * radius * radius,
                DuongKinh = 2 * radius
            };

            return View("Result", result);
        }
    }
}
