using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace basics.Controllers;

public class CourseController : Controller
{


    public IActionResult? Details(int? id)
    {

        if (id != null)
        {
            var kurs = Repository.GetById(id);

            return View(kurs);
        }
        return RedirectToAction("List");

    }




    public IActionResult List()
    {

        return View("CourseList", Repository.Courses);
    }
}
