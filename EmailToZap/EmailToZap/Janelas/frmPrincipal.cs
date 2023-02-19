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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmEmail();
            f.MdiParent = this;
            f.Show();
        }

        private void receberEmailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new frmCaixadeEntrada();
            f.MdiParent = this;
            f.Show();
        }

        private void iniciarMonitoramentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmConfigMonitorar();
            f.MdiParent = this;
            f.Show();
        }
    }
}
