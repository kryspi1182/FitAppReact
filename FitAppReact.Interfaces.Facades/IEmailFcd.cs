using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Facades
{
    public interface IEmailFcd
    {
        public void SendVerificationEmail(string email, string subject, string content);
    }
}
