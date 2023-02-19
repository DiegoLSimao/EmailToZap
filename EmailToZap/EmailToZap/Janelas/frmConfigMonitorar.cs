using EmailToZap.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailToZap.Janelas
{
    public partial class frmConfigMonitorar : Form
    {
        public frmConfigMonitorar()
        {
            InitializeComponent();
        }

        private void btnInicial_Click(object sender, EventArgs e)
        {
            var monitoramento = new Monitoramento(EmailsMonitorar(), ContatosNotificar(), TempoEmMinutos());


            this.Close();
        }

        private int TempoEmMinutos()
        {
            int num=0;

            bool sucesso = int.TryParse(txtTempoMinutos.Text, out num);
            if (sucesso)
            {
                if(num == 0)
                {
                    MessageBox.Show("Não é permitido valor zero.\r\nFoi adotado 1 minuto!");
                    return 1;
                }
                return num;
            }
            else
            {
                //*** Mínimo é um minuto
                return 1;
            }

            
        }

        private List<string> EmailsMonitorar()
        {
            return SepararEmLista(txtEmailMonitorado.Text);
        }

        private List<string> ContatosNotificar()
        {
            return SepararEmLista(txtContatosNotificar.Text);
        }

        private List<string> SepararEmLista(string texto)
        {
            var textoSemEspaco = texto.Replace(" ", "");
            var separadoPontoVirgula = textoSemEspaco.Split(';');
            var textoEmLista = new List<string>();

            foreach (var item in separadoPontoVirgula)
            {
                if (string.IsNullOrEmpty(item)) continue;
                textoEmLista.Add(item);
            }

            return textoEmLista;
        }


    }
}
