namespace EmailToZap
{
    partial class frmEmail
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.txtEmailDe = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblCEmailDe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorpoDoEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailPara = new System.Windows.Forms.TextBox();
            this.lblEmailPara = new System.Windows.Forms.Label();
            this.btnReceber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 446);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAnexar
            // 
            this.btnAnexar.Location = new System.Drawing.Point(93, 446);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(75, 23);
            this.btnAnexar.TabIndex = 1;
            this.btnAnexar.Text = "Anexar";
            this.btnAnexar.UseVisualStyleBackColor = true;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // txtEmailDe
            // 
            this.txtEmailDe.Location = new System.Drawing.Point(15, 25);
            this.txtEmailDe.Name = "txtEmailDe";
            this.txtEmailDe.Size = new System.Drawing.Size(643, 20);
            this.txtEmailDe.TabIndex = 3;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(15, 103);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(643, 20);
            this.txtAssunto.TabIndex = 4;
            // 
            // lblCEmailDe
            // 
            this.lblCEmailDe.AutoSize = true;
            this.lblCEmailDe.Location = new System.Drawing.Point(12, 9);
            this.lblCEmailDe.Name = "lblCEmailDe";
            this.lblCEmailDe.Size = new System.Drawing.Size(52, 13);
            this.lblCEmailDe.TabIndex = 6;
            this.lblCEmailDe.Text = "Email De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Assunto do Email";
            // 
            // txtCorpoDoEmail
            // 
            this.txtCorpoDoEmail.Location = new System.Drawing.Point(12, 142);
            this.txtCorpoDoEmail.Multiline = true;
            this.txtCorpoDoEmail.Name = "txtCorpoDoEmail";
            this.txtCorpoDoEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCorpoDoEmail.Size = new System.Drawing.Size(643, 298);
            this.txtCorpoDoEmail.TabIndex = 8;
            this.txtCorpoDoEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCorpoDoEmail_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Corpo do Email";
            // 
            // txtEmailPara
            // 
            this.txtEmailPara.Location = new System.Drawing.Point(15, 64);
            this.txtEmailPara.Name = "txtEmailPara";
            this.txtEmailPara.Size = new System.Drawing.Size(643, 20);
            this.txtEmailPara.TabIndex = 10;
            // 
            // lblEmailPara
            // 
            this.lblEmailPara.AutoSize = true;
            this.lblEmailPara.Location = new System.Drawing.Point(12, 48);
            this.lblEmailPara.Name = "lblEmailPara";
            this.lblEmailPara.Size = new System.Drawing.Size(60, 13);
            this.lblEmailPara.TabIndex = 11;
            this.lblEmailPara.Text = "Email Para:";
            // 
            // btnReceber
            // 
            this.btnReceber.Location = new System.Drawing.Point(580, 446);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(75, 23);
            this.btnReceber.TabIndex = 12;
            this.btnReceber.Text = "receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 481);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.lblEmailPara);
            this.Controls.Add(this.txtEmailPara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorpoDoEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCEmailDe);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtEmailDe);
            this.Controls.Add(this.btnAnexar);
            this.Controls.Add(this.btnEnviar);
            this.Name = "frmEmail";
            this.ShowIcon = false;
            this.Text = "Email";
            this.Load += new System.EventHandler(this.frmEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.TextBox txtEmailDe;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblCEmailDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorpoDoEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailPara;
        private System.Windows.Forms.Label lblEmailPara;
        private System.Windows.Forms.Button btnReceber;
    }
}

