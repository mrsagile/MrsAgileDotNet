using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MrsAgileWebSite
{
    public class ProjectsModel : PageModel
    {
        private string greetings { get; set; }
        public string Greetings { get { return greetings; } }

        public ProjectsModel()
        {
            greetings = "Hello/Merhaba";

        }
        
    }
}