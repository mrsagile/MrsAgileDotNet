using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MrsAgileWebSite.Services;

namespace MrsAgileWebSite.Controllers
{
    public class AboutController : Controller
    {
        private readonly IMessageService _messageService;

        public AboutController(IMessageService messageService)
        {
            _messageService = messageService;

        }
        // GET: /<controller>/
        public IActionResult Summary()
        {
            return View(_messageService.GetAboutMessage());
        }

        public IActionResult AboutSections()
        {
            return View(_messageService.GetAboutSections());
        }

        
    }
}