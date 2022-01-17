using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using testVersta.Models;

namespace testVersta.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAbstractOrders orders;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, IAbstractOrders orders)
        {
            this.orders = orders;
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            return View(await orders.GetOrdersAsync());
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrderAsync(Order model)
        {
            if (ModelState.IsValid)
            {
                await orders.SaveOrder(model);
                return RedirectToAction(nameof(Index));
            }
            else
                return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
