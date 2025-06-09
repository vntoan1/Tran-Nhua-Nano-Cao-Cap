using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{

    public ActionResult Index()
    {
        return View();
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
