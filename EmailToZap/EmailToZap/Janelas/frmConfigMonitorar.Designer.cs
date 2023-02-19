namespace EmailToZap.Janelas
{
    partial class frmConfigMonitorar
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
            this.txtContatosNotificar = new System.Windows.Forms.TextBox();
            this.txtEmailMonitorado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempoMinutos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtContatosNotificar
            // 
            this.txtContatosNotificar.Location = new System.Drawing.Point(15, 64);
            this.txtContatosNotificar.Name = "txtContatosNotificar";
            this.txtContatosNotificar.Size = new System.Drawing.Size(748, 20);
            this.txtContatosNotificar.TabIndex = 8;
            // 
            // txtEmailMonitorado
            // 
            this.txtEmailMonitorado.Location = new System.Drawing.Point(15, 25);
            this.txtEmailMonitorado.Name = "txtEmailMonitorado";
            this.txtEmailMonitorado.Size = new System.Drawing.Size(748, 20);
            this.txtEmailMonitorado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contatos a serem notificados no WhattsApp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Emails a serem monitorados na caixa de entrada";
            // 
            // btnInicial
            // 
            this.btnInicial.Location = new System.Drawing.Point(15, 141);
            this.btnInicial.Name = "btnInicial";
            this.btnInicial.Size = new System.Drawing.Size(75, 23);
            this.btnInicial.TabIndex = 9;
            this.btnInicial.Text = "Iniciar";
            this.btnInicial.UseVisualStyleBackColor = true;
            this.btnInicial.Click += new System.EventHandler(this.btnInicial_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tempo de verificação do email (min)";
            // 
            // txtTempoMinutos
            // 
            this.txtTempoMinutos.Location = new System.Drawing.Point(15, 106);
            this.txtTempoMinutos.Name = "txtTempoMinutos";
            this.txtTempoMinutos.Size = new System.Drawing.Size(174, 20);
            this.txtTempoMinutos.TabIndex = 11;
            // 
            // frmConfigMonitorar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 198);
            this.Controls.Add(this.txtTempoMinutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInicial);
            this.Controls.Add(this.txtContatosNotificar);
            this.Controls.Add(this.txtEmailMonitorado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConfigMonitorar";
            this.ShowIcon = false;
            this.Text = "Configuração de Monitoramento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContatosNotificar;
        private System.Windows.Forms.TextBox txtEmailMonitorado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTempoMinutos;
    }
}