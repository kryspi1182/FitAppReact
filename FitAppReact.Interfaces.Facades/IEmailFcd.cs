//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Interfaces.Facades
{
    public interface IEmailFcd
    {
        public void SendEmail(string email, string subject, string content);
    }
}
