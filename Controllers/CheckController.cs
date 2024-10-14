using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CheckList.Data;
using CheckList.Models;

namespace CheckList.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Index() {
            var item = new Item{Id=1,Name="school",Text="Came back from school."}
            var item = new Item{Id=2,Name="homework",Text="Finished homeworks."}
            var item = new Item{Id=3,Name="asp",Text="Watched Asp.NetCore Tutorials."}
            var item = new Item{Id=4,Name="study",Text="Lessons studied."}

            return View(item);
        }
    }
}