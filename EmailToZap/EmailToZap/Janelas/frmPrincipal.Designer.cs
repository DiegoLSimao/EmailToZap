namespace EmailToZap.Janelas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReceberEmail = new System.Windows.Forms.Button();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.receberEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classeZapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.btnConfig = new System.Windows.Forms.Button();
            this.iniciarMonitoramentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receberEmailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReceberEmail
            // 
            this.btnReceberEmail.Location = new System.Drawing.Point(0, 0);
            this.btnReceberEmail.Name = "btnReceberEmail";
            this.btnReceberEmail.Size = new System.Drawing.Size(75, 23);
            this.btnReceberEmail.TabIndex = 0;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(0, 0);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarEmail.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receberEmailToolStripMenuItem,
            this.configuraçãoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // receberEmailToolStripMenuItem
            // 
            this.receberEmailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarMonitoramentoToolStripMenuItem,
            this.enviarEmailToolStripMenuItem,
            this.receberEmailToolStripMenuItem1});
            this.receberEmailToolStripMenuItem.Name = "receberEmailToolStripMenuItem";
            this.receberEmailToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.receberEmailToolStripMenuItem.Text = "Menu";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classeZapToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // classeZapToolStripMenuItem
            // 
            this.classeZapToolStripMenuItem.Name = "classeZapToolStripMenuItem";
            this.classeZapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.classeZapToolStripMenuItem.Text = "Classe Zap";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 699);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1036, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(0, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 0;
            // 
            // iniciarMonitoramentoToolStripMenuItem
            // 
            this.iniciarMonitoramentoToolStripMenuItem.Image = global::EmailToZap.Properties.Resources.eye;
            this.iniciarMonitoramentoToolStripMenuItem.Name = "iniciarMonitoramentoToolStripMenuItem";
            this.iniciarMonitoramentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarMonitoramentoToolStripMenuItem.Text = "Iniciar ";
            this.iniciarMonitoramentoToolStripMenuItem.Click += new System.EventHandler(this.iniciarMonitoramentoToolStripMenuItem_Click);
            // 
            // enviarEmailToolStripMenuItem
            // 
            this.enviarEmailToolStripMenuItem.Image = global::EmailToZap.Properties.Resources.mail_out;
            this.enviarEmailToolStripMenuItem.Name = "enviarEmailToolStripMenuItem";
            this.enviarEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enviarEmailToolStripMenuItem.Text = "Enviar Email";
            this.enviarEmailToolStripMenuItem.Click += new System.EventHandler(this.enviarEmailToolStripMenuItem_Click);
            // 
            // receberEmailToolStripMenuItem1
            // 
            this.receberEmailToolStripMenuItem1.Image = global::EmailToZap.Properties.Resources.mail_into;
            this.receberEmailToolStripMenuItem1.Name = "receberEmailToolStripMenuItem1";
            this.receberEmailToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.receberEmailToolStripMenuItem1.Text = "Receber Email";
            this.receberEmailToolStripMenuItem1.Click += new System.EventHandler(this.receberEmailToolStripMenuItem1_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emailToolStripMenuItem.Text = "E-mail";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 721);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.Text = "Notificador de zap para email";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReceberEmail;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem receberEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarMonitoramentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receberEmailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enviarEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classeZapToolStripMenuItem;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
    }
}