namespace cursoAlura
{
    partial class frm_mask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mask));
            this.msk_textBox = new System.Windows.Forms.MaskedTextBox();
            this.lbl_content = new System.Windows.Forms.Label();
            this.lbl_onMask = new System.Windows.Forms.Label();
            this.btn_hour = new System.Windows.Forms.Button();
            this.btn_cep = new System.Windows.Forms.Button();
            this.btn_coin = new System.Windows.Forms.Button();
            this.btn_date = new System.Windows.Forms.Button();
            this.btn_password = new System.Windows.Forms.Button();
            this.btn_tel = new System.Windows.Forms.Button();
            this.btn_showContent = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msk_textBox
            // 
            this.msk_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_textBox.Location = new System.Drawing.Point(23, 50);
            this.msk_textBox.Name = "msk_textBox";
            this.msk_textBox.Size = new System.Drawing.Size(258, 26);
            this.msk_textBox.TabIndex = 0;
            // 
            // lbl_content
            // 
            this.lbl_content.AutoSize = true;
            this.lbl_content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_content.Location = new System.Drawing.Point(23, 246);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(0, 19);
            this.lbl_content.TabIndex = 1;
            // 
            // lbl_onMask
            // 
            this.lbl_onMask.AutoSize = true;
            this.lbl_onMask.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_onMask.Location = new System.Drawing.Point(19, 30);
            this.lbl_onMask.Name = "lbl_onMask";
            this.lbl_onMask.Size = new System.Drawing.Size(0, 19);
            this.lbl_onMask.TabIndex = 2;
            // 
            // btn_hour
            // 
            this.btn_hour.Location = new System.Drawing.Point(23, 85);
            this.btn_hour.Name = "btn_hour";
            this.btn_hour.Size = new System.Drawing.Size(82, 37);
            this.btn_hour.TabIndex = 3;
            this.btn_hour.Text = "Hora";
            this.btn_hour.UseVisualStyleBackColor = true;
            this.btn_hour.Click += new System.EventHandler(this.btn_hour_Click);
            // 
            // btn_cep
            // 
            this.btn_cep.Location = new System.Drawing.Point(111, 85);
            this.btn_cep.Name = "btn_cep";
            this.btn_cep.Size = new System.Drawing.Size(82, 37);
            this.btn_cep.TabIndex = 4;
            this.btn_cep.Text = "CEP";
            this.btn_cep.UseVisualStyleBackColor = true;
            this.btn_cep.Click += new System.EventHandler(this.btn_cep_Click);
            // 
            // btn_coin
            // 
            this.btn_coin.Location = new System.Drawing.Point(199, 85);
            this.btn_coin.Name = "btn_coin";
            this.btn_coin.Size = new System.Drawing.Size(82, 37);
            this.btn_coin.TabIndex = 5;
            this.btn_coin.Text = "Moeda";
            this.btn_coin.UseVisualStyleBackColor = true;
            this.btn_coin.Click += new System.EventHandler(this.btn_coin_Click);
            // 
            // btn_date
            // 
            this.btn_date.Location = new System.Drawing.Point(23, 128);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(82, 37);
            this.btn_date.TabIndex = 6;
            this.btn_date.Text = "Data";
            this.btn_date.UseVisualStyleBackColor = true;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // btn_password
            // 
            this.btn_password.Location = new System.Drawing.Point(111, 128);
            this.btn_password.Name = "btn_password";
            this.btn_password.Size = new System.Drawing.Size(82, 37);
            this.btn_password.TabIndex = 7;
            this.btn_password.Text = "Senha";
            this.btn_password.UseVisualStyleBackColor = true;
            this.btn_password.Click += new System.EventHandler(this.btn_password_Click);
            // 
            // btn_tel
            // 
            this.btn_tel.Location = new System.Drawing.Point(199, 128);
            this.btn_tel.Name = "btn_tel";
            this.btn_tel.Size = new System.Drawing.Size(82, 37);
            this.btn_tel.TabIndex = 8;
            this.btn_tel.Text = "Telefone";
            this.btn_tel.UseVisualStyleBackColor = true;
            this.btn_tel.Click += new System.EventHandler(this.btn_tel_Click);
            // 
            // btn_showContent
            // 
            this.btn_showContent.Location = new System.Drawing.Point(23, 178);
            this.btn_showContent.Name = "btn_showContent";
            this.btn_showContent.Size = new System.Drawing.Size(109, 37);
            this.btn_showContent.TabIndex = 9;
            this.btn_showContent.Text = "Ver Conteúdo";
            this.btn_showContent.UseVisualStyleBackColor = true;
            this.btn_showContent.Click += new System.EventHandler(this.btn_showContent_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(172, 178);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(109, 37);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Limpar";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(172, 238);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(109, 37);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Fechar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_mask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 281);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_showContent);
            this.Controls.Add(this.btn_tel);
            this.Controls.Add(this.btn_password);
            this.Controls.Add(this.btn_date);
            this.Controls.Add(this.btn_coin);
            this.Controls.Add(this.btn_cep);
            this.Controls.Add(this.btn_hour);
            this.Controls.Add(this.lbl_onMask);
            this.Controls.Add(this.lbl_content);
            this.Controls.Add(this.msk_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_mask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascaras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_textBox;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.Label lbl_onMask;
        private System.Windows.Forms.Button btn_hour;
        private System.Windows.Forms.Button btn_cep;
        private System.Windows.Forms.Button btn_coin;
        private System.Windows.Forms.Button btn_date;
        private System.Windows.Forms.Button btn_password;
        private System.Windows.Forms.Button btn_tel;
        private System.Windows.Forms.Button btn_showContent;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_close;
    }
}