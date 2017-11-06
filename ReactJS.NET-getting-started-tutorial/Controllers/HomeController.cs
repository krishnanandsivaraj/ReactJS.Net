using ReactDemo.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<CommentModel> _comments;

        static HomeController()
        {
            _comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Author = "Nirmak Kumar",
                    Text = "Hello React"
                },
                new CommentModel
                {
                    Author = "Krishnanand Sivaraj",
                    Text = "Hi Guys!!"
                },
                new CommentModel
                {
                    Author = "Ramachandran Murugan",
                    Text = "I am also working!!"
                },
            };
        }

        [HttpPost]
        public ActionResult AddComment(CommentModel comment)
        {
            _comments.Add(comment);
            return Content("Success :)");
        }

        public ActionResult Comments()
        {
            return Json(_comments, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View(_comments);
        }

    }
}
