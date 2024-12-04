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
    public partial class frm_messageBox : Form
    {
        public frm_messageBox()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            msk_cpf.Clear();
        }

        private void btn_validation_Click(object sender, EventArgs e)
        {
            string vContent;
            vContent = msk_cpf.Text;
            vContent = vContent.Replace(".", "").Replace("-", "");
            vContent = vContent.Trim();

            if (vContent.Length < 11) {
                MessageBox.Show("CPF PRECISA TER 11 DIGITOS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (vContent == "")
            {
                MessageBox.Show("INSIRA O CPF ANTES DA VALIDAÇÃO!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (MessageBox.Show("Você deseja validar o CPF?", "Validação de CPF",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bool validaCPF = false;
                validaCPF = cls_uteis.Valida(msk_cpf.Text);
                if (validaCPF == true)
                {
                    MessageBox.Show("CPF VÁLIDO", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CPF INVÁLIDO", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cancelando validação!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
