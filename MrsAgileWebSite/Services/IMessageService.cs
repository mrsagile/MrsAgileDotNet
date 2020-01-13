using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MrsAgileWebSite.Models;

namespace MrsAgileWebSite.Services
{
   public interface IMessageService
    {
        public Message GetWelcomeMessage();
        public Message GetAboutMessage();
        public AboutMessages GetAboutSections();
    }
}
