namespace cursoAlura
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.btn_demostrationKey = new System.Windows.Forms.Button();
            this.btn_helloWorld = new System.Windows.Forms.Button();
            this.btn_mask = new System.Windows.Forms.Button();
            this.btn_validationCPF = new System.Windows.Forms.Button();
            this.btn_messageBox = new System.Windows.Forms.Button();
            this.btn_passwordValidation = new System.Windows.Forms.Button();
            this.btn_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_demostrationKey
            // 
            this.btn_demostrationKey.Image = ((System.Drawing.Image)(resources.GetObject("btn_demostrationKey.Image")));
            this.btn_demostrationKey.Location = new System.Drawing.Point(12, 12);
            this.btn_demostrationKey.Name = "btn_demostrationKey";
            this.btn_demostrationKey.Size = new System.Drawing.Size(114, 48);
            this.btn_demostrationKey.TabIndex = 0;
            this.btn_demostrationKey.Text = "Demonstração Key";
            this.btn_demostrationKey.UseVisualStyleBackColor = true;
            this.btn_demostrationKey.Click += new System.EventHandler(this.btn_demostrationKey_Click);
            // 
            // btn_helloWorld
            // 
            this.btn_helloWorld.Image = ((System.Drawing.Image)(resources.GetObject("btn_helloWorld.Image")));
            this.btn_helloWorld.Location = new System.Drawing.Point(132, 12);
            this.btn_helloWorld.Name = "btn_helloWorld";
            this.btn_helloWorld.Size = new System.Drawing.Size(114, 48);
            this.btn_helloWorld.TabIndex = 1;
            this.btn_helloWorld.Text = "HelloWorld";
            this.btn_helloWorld.UseVisualStyleBackColor = true;
            this.btn_helloWorld.Click += new System.EventHandler(this.btn_helloWorld_Click);
            // 
            // btn_mask
            // 
            this.btn_mask.Image = ((System.Drawing.Image)(resources.GetObject("btn_mask.Image")));
            this.btn_mask.Location = new System.Drawing.Point(256, 12);
            this.btn_mask.Name = "btn_mask";
            this.btn_mask.Size = new System.Drawing.Size(114, 48);
            this.btn_mask.TabIndex = 2;
            this.btn_mask.Text = "Máscara";
            this.btn_mask.UseVisualStyleBackColor = true;
            this.btn_mask.Click += new System.EventHandler(this.btn_mask_Click);
            // 
            // btn_validationCPF
            // 
            this.btn_validationCPF.Image = ((System.Drawing.Image)(resources.GetObject("btn_validationCPF.Image")));
            this.btn_validationCPF.Location = new System.Drawing.Point(12, 66);
            this.btn_validationCPF.Name = "btn_validationCPF";
            this.btn_validationCPF.Size = new System.Drawing.Size(114, 48);
            this.btn_validationCPF.TabIndex = 3;
            this.btn_validationCPF.Text = "Valida CPF";
            this.btn_validationCPF.UseVisualStyleBackColor = true;
            this.btn_validationCPF.Click += new System.EventHandler(this.btn_validationCPF_Click);
            // 
            // btn_messageBox
            // 
            this.btn_messageBox.Image = ((System.Drawing.Image)(resources.GetObject("btn_messageBox.Image")));
            this.btn_messageBox.Location = new System.Drawing.Point(132, 66);
            this.btn_messageBox.Name = "btn_messageBox";
            this.btn_messageBox.Size = new System.Drawing.Size(114, 48);
            this.btn_messageBox.TabIndex = 4;
            this.btn_messageBox.Text = "CPF Caixa de Mensagens";
            this.btn_messageBox.UseVisualStyleBackColor = true;
            this.btn_messageBox.Click += new System.EventHandler(this.btn_messageBox_Click);
            // 
            // btn_passwordValidation
            // 
            this.btn_passwordValidation.Image = ((System.Drawing.Image)(resources.GetObject("btn_passwordValidation.Image")));
            this.btn_passwordValidation.Location = new System.Drawing.Point(256, 66);
            this.btn_passwordValidation.Name = "btn_passwordValidation";
            this.btn_passwordValidation.Size = new System.Drawing.Size(114, 48);
            this.btn_passwordValidation.TabIndex = 5;
            this.btn_passwordValidation.Text = "Valida Senha";
            this.btn_passwordValidation.UseVisualStyleBackColor = true;
            this.btn_passwordValidation.Click += new System.EventHandler(this.btn_passwordValidation_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(276, 163);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(91, 31);
            this.btn_finish.TabIndex = 6;
            this.btn_finish.Text = "Finalizar";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 206);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.btn_passwordValidation);
            this.Controls.Add(this.btn_messageBox);
            this.Controls.Add(this.btn_validationCPF);
            this.Controls.Add(this.btn_mask);
            this.Controls.Add(this.btn_helloWorld);
            this.Controls.Add(this.btn_demostrationKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_demostrationKey;
        private System.Windows.Forms.Button btn_helloWorld;
        private System.Windows.Forms.Button btn_mask;
        private System.Windows.Forms.Button btn_validationCPF;
        private System.Windows.Forms.Button btn_messageBox;
        private System.Windows.Forms.Button btn_passwordValidation;
        private System.Windows.Forms.Button btn_finish;
    }
}