namespace EmailToZap.Janelas
{
    partial class inputBox
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.txtEntradaDados = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 53);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(93, 53);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(171, 53);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // txtEntradaDados
            // 
            this.txtEntradaDados.Location = new System.Drawing.Point(12, 27);
            this.txtEntradaDados.Name = "txtEntradaDados";
            this.txtEntradaDados.Size = new System.Drawing.Size(238, 20);
            this.txtEntradaDados.TabIndex = 4;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(58, 13);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "mensagem";
            // 
            // inputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 86);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtEntradaDados);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "inputBox";
            this.ShowIcon = false;
            this.Text = "inputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox txtEntradaDados;
        private System.Windows.Forms.Label lblMensagem;
    }
}