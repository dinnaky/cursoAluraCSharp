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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_demostrationKey_Click(object sender, EventArgs e)
        {
            frm_demostrationKey frm = new frm_demostrationKey();
            frm.ShowDialog();
        }

        private void btn_helloWorld_Click(object sender, EventArgs e)
        {
            frm_helloWorld frm = new frm_helloWorld();  
            frm.ShowDialog();
        }

        private void btn_mask_Click(object sender, EventArgs e)
        {
            frm_mask frm = new frm_mask();  
            frm.ShowDialog();
        }

        private void btn_validationCPF_Click(object sender, EventArgs e)
        {
            frm_validationCPF frm = new frm_validationCPF();
            frm.ShowDialog();
        }

        private void btn_messageBox_Click(object sender, EventArgs e)
        {
            frm_messageBox frm = new frm_messageBox();  
            frm.ShowDialog();
        }

        private void btn_passwordValidation_Click(object sender, EventArgs e)
        {
            frm_passwordValidation frm = new frm_passwordValidation();
            frm.ShowDialog();
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
