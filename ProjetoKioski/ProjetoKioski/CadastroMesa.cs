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
    public partial class CadastroMesa : Form
    {
        public CadastroMesa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BancoKioskiEntities bc = new BancoKioskiEntities();

            mesa m = new mesa();
            m.descricao = txtDescricao.Text;

            bc.mesas.Add(m);

            bc.SaveChanges();
            this.Close();

        }

        private void CadastroMesa_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricao.Text != string.Empty)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = string.Empty;
        }
    }
}
