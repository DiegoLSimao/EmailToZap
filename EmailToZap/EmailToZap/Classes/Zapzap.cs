using MimeKit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailToZap.Classes
{
    public class Zapzap
    {
        private List<string> Contatos { get; set; }
        private string Url { get; set; }

        private ChromeDriver Driver { get; set; }


        public void EncaminharViaLinkZapZap(string numTel, MimeMessage email)
        {
            string mensagem = $"https://wa.me/{numTel}?text=De:{email.From}. Mensagem: {email.TextBody}";
            Process.Start(mensagem);
        }

        public void AbrirZapWeb()
        {          
            Url = "https://web.whatsapp.com";
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Url);
            MessageBox.Show("Scaneie o QR code do WhatsApp Web!");
        }

        public void ProcurarContatos(string contato )
        {
            IWebElement nomeClasse = Driver.FindElement(By.ClassName("Er7QU"));
            nomeClasse.SendKeys(contato);
        }



    }
}
