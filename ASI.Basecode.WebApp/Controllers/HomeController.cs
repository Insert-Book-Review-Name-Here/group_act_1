using ASI.Basecode.WebApp.Models;
using ASI.Basecode.WebApp.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ASI.Basecode.WebApp.Controllers
{
    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : ControllerBase<HomeController>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpContextAccessor"></param>
        /// <param name="loggerFactory"></param>
        /// <param name="configuration"></param>
        /// <param name="localizer"></param>
        /// <param name="mapper"></param>
        /// 

        private List<PersonModel> list = new List<PersonModel>();

        public HomeController(IHttpContextAccessor httpContextAccessor,
                              ILoggerFactory loggerFactory,
                              IConfiguration configuration,
                              IMapper mapper = null) : base(httpContextAccessor, loggerFactory, configuration, mapper)
        {
            list.Add(new PersonModel { Id = 101, Email = "gabrielalpha98@gmail.com", Address = "7th St, Apas, Cebu city, Cebu", WonItem = "Jack in the Box" });
            list.Add(new PersonModel { Id = 102, Email = "andrewlouie@gmail.com", Address = "1st St, Lahug, Cebu city, Cebu", WonItem = "Ford Mustang" });
            list.Add(new PersonModel { Id = 103, Email = "abelbackschadt@gmail.com", Address = "Banilad, Cebu city, Cebu", WonItem = "Second Hand Shoes" });
            list.Add(new PersonModel { Id = 104, Email = "kylearanas@gmail.com", Address = "Mandaue City, Cebu", WonItem = "Php5 Food Panda Voucher" });
            list.Add(new PersonModel { Id = 105, Email = "elijahesguerra@gmail.com", Address = "Mandaue City, Cebu", WonItem = "1 Yum Burger Jollibee" });

        }

        /// <summary>
        /// Returns Home View.
        /// </summary>
        /// <returns> Home View </returns>
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test2()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Aranas()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Aguilar()
        {
            return View(list);
        }

        [AllowAnonymous]
        public IActionResult Backschadt()
        {
            return View(list);
        }

        [AllowAnonymous]
        public IActionResult Abella()
        {
            return View();
        }
    }
}
