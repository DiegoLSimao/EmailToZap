using EmailToZap.Classes;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailToZap
{
    public partial class frmEmail : Form
    {
        private List<string> _anexos = null;
        public frmEmail()
        {
            InitializeComponent();
            btnAnexar.Visible = true;
            btnEnviar.Visible = true;
            PreencherCamposEnviarEmail();
        }

        //***Construtor que recebe um email
        public frmEmail(MimeMessage email)
        {
            InitializeComponent();
            btnAnexar.Visible= false;
            btnEnviar.Visible= false;   
            PreencherCamposEmailRecebido(email);
        }

        private void PreencherCamposEmailRecebido(MimeMessage email)
        {
            txtEmailDe.Text = email.From.ToString();
            txtEmailPara.Text = Email.Instancia.EmailOrigem;
            txtAssunto.Text = email.Subject.ToString();
            txtCorpoDoEmail.Text = email.TextBody;
        }

        private void PreencherCamposEnviarEmail()
        {
            txtEmailDe.Text = Email.Instancia.EmailOrigem;
            txtEmailPara.Text = string.Empty;
            txtAssunto.Text = string.Empty;
            txtCorpoDoEmail.Text = string.Empty;
        }

        private void frmEmail_Load(object sender, EventArgs e)
        {
            btnEnviar.Enabled = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        { 
            Email.Instancia.EnviarEmail(EmailsDestinatario(), txtAssunto.Text, txtCorpoDoEmail.Text, _anexos);
            LimparCampos();
        }

        private List<string> EmailsDestinatario()
        {
            var ret = new List<string>();
            var emailSemEspaco = txtEmailPara.Text.Replace(" ", "");
            var emails = emailSemEspaco.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var email in emails)
            {
                ret.Add(email);
            }

            return ret;
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            _anexos = Anexos();

            if (_anexos.Count > 0)
            {
                btnAnexar.Text = $"Anexar({_anexos.Count})";
            }
        }


        private List<string> Anexos()
        {
            var ret = new List<string>();
            var ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                foreach (var fileName in ofd.FileNames)
                {
                    ret.Add(fileName);
                }
            }
            else
            {
                ret = null;
            }

            return ret;
        }

        private void LimparCampos()
        {
            btnAnexar.Text = $"Anexar";
            txtAssunto.Text = string.Empty;
            txtCorpoDoEmail.Text = string.Empty;
            txtEmailDe.Text = string.Empty;
            txtEmailPara.Text= string.Empty;
            btnEnviar.Enabled = false;

        }

        private void txtCorpoDoEmail_KeyDown(object sender, KeyEventArgs e)
        {
            bool BotaoEnviar = string.IsNullOrEmpty(txtCorpoDoEmail.Text) | string.IsNullOrEmpty(txtAssunto.Text) | string.IsNullOrEmpty(txtEmailDe.Text);

            if (!BotaoEnviar)
            {
               btnEnviar.Enabled = true;
            }
            else
            {
                btnEnviar.Enabled = false;
            }
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            var f  = new frmCaixadeEntrada();
            f.ShowDialog();
        }
    }
}
