namespace cursoAlura
{
    partial class frm_messageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_messageBox));
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_validation = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(12, 45);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(218, 20);
            this.msk_cpf.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(245, 42);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(111, 23);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Limpa";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_validation
            // 
            this.btn_validation.Location = new System.Drawing.Point(245, 71);
            this.btn_validation.Name = "btn_validation";
            this.btn_validation.Size = new System.Drawing.Size(111, 23);
            this.btn_validation.TabIndex = 3;
            this.btn_validation.Text = "Valida";
            this.btn_validation.UseVisualStyleBackColor = true;
            this.btn_validation.Click += new System.EventHandler(this.btn_validation_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(245, 146);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(111, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Fechar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_messageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 181);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_validation);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.msk_cpf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_messageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa de Mensagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_validation;
        private System.Windows.Forms.Button btn_close;
    }
}