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
            pnlBottom.Enabled = true;

            lblPJogador1.Text = "0 - Vitórias";
            lblPJogador2.Text = "0 - Vitórias";
            lblEmpate.Text = "0 - Empates";
        }

        private void cliqueXO(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (rbtX.Checked)
            {
                jogada = rbtX.Text;
                b.Text = jogada;
                b.Enabled = false;
                rbtO.Checked = true;
            }
            else
            {
                jogada = rbtO.Text;
                b.Text = jogada;
                b.Enabled = false;
                rbtX.Checked = true;
            }
            cont++;
            vencedorDoJogo();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            limparPartida();
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
            string jogador;

            if ((btn1.Text.Equals(btn2.Text)) && (btn2.Text.Equals(btn3.Text)) && (!btn1.Enabled))
            {
                if (lblJogador1.Text.Contains(btn1.Text))
                {
                    jogador = nJogador1;
                    pJogador1 += 1;
                    lblPJogador1.Text = $"{pJogador1.ToString()} - Vitórias";
                }
                else
                {
                    jogador = nJogador2;
                    pJogador2 += 1;
                    lblPJogador2.Text = $"{pJogador2.ToString()} - Vitórias";
                }

                MessageBox.Show($"O Jogador {jogador} Ganhou!", "Vencedor");
                limparPartida();
            }                
            else if ((btn4.Text.Equals(btn5.Text)) && (btn5.Text.Equals(btn6.Text)) && (!btn4.Enabled))
            {
                if (lblJogador1.Text.Contains(btn4.Text))
                {
                    jogador = nJogador1;
                    pJogador1 += 1;
                    lblPJogador1.Text = $"{pJogador1.ToString()} - Vitórias";
                }
                else
                {
                    jogador = nJogador2;
                    pJogador2 += 1;
                    lblPJogador2.Text = $"{pJogador2.ToString()} - Vitórias";
                }
                MessageBox.Show($"O Jogador {jogador} Ganhou!", "Vencedor");
                limparPartida();
            }                
            else if ((btn7.Text.Equals(btn8.Text)) && (btn8.Text.Equals(btn9.Text)) && (!btn7.Enabled))
            {
                if (lblJogador1.Text.Contains(btn7.Text))
                {
                    jogador = nJogador1;
                    pJogador1 += 1;
                    lblPJogador1.Text = $"{pJogador1.ToString()} - Vitórias";
                }
                else
                {
                    jogador = nJogador2;
                    pJogador2 += 1;
                    lblPJogador2.Text = $"{pJogador2.ToString()} - Vitórias";
                }
                MessageBox.Show($"O Jogador {jogador} Ganhou!", "Vencedor");
                limparPartida();
            }
            if (cont >= 9)
            {
                empates += 1;
                lblEmpate.Text = $"{empates.ToString()} - Empates";
                MessageBox.Show($"Deu Velha!!!!!", "Iiiiih!!!");
                limparPartida();
            }
        }

        public void limparPartida()
        {
            foreach (Control c in pnlBottom.Controls)
            {
                
                if (c is Button)
                {
                    Button b = (Button)c;

                    if (!"btnIniciar".Equals(b.Name) && !"btnReiniciar".Equals(b.Name) && !"btnSair".Equals(b.Name))
                    {
                        b.Text = "";
                    }
                }
                
            }
            cont = 0;
            habilitarBotoes();
        }

        public void habilitarBotoes()
        {
            foreach (Control c in pnlBottom.Controls)
            {

                if (c is Button)
                {
                    Button b = (Button)c;

                    if (!"btnIniciar".Equals(b.Name) && !"btnReiniciar".Equals(b.Name) && !"btnSair".Equals(b.Name))
                    {
                        b.Enabled = true;
                    }
                }
            }
        }
    }
}
