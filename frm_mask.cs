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
    public partial class frm_mask : Form
    {
        public frm_mask()
        {
            InitializeComponent();
        }

        private void btn_hour_Click(object sender, EventArgs e)
        {
            msk_textBox.Mask = "00:00";
            lbl_onMask.Text = "Digite a hora:";
            lbl_content.Text = "";
            msk_textBox.Clear();
            msk_textBox.Focus();
        }

        private void btn_cep_Click(object sender, EventArgs e)
        {
            msk_textBox.Mask = "000000-00";
            lbl_onMask.Text = "Digite o CEP:";
            lbl_content.Text = "";
            msk_textBox.Clear();
            msk_textBox.Focus();
        }

        private void btn_coin_Click(object sender, EventArgs e)
        {
            msk_textBox.Mask = "$ 0,000,000";
            lbl_onMask.Text = "Digite o valor:";
            lbl_content.Text = "";
            msk_textBox.Clear();
            msk_textBox.Focus();
        }

        private void btn_date_Click(object sender, EventArgs e)
        {
            msk_textBox.Mask = "00/00/0000";
            lbl_onMask.Text = "Digite a data:";
            lbl_content.Text = "";
            msk_textBox.Clear();
            msk_textBox.Focus();
        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            msk_textBox.UseSystemPasswordChar = true;
            msk_textBox.Mask = "aaaaaa";
            lbl_onMask.Text = "Senha de 6 digitos:";
            lbl_content.Text = "";
            msk_textBox.Clear();
            msk_textBox.Focus();
        }

        private void btn_tel_Click(object sender, EventArgs e)
        {
            msk_textBox.Mask = "(00) 00000 - 0000";
            lbl_onMask.Text = "Tel:";
            lbl_content.Text = "";
            msk_textBox.Clear();
            msk_textBox.Focus();
        }

        private void btn_showContent_Click(object sender, EventArgs e)
        {
            lbl_content.Text = msk_textBox.Text;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lbl_content.Text = "";
            lbl_onMask.Text = "";
            msk_textBox.Mask = "";
            msk_textBox.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
