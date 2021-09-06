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
    public partial class Frm_Escritorio : Form
    {
        string usuario = "";
        string clave = "";
        int id_usuario = 0;

        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.ShowDialog();
            this.usuario = login.Pp_Usuario;
            this.clave = login.Pp_clave;
            login.Dispose();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
