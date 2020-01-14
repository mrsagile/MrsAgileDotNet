using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrsAgileWebSite.Models
{
    public class Message
    {
       public int Id { get; set; }
       public string MessageTitle { get; set; }
       public string MessageSummary { get; set; }
       public string MessageFooter { get; set; }
       public List<Message> MessageDetails { get; set; }
    }
}
