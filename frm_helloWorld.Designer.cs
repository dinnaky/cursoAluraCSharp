namespace cursoAlura
{
    partial class frm_helloWorld
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_helloWorld));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.txt_contentLbl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(30, 30);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(107, 32);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "DIGITE";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(352, 364);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(90, 30);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Fechar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(30, 130);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(90, 45);
            this.btn_modify.TabIndex = 2;
            this.btn_modify.Text = "Trocar";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_contentLbl
            // 
            this.txt_contentLbl.Location = new System.Drawing.Point(30, 90);
            this.txt_contentLbl.Name = "txt_contentLbl";
            this.txt_contentLbl.Size = new System.Drawing.Size(209, 20);
            this.txt_contentLbl.TabIndex = 3;
            // 
            // frm_helloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 406);
            this.Controls.Add(this.txt_contentLbl);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_helloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.TextBox txt_contentLbl;
    }
}

