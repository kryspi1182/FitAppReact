﻿using FitAppReact.Interfaces.Facades;
using FitAppReact.Interfaces.Infrastructure.EmailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAppReact.Facades
{
    public class EmailFcd : IEmailFcd
    {
        private readonly IEmailSrv emailSrv;

        public EmailFcd(IEmailSrv _emailSrv)
        {
            emailSrv = _emailSrv;
        }

        public void SendVerificationEmail(string email, string subject, string content)
        {
            emailSrv.SendVerificationEmail(email, subject, content);
        }
    }
}