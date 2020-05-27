using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TvAzteca.Api.Controllers.Views
{
    public class UserController : Controller
    {
        public ActionResult Index() => View();
        
        public ActionResult Details(int id) => View();
        
        public ActionResult Create() =>View();

        public ActionResult Edit(int id) => View();

        public ActionResult Delete(int id) => View();
    }
}