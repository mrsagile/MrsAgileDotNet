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

        private List<Message> GetSummaryOfExperienceDetails(int id )
        {
            var locId = id * 100;
            return ( new List<Message>() {  new Message(){Id = ++locId  , MessageTitle="*" , MessageSummary="Developed Internet Banking application used by millions of customers – (https://www.ingbank.com.tr/en)."},
                                        new Message(){Id = ++locId, MessageTitle="*" , MessageSummary="Working with the latest .NET Technologies and software development technologies. (.NET Core, SignalR, Razor pages, React, Bootstrap, JavaScript, CI, TDD, DDD, JQuery, HTML, MVC, WebApi, EF, WF, WCF)."},
                                        new Message(){Id = ++locId, MessageTitle="*" , MessageSummary="Managing releases of distributed, high traffic applications used by 900 users uploading 1000s documents per second. (Task Parallel Library, WF Asynchronous Activities, and SQL Server)."},
                                        new Message(){Id = ++locId, MessageTitle="*" , MessageSummary="Implemented CI and CD systems with Jenkins, for Docker containers in Kubernetes clusters."},
                                        new Message(){Id = ++locId, MessageTitle="*" , MessageSummary="Experience in performance testing and performance tuning web applications."},
                                        new Message(){Id = ++locId, MessageTitle="*" , MessageSummary="Developed authentication and authorization modules for web applications. " },
                                        new Message(){Id = ++locId, MessageTitle="*" , MessageSummary="Strong skills on software development full life cycle, design patterns and object - oriented development principles." },
                                        new Message(){Id = ++locId, MessageTitle="*" , MessageSummary="Selected to represent the companies for several international conferences and meetings; TechEd Barcelona(October 2014), ING Group Amsterdam(June, 2008)" },
                                        new Message(){Id = ++locId, MessageTitle="*" , MessageSummary="Highly experienced relational database designer and developer(Oracle, SQLServer, Postgres)" }
            });
         }

        private List<Message> GetTechnicalSkillsDetails(int id)
        {
            var locId = id * 100; 
           return( new List<Message>() {  new Message(){Id = ++locId, 
                                                        MessageTitle ="Languages" , 
                                                        MessageSummary="C, C#, ASP.NET, ASP.NET Core, SignalR, React, Angular, TypeScript, JavaScript, jQuery, HTML, CSS, Node"},
                                        new Message(){Id = ++locId, 
                                                        MessageTitle="Data Technology" , 
                                                        MessageSummary="Redis, Postgres, SQL Server, ORACLE 9i, 10g, PLSQL, INFORMIX, T-SQL, SSIS, SSRS"},
                                        new Message(){Id = ++locId,
                                                        MessageTitle="Operating Systems" ,
                                                        MessageSummary="Windows, Unix, Linux"},
                                        new Message(){Id = ++locId,
                                                        MessageTitle="Methodologies" ,
                                                        MessageSummary="Agile , Scrum, Waterfall , PRINCE2"},
                                        new Message(){Id = ++locId,
                                                        MessageTitle="Configuration Management" ,
                                                        MessageSummary="Jenkins, BitBucket Pipelines, Git, TFS, SourceSafe, ClearCase, TeamCity, Docker"},
            });      
        }

        private List<Message> GetEducationDetails(int id)
        {
            return (new List<Message>());
        }

        private List<Message> GetEmploymentHistoryDetails(int id)
        {
            return (new List<Message>());
        }

        public MessageService()
        {
            _cv = new List<Message>() { new Message(){Id = 1, MessageTitle="Summary of Experience" , MessageSummary="High performance secure web sites ...",
                                                              MessageDetails= GetSummaryOfExperienceDetails(1)},
                                        new Message(){Id = 2, MessageTitle="Technical Skills" , MessageSummary="DotNet, JS, SQLServer, Cloud, Containers, CD Pipelines ...",
                                        MessageDetails= GetTechnicalSkillsDetails(2)},
                                        new Message(){Id = 3, MessageTitle="Education" , MessageSummary="Bachelor of Science ...",
                                        MessageDetails= GetEducationDetails(3)},
                                        new Message(){Id = 4, MessageTitle="Employment History" , MessageSummary="Software Architecture Consultant...",
                                        MessageDetails= GetEmploymentHistoryDetails(4)}
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
