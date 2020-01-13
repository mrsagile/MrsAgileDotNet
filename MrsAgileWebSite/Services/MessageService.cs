using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MrsAgileWebSite.Models;

namespace MrsAgileWebSite.Services
{
    public class MessageService : IMessageService
    {
        private readonly string[] messages =
        { "Create It","Design It","Build It"};

        public static int i;

        public List<Message> CV { get { return _cv; } }

        private List<Message> _cv { get; set; }

        private List<Message> GetSection1Details()
        {
            var section1 = new List<Message>() {  new Message(){Id = 101, MessageTitle="*" , MessageSummary="Developed Internet Banking application used by millions of customers – (https://www.ingbank.com.tr/en)."},
                                        new Message(){Id = 102, MessageTitle="*" , MessageSummary="Working with the latest .NET Technologies and software development technologies. (.NET Core, SignalR, Razor pages, React, Bootstrap, JavaScript, CI, TDD, DDD, JQuery, HTML, MVC, WebApi, EF, WF, WCF)."},
                                        new Message(){Id = 103, MessageTitle="*" , MessageSummary="Managing releases of distributed, high traffic applications used by 900 users uploading 1000s documents per second. (Task Parallel Library, WF Asynchronous Activities, and SQL Server)."},
                                        new Message(){Id = 104, MessageTitle="*" , MessageSummary="Implemented CI and CD systems with Jenkins, for Docker containers in Kubernetes clusters."},
                                        new Message(){Id = 105, MessageTitle="*" , MessageSummary="Experience in performance testing and performance tuning web applications."},
                                        new Message(){Id = 106, MessageTitle="*" , MessageSummary="Developed authentication and authorization modules for web applications. " },
                                        new Message(){Id = 107, MessageTitle="*" , MessageSummary="Strong skills on software development full life cycle, design patterns and object - oriented development principles." },
                                        new Message(){Id = 108, MessageTitle="*" , MessageSummary="Selected to represent the companies for several international conferences and meetings; TechEd Barcelona(October 2014), ING Group Amsterdam(June, 2008)" },
                                        new Message(){Id = 109, MessageTitle="*" , MessageSummary="Highly experienced relational database designer and developer(Oracle, SQLServer, Postgres)" }
            };
            return section1;
        }
        public MessageService()
        {
            _cv = new List<Message>() { new Message(){Id = 1, MessageTitle="Summary of Experience" , MessageSummary="High performance secure web sites ...",
                                                              MessageDetails= GetSection1Details()},
                                        new Message(){Id = 2, MessageTitle="Technical Skills" , MessageSummary="DotNet, JS, SQLServer, Cloud, Containers, CD Pipelines ...",
                                        MessageDetails= GetSection1Details()},
                                        new Message(){Id = 3, MessageTitle="Education" , MessageSummary="Bachelor of Science ...",
                                        MessageDetails= GetSection1Details()},
                                        new Message(){Id = 4, MessageTitle="Employment History" , MessageSummary="Software Architecture Consultant...",
                                        MessageDetails= GetSection1Details()}
                                        };
    
        }
        public Message GetWelcomeMessage()
        {
            return new Message() { 
                MessageSummary = "I am Mrs Agile, Software Developer" ,
                MessageTitle = "Hello"};
            }

        public Message GetAboutMessage()
        {
            return new Message()
            {
                MessageTitle = "Senior Software Engineer",
                MessageSummary = "I am a highly experienced web developer and technical lead, building long term and efficient solutions for financial companies within a given timeframe.  I evangelise best practice and most appropriate technologies so that companies can have competitive solutions. As an experienced developer I mentor others to aid their professional growth and reinforce best practices. I have a particular interest in continues deployment, VCS, web security, real time web applications and performance optimization."
            };
        }

        public AboutMessages GetAboutSections()
        {
            return (
                new AboutMessages()
                {
                    Messages = from mes in _cv
                               select new Message
                               {
                                   Id = mes.Id,
                                   MessageSummary = mes.MessageSummary,
                                   MessageTitle = mes.MessageTitle,
                                   MessageDetails = mes.MessageDetails
                               }

                }); 
        }

 
        
    }
}
