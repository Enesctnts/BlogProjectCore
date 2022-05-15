using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            return View();
        }

        //Yorum ekleme
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        //Bloglardaki yorum listesi
        public PartialViewResult CommentListByBlog(int id)
        {
            var values = commentManager.GetAll(id);
            return PartialView(values);
        }
    }
}
