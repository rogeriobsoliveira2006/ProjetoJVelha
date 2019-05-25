using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJVelha
{
    public partial class FrmJogoDaVelha : Form
    {
        public FrmJogoDaVelha()
        {
            InitializeComponent();
        }

        private void FrmJogoDaVelha_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msgAviso = "Deseja fechar o aplicativo Jogo da Velha?";

            if (MessageBox.Show(msgAviso, "Aviso | Jogo da Velha!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
