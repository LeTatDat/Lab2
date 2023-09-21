using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using TH1.Models;

namespace TH1.ViewComponents
{
    public class RenderViewComponent:ViewComponent
    {
        private List<MenuItems> MenuItems = new List<MenuItems>();
        public RenderViewComponent()
        {
            MenuItems = new List<MenuItems>()
            {
                new MenuItems() {Id=1, Name="Branches", Link="Branches/List"},
                new MenuItems() { Id = 2, Name = "Students", Link = "Students/List" },
                new MenuItems() { Id = 3, Name = "Subjects", Link = "Subjects/List" },
                new MenuItems() { Id = 4, Name = "Courses", Link = "Courses/List" },
            };
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", MenuItems);
        }
    }
}

