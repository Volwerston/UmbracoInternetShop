using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Models.Auxiliary
{
    class MailDirector : IDirector<string, MailContext>
    {
        public MailDirector(List<IBuilder<string, MailContext>> b)
        {
            Builders = b;
        }

        public List<IBuilder<string, MailContext>> Builders { get; set; }
        
        public void Act()
        {
            StringBuilder res = new StringBuilder();

            foreach(var builder in Builders)
            {
                res.Append(builder.Build());
            }

            SendEmailAsync("btsemail1@gmail.com", Builders[0].Context.Email, res.ToString());
        }

        private void SendEmailAsync(string sender, string receiver, string message)
        {
            string smtpHost = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUserName = "btsemail1@gmail.com";
            string smtpUserPass = "btsadmin";

            SmtpClient client = new SmtpClient(smtpHost, smtpPort);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(smtpUserName, smtpUserPass);
            client.EnableSsl = true;

            string msgSubject = "Internet Shop Message";

            MailMessage mes = new MailMessage(sender, receiver, msgSubject, message);

            mes.IsBodyHtml = true;

            client.Send(mes);
        }
    }
}
