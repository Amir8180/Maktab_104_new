using DevCard_Promote.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace DevCard_Promote.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
            new Article(1,"فردای هوش مصنوعی","ورود هوش مصنوعی به زندگی ما و در اختیار گرفتن و تسهیل روزمرگی ما انسان ها موجب شده تا دسترسی و اختیارات آن زیاد شود ...","blog-post-thumb-1.jpg"),
            new Article(2,"بهبودی بهتر از درمان","با پیشرفت تکنولوژی کیفیت زندگی انسا ها رو به افزایش است این امر موجب شده ...","blog-post-thumb-4.jpg"),
            new Article(3,"تحصیل ابری","متا وعده ای تحصیلات ابری را به مردم سرتاسر جهان داد، ایده ای جاهطلبانه برای ازبین بردن بورس تحصیلی؟","blog-post-thumb-5.jpg"),
            };
            return View("_Articles",article);
        }
    }
}
