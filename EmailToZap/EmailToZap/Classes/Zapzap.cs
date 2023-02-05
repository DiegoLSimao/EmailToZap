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
        const int DELAY_ms = 1000;

        private string Url { get; set; }
        private static ChromeDriver _chromeDriver { get; set; }

        private static Zapzap _instancia;

        public static Zapzap Instancia
        {
            get
            {
                if (_instancia is null)
                {
                    _instancia = new Zapzap();
                    _chromeDriver = new ChromeDriver();
                }
                return _instancia;
            }
        }

        public void EncaminharViaLinkZapZap(string numTel, MimeMessage email)
        {
            string mensagem = $"https://wa.me/{numTel}?text=De:{email.From}. Mensagem: {email.TextBody}";
            Process.Start(mensagem);
        }

        public void AbrirZapWeb()
        {          
            Url = "https://web.whatsapp.com";
            _chromeDriver.Navigate().GoToUrl(Url);
            MessageBox.Show("Scaneie o QR code do WhatsApp Web!");
        }

        private void DigitarCampoPesquisarContato(string contato )
        {
            IWebElement campoPesquisarContato = _chromeDriver.FindElement(By.ClassName("Er7QU"));
            campoPesquisarContato.SendKeys(contato);
            Thread.Sleep(DELAY_ms);
        }

        private void ClickNoContato(string contato)
        {
            IWebElement contatoClick = _chromeDriver.FindElement(By.XPath($"//span[@title='{contato}']"));
            contatoClick.Click();
            Thread.Sleep(DELAY_ms);
        }

        private void DigitarMensagem(string mensagem)
        {
            IWebElement campoChat = _chromeDriver.FindElement(By.ClassName("_3Uu1_"));
            campoChat.SendKeys(mensagem);
            Thread.Sleep(DELAY_ms);
        }

        private void ClickEnviarMensagem()
        {           
            IWebElement botaoEnviar = _chromeDriver.FindElement(By.XPath("//span[@data-icon='send']"));
            botaoEnviar.Click();
            Thread.Sleep(DELAY_ms);
        }


        public void EnviarMensagem(string contato, string mensagem)
        {
            ClickNoContato(contato);
            DigitarMensagem(mensagem);
            ClickEnviarMensagem();
        }


    }
}
