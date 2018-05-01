using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUni2018.Controllers
{
    public class ErrorController : Controller
    {
        //mask the route and you only do this once
        [Route("/Error/{ErrorCode}")]

        //meaning the default constructor need a Index and not a Error for the Error(int ErrorCode)
        public IActionResult Error(int ErrorCode)
        {   //right clicking on the error and selecting the add view and just hit enter - 
            //this will create automaticaly a error.cshtml in the views folder
            return View(ErrorCode);//returning the error with the code
        }
    }
}