using Microsoft.AspNetCore.Mvc;

namespace UdemyJwtApp.UI.ViewComponents
{
    public class NavbarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
