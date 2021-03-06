using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project002.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project002.Controllers
{
    public class HomeController : Controller
    {
        private MenuContext conDb = new MenuContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// ログイン(初期)ページ
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// ログイン(初期)ページよりLogin押下後のアクションメソッド
        /// </summary>
        /// <returns>どんな値でもLoginを許可する</returns>
        public IActionResult Menu()
        {

            return View(conDb.Menus.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
