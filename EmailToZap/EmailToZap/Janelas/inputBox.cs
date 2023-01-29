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
    public partial class inputBox : Form
    {
        public static DialogResult Resultado;
        public static string EntradaDados;

        public inputBox(int modo, string titulo, string mensagem)
        {
            InitializeComponent();
            MontarTela(modo, titulo, mensagem);
        }


        private void MontarTela(int modo, string titulo, string mensagem)
        {
            Text = titulo;
            lblMensagem.Text = mensagem;
            switch (modo)
            {
                case 1:
                    btn1.Text = "OK";
                    btn2.Text = "Não";
                    btn3.Text = "Cancelar";
                    btn1.Visible = true;                 
                    btn2.Visible = false;
                    btn3.Visible = true;
                    break;

                case 2:
                    btn1.Text = "Sim";
                    btn2.Text = "Não";
                    btn3.Text = "Cancelar";
                    btn1.Visible = true;
                    btn2.Visible = true;
                    btn3.Visible = true;
                    break;

            }



        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //OK ou SIm
            Resultado = DialogResult.OK;
            EntradaDados = txtEntradaDados.Text;
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Não
            Resultado = DialogResult.No;
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //Cancelar
            Resultado = DialogResult.Cancel;
            this.Close();
        }
    }
}
