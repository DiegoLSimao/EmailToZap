using EmailToZap.Classes;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MimeKit;

namespace EmailToZap
{
    public partial class frmCaixadeEntrada : Form
    {
        private List<MimeMessage> ListaDeMensagens { get; set; }

        public frmCaixadeEntrada()
        {
            InitializeComponent();
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            LimparLista();
            ReceberMensagens();
            AdicionarMensagensNaLista();
        }

        private void LimparLista()
        {
            listboxCaixaEntrada.Items.Clear();
        }

        private void ReceberMensagens()
        {
            if(ListaDeMensagens is null)
            {
                ListaDeMensagens = new List<MimeMessage>();
            }
            ListaDeMensagens = new Email().ReceberEmailsIMAP();
        }

        private void AdicionarMensagensNaLista()
        {
            int j = 0;
            foreach (var email in ListaDeMensagens)
            {
                string str = $"[{j}]-De: {email.From} ";
                listboxCaixaEntrada.Items.Add(str);
                j++;
            }
        }

        private void listboxCaixaEntrada_DoubleClick(object sender, EventArgs e)
        {
            var indice = listboxCaixaEntrada.SelectedIndex;
            var frm = new frmEmail(ListaDeMensagens[indice]);
            frm.ShowDialog();
        }




        private void listboxCaixaEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecao = listboxCaixaEntrada.SelectedItem;
            var dois = listboxCaixaEntrada.SelectedIndex;
        }
    }
}
