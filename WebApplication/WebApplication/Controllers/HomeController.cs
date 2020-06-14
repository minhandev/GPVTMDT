using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly DBContextx _cc;
        public HomeController(DBContextx cc)
        {
            _cc = cc;
        }

        public IActionResult Index()
        {
            return View(_cc.PhieuXuats.ToList());
        }
        [HttpPost]
        public JsonResult Index(PhieuXuat px)
        {
            if (px.ID_PhieuXuat == 0)
            {
                _cc.PhieuXuats.Add(px);
                _cc.SaveChanges();
            }
            return Json(data: new { success = true });
        }
        public JsonResult Index1(PhieuXuat px)
        {
            if (px.ID_PhieuXuat == 0)
            {
                _cc.PhieuXuats.Add(px);
                _cc.SaveChanges();
            }
            return Json(data: new { success = true });
        }
        public async Task<IActionResult> OnGetPartial()
        {
            var model = _cc.PhieuXuats.Select(x => new
            {
                ID_PhieuXuat = x.ID_PhieuXuat,
                ID_NhanVien = x.ID_NhanVien,
                ThoiGian = x.ThoiGian,
                Note = x.ThoiGian,
            });
            return PartialView();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
