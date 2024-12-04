namespace cursoAlura
{
    partial class frm_demostrationKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_demostrationKey));
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_maius = new System.Windows.Forms.Label();
            this.lbl_upper = new System.Windows.Forms.Label();
            this.lbl_lower = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(8, 8);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(100, 20);
            this.txt_input.TabIndex = 0;
            this.txt_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_input_KeyDown);
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(8, 40);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_msg.Size = new System.Drawing.Size(304, 232);
            this.txt_msg.TabIndex = 1;
            this.txt_msg.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(328, 8);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 28);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Limpa";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minus.";
            // 
            // lbl_maius
            // 
            this.lbl_maius.AutoSize = true;
            this.lbl_maius.Location = new System.Drawing.Point(320, 56);
            this.lbl_maius.Name = "lbl_maius";
            this.lbl_maius.Size = new System.Drawing.Size(38, 13);
            this.lbl_maius.TabIndex = 4;
            this.lbl_maius.Text = "Maius.";
            // 
            // lbl_upper
            // 
            this.lbl_upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_upper.Location = new System.Drawing.Point(368, 56);
            this.lbl_upper.Name = "lbl_upper";
            this.lbl_upper.Size = new System.Drawing.Size(32, 23);
            this.lbl_upper.TabIndex = 5;
            // 
            // lbl_lower
            // 
            this.lbl_lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_lower.Location = new System.Drawing.Point(368, 104);
            this.lbl_lower.Name = "lbl_lower";
            this.lbl_lower.Size = new System.Drawing.Size(32, 23);
            this.lbl_lower.TabIndex = 6;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(328, 244);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 28);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Fechar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_demostrationKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_lower);
            this.Controls.Add(this.lbl_upper);
            this.Controls.Add(this.lbl_maius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_demostrationKey";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_maius;
        private System.Windows.Forms.Label lbl_upper;
        private System.Windows.Forms.Label lbl_lower;
        private System.Windows.Forms.Button btn_close;
    }
}