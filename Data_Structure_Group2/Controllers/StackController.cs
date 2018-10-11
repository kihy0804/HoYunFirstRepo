using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Data_Structure_Group2.Controllers
{
    public class StackController : Controller
    {
        //static is always there for you to use, alive, once you start the website that myStack is alive
        //So make your variable static
        static Stack<string> myStack = new Stack<string>();

        // GET: Stack
        public ActionResult Index()
        {
            ViewBag.StackView = myStack;
            return View();
        }

        public ActionResult AddOne()
        {
            myStack.Push("New Entry " + (myStack.Count + 1));
            ViewBag.StackView = myStack;
            return View("Index");
        }
    }
}