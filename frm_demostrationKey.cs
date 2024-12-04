using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursoAlura
{
    public partial class frm_demostrationKey : Form
    {
        public frm_demostrationKey()
        {
            InitializeComponent();
        }

        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            txt_msg.AppendText("\r\n" + "Pressionei a tecla: " + e.KeyCode + "\r\n");
            txt_msg.AppendText("\t" + "Código da letra: " + e.KeyValue + "\r\n");
            lbl_lower.Text = e.KeyCode.ToString().ToLower();
            lbl_upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
            txt_msg.Clear();
            lbl_lower.Text = " ";
            lbl_upper.Text = " ";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
