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
        string nJogador1, nJogador2, jogada;
        int cont = 0, pJogador1 = 0, pJogador2 = 0, empates = 0;

        public FrmJogoDaVelha()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            nJogador1 = txtJogador1.Text;
            txtJogador1.Visible = false;
            lblJogador1.Text = $"{nJogador1} -> [ Joga com ";
            lblJogador1.Font = new Font(lblJogador1.Font, FontStyle.Bold | FontStyle.Italic);

            nJogador2 = txtJogador2.Text;
            txtJogador2.Visible = false;
            lblJogador2.Text = $"{nJogador2} -> [ Joga com ";
            lblJogador2.Font = new Font(lblJogador2.Font, FontStyle.Bold | FontStyle.Italic);

            if (rbtX.Checked)
            {
                lblJogador1.Text += " X ]";
                lblJogador2.Text += " O ]";
            }
            else
            {
                lblJogador1.Text += " O ]";
                lblJogador2.Text += " X ]";
            }

            gbxOpcoes.Enabled = false;
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

        public void vencedorDoJogo()
        {

        }

        public void limparPartida()
        {
            foreach (Button b in Controls.OfType<Button>())
            {
                if (!"btnIniciar".Equals(b.Name) && !"btnReiniciar".Equals(b.Name) && !"btnSair".Equals(b.Name))
                {
                    b.Text = "";
                }
                
            }
        }

        public void habilitarBotoes()
        {
            foreach (Button b in Controls.OfType<Button>())
            {
                if (!"btnIniciar".Equals(b.Name) && !"btnReiniciar".Equals(b.Name) && !"btnSair".Equals(b.Name))
                {
                    b.Enabled = true;
                }

            }
        }
    }
}
