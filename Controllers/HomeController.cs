using Microsoft.AspNetCore.Mvc;
using TranNhua.Models;

public class HomeController : Controller
{
    private readonly ApplicationDbContext db;

    public HomeController(ApplicationDbContext context)
    {
        db = context;
    }

    public ActionResult Index()
    {
        var tranNhua = db.TranNhua.Take(4).ToList();
        var opTuong = db.OpTuong.Take(4).ToList();
        var vachNgan = db.VachNgan.Take(4).ToList();
        var tranTha = db.TranTha.Take(4).ToList();

        var model = new HomeViewModel
        {
            TranNhuaList = tranNhua,
            OpTuongList = opTuong,
            VachNganList = vachNgan,
            TranThaList = tranTha
        };

        return View(model);
    }
    public ActionResult Contact()
    {
        return View(); // Trả về contact.cshtml trong thư mục Views/Home
    }
    public ActionResult partition()
    {
        return View(); // Trả về contact.cshtml trong thư mục Views/Home
    }
    public ActionResult Floor()
    {
        return View(); // Trả về contact.cshtml trong thư mục Views/Home
    }
}
