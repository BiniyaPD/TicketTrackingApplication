using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TicketTracking.BusinessLayer.Contracts;
using TicketTracking.CommonLayer.Models;
using TicketTracking.WebApp.Models;

namespace TicketTracking.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITicketManager ticketManager;

        public HomeController(ILogger<HomeController> logger,ITicketManager ticketManager)
        {
            _logger = logger;
            this.ticketManager = ticketManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Login(Employee employee)
        //{
        //    return RedirectToAction("LogTicket");

        //    //return View();
        //}
        //public IActionResult LogTicket()
        //{
        //    return View();
        //}
        [HttpPost]
        public IActionResult LogTicket(Ticket ticket)
        {
            this.ticketManager.LogTicket(ticket);
            return View();
        }
        public IActionResult CloseTicket(Ticket ticket)
        {
            this.ticketManager.CloseTicket(ticket);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
