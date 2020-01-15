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
            var locId = id * 100;
            return (new List<Message>() {  new Message(){Id = ++locId,
                                                        MessageTitle ="Trainings" ,
                                                        MessageSummary=@"(Udemy, PluralSight, Scrimba Memberships) React, .NET Core 3, SignalR Responsive Design, Serverless Web,
WebApi, Angular, Docker, Microservices Architecture, PostgreSQL, Redis , Bootstrap, Azure, Jenkins ,Git
Microsoft Certificated Professional -C# .NET 3.5 Foundation (2010)"},
                                        new Message(){Id = ++locId,
                                                        MessageTitle="Master of Science" ,
                                                        MessageSummary=@"Engineering and Technology Management(2006 - 2008) Bogazici University, Turkey: Graduation project 1:
“ERP Implementation in a Bank” -Graduation project 2: “Post Merger Integration"},
                                        new Message(){Id = ++locId,
                                                        MessageTitle="Bachelor of Science" ,
                                                        MessageSummary=@"Engineering and Technology Management(2006 - 2008) Bogazici University, Turkey: Graduation project 1:
“ERP Implementation in a Bank” -Graduation project 2: “Post Merger Integration"},
            });

        }

        /*Building a Continues Integration Server in Jenkins to support continues build and deployment processes for containerized applications runs in Kubernetes clusters. 

Build a private docker registry with SSL support. 

Build SSL for Gitlab registries. 

Presented and introduced and implemented the Database change management tool Flyware for the Postgress database and added to the deployment process. 

Supporting Java Script, JQuery, HTML code structure, Webservers and databases in the Microsoft Azure and Google Claud.  

Designing the Git Workflow to support the expending team at different geographical locations 

 */

        private List<Message> GetConsultantJobDetails(int id)
        {
            var locIdDetail = id * 1000;
            return (new List<Message>() { new Message() { Id = ++locIdDetail, MessageTitle = "*",
            MessageSummary="Building a Continues Integration Server in Jenkins to support continues build and deployment processes for containerized applications runs in Kubernetes clusters. "
                                                        } ,
            new Message() { Id = ++locIdDetail, MessageTitle = "*",
            MessageSummary="Build a private docker registry with SSL support. "
                                                        },
           new Message() { Id = ++locIdDetail, MessageTitle = "*",
            MessageSummary="Build SSL for Gitlab registries. "
                                                        },
                      new Message() { Id = ++locIdDetail, MessageTitle = "*",
            MessageSummary="Presented and introduced and implemented the Database change management tool Flyware for the Postgress database and added to the deployment process.  "
                                                        },
                      new Message() { Id = ++locIdDetail, MessageTitle = "*",
            MessageSummary="Supporting Java Script, JQuery, HTML code structure, Webservers and databases in the Microsoft Azure and Google Claud. "
                            },

                      new Message() { Id = ++locIdDetail, MessageTitle = "*",
            MessageSummary="Designing the Git Workflow to support the expending team at different geographical locations ."
                            },

            });
        }
        private List<Message> GetEmploymentHistoryDetails(int id)
        {
            var locId = id * 100;

            return (new List<Message>() {  new Message(){Id = ++locId,
                                                        MessageTitle =@"EyesClear - Contractor (11.2017 - 02.2019) Irvine, CA / US (Part-time Remote work for London, UK) 

                Software Architecture Consultant

 " ,

                                                        MessageSummary="",
                                                        MessageDetails= GetConsultantJobDetails(id)
            } });
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
