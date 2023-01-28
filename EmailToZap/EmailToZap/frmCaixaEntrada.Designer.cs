namespace EmailToZap
{
    partial class frmCaixadeEntrada
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
            this.listboxCaixaEntrada = new System.Windows.Forms.ListBox();
            this.btnReceber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxCaixaEntrada
            // 
            this.listboxCaixaEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxCaixaEntrada.FormattingEnabled = true;
            this.listboxCaixaEntrada.Location = new System.Drawing.Point(0, 0);
            this.listboxCaixaEntrada.Name = "listboxCaixaEntrada";
            this.listboxCaixaEntrada.Size = new System.Drawing.Size(799, 407);
            this.listboxCaixaEntrada.TabIndex = 0;
            this.listboxCaixaEntrada.DoubleClick += new System.EventHandler(this.listboxCaixaEntrada_DoubleClick);
            // 
            // btnReceber
            // 
            this.btnReceber.Location = new System.Drawing.Point(12, 413);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(116, 28);
            this.btnReceber.TabIndex = 1;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // frmCaixadeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.listboxCaixaEntrada);
            this.Name = "frmCaixadeEntrada";
            this.Text = "Caixa de entrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxCaixaEntrada;
        private System.Windows.Forms.Button btnReceber;
    }
}