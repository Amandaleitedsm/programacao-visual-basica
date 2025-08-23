using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Caixa_Simplificado_para_Lanchonete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float totalPedido = 0;
        int x = 1;
        private void um_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += "1";
            } else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void dois_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += "2";
            }
            else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += "3";
            }
            else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += "4";
            }
            else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += "5";
            }
            else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void seis_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += "6";
            }
            else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void sete_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += "7";
            }
            else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void oito_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += "8";
            }
            else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void nove_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += "9";
            }
            else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += "0";
            }
            else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                valorProduto.Text += ",";
            }
            else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            valorCaixa.Enabled = false;
            nomeProduto.Enabled = true;
            nomeProduto.Cursor = Cursors.IBeam;
            confirmaCaixa.Visible = true;

        }

        private void enter_Click(object sender, EventArgs e)
        {
            float valorTotal = float.Parse(valorCaixa.Text);
            string produto = nomeProduto.Text;
            float preco = float.Parse(valorProduto.Text);
            totalPedido += preco;

            valorProduto.Text = "";
            nomeProduto.Clear();
            confirmaProduto.Text = String.Format("Produto adicionado à lista. ({0})", x++);
            confirmaProduto.Visible = true;

        }

        private void deletar_Click(object sender, EventArgs e)
        {
            totalPedido = 0;
            x = 1;
            confirmaProduto.Visible = false;
        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(totalPedido.ToString());
        }
    }
}
