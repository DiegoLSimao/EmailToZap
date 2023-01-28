using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Threading;
using MimeKit;

namespace EmailToZap.Classes
{
    public class Email
    {
        private string Provedor { get;  set; }
        private string EmailOrigem { get;  set; }
        private string Senha { get;  set; }

        public Email()
        {
            var path = "C:\\Projetos\\EmailToZap\\EmailToZap\\config.tmp";

            Provedor = LerConfig(path, nameof(Provedor));
            EmailOrigem = LerConfig(path, nameof(EmailOrigem));
            Senha = LerConfig(path, nameof(Senha));
        }

        private string LerConfig(string path, string config)
        {
            var linhas = File.ReadAllLines(path);

            foreach (var linha in linhas)
            {
                if(linha.Contains(config))
                {
                    var separar = linha.Split(':');
                    return separar[1].Trim();
                }
            }
            return null;

        }


        public void EnviarEmail(List<string> emails, string assunto, string corpoEmail, List<string> anexos)
        {
            (new Thread(() => {
                var mensagem = PrepararMensagem(emails, assunto, corpoEmail, anexos);
                EnviarEmailPeloSmtp(mensagem);
            })).Start();
        }


        private MailMessage PrepararMensagem(List<string> emails, string assunto, string corpoEmail, List<string> anexos)
        {
            var mail = new MailMessage();
            mail.From = new MailAddress(EmailOrigem);

            //*** Lista de emails destino
            foreach (var email in emails)
            {
                mail.To.Add(email);           
            }

            mail.Subject = assunto;
            mail.Body = corpoEmail;
            mail.IsBodyHtml= true;

            //***Anexos
            if (anexos != null)
            {
                foreach (var anexo in anexos)
                {
                    var data = new Attachment(anexo, MediaTypeNames.Application.Octet);
                    mail.Attachments.Add(data);
                }
            }
            return mail;
        }


        private bool ValidarEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

        private void EnviarEmailPeloSmtp(MailMessage mensagem)
        {
            SmtpClient smtpClient= new SmtpClient();
            smtpClient.Host = Provedor;
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;   
            smtpClient.Timeout = 60000;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(EmailOrigem, Senha);
            smtpClient.Send(mensagem);
            smtpClient.Dispose();
            
        }

        public List<MimeMessage> ReceberEmailsIMAP()
        {
            string email = EmailOrigem;
            string password = Senha;

            List<MimeMessage> list = new List<MimeMessage>();

            try
            {
                using (ImapClient client = new ImapClient())
                {
                    // configurações do servidor de e-mail
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(email, password);
                    client.Inbox.Open(FolderAccess.ReadOnly);

                    // ler os e-mails do servidor
                    for (int i = 0; i < client.Inbox.Count; i++)
                    {
                        var message = client.Inbox.GetMessage(i);
                        Console.WriteLine("De: " + message.From);
                        Console.WriteLine("Assunto: " + message.Subject);
                        Console.WriteLine("Corpo: " + message.TextBody);
                        list.Add(message);
                    }
                    client.Disconnect(true);
                    return list;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }




    }  
}
