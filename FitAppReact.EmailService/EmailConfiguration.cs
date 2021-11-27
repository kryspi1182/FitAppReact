using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitAppReact.Common.Configurations;

namespace FitAppReact.EmailService
{
    public class EmailConfiguration : IEmailConfiguration
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SmtpName { get; set; }
        //public string TemplatePath { get; set; }
        public string Subject { get; set; }
        //public string ChangeStatusSubject { get; set; }
        //public string ChangeStatusTitle { get; set; }
    }
}
