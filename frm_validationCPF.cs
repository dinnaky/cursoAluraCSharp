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
    public partial class frm_validationCPF : Form
    {
        public frm_validationCPF()
        {
            InitializeComponent();
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            msk_cpf.Clear();
            lbl_result.Text = "";
        }

        private void btn_validation_Click(object sender, EventArgs e)
        {
            bool validaCPF = false;
            validaCPF = cls_uteis.Valida(msk_cpf.Text);

            if (validaCPF == true)
            {
                lbl_result.Text = "CPF VÁLIDO";
                lbl_result.ForeColor = Color.Green;
            }
            else 
            {
                lbl_result.Text = "CPF INVÁLIDO";
                lbl_result.ForeColor = Color.Red;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
