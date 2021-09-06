using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionElAleman
{
    public partial class Frm_Login : Form
    {
        public string Pp_Usuario
        {
            get { return this.txt_Usuario.Text; }
            set { this.txt_Usuario.Text = value; }
        }
        public string Pp_clave
        {
            get { return this.txt_clave.Text; }
            set { this.txt_clave.Text = value; }
        }

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
