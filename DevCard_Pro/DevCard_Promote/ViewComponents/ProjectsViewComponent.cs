using DevCard_Promote.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Promote.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var project = new List<Project>
            {
                new Project(1,"Snapp!","سرویس تاکسی اینترنتی!! با کلیک سفر کن","Arisa","project-1.jpg"),
                new Project(2,"Jabaman","دنبال مکانی؟جابامن الان میاد","Divar","project-4.jpg"),
                new Project(3,"AhangiSho","قانونی گوش کن، از آرتیست مورد علاقت حمایت کن","Ahangify","project-5.jpg"),
                new Project(4,"Kargard","میخوای کارکنی؟پس اینترنتتو روشن کن","Freelancery","project-6.jpg"),
            };
            return View("_Projects",project);
        }
    }
}
