using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoKioski
{
    public partial class Principal : Form
    {
        
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMesa m1 = new CadastroMesa();
            m1.ShowDialog();

        }
    }
}
