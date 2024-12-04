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
    public partial class frm_helloWorld : Form
    {
        public frm_helloWorld()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (lbl_title.Text == "Visual Studio .NET Version")
            //{
            //    this.lbl_title.Text = "Opa, deu certo eu acho";
            //}
            //else
            //{
            //    this.lbl_title.Text = "Visual Studio .NET Version";
            //}

            if (txt_contentLbl.Text == "")
            {
                this.lbl_title.Text = "DIGITE";
            } else
            {
                this.lbl_title.Text = txt_contentLbl.Text;
            }
        }
    }
}
