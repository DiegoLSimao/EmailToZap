using MimeKit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailToZap.Classes
{
    public class Zapzap
    {

        public void EncaminharViaLinkZapZap(string numTel, MimeMessage email)
        {
            string mensagem = $"https://wa.me/{numTel}?text=De:{email.From}. Mensagem: {email.TextBody}";
            Process.Start(mensagem);
        }

    }
}
