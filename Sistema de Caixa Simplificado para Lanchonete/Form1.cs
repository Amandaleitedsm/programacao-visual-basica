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
        string y = "";
        string Valor = "";
        private void um_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                y += "1";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            } else
            {
                MessageBox.Show("Não há valor de caixa!");
            }
        }

        private void dois_Click(object sender, EventArgs e)
        {
            if (!valorCaixa.Enabled)
            {
                y += "2";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
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
                y += "3";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
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
                y += "4";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
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
                y += "5";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
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
                y += "6";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
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
                y += "7";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
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
                y += "8";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
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
                y += "9";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
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
                y += "0";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
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
                y += ",";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
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
            confirmaCaixa.Visible = true;

        }

        private void enter_Click(object sender, EventArgs e)
        {
            float valorTotal = float.Parse(valorCaixa.Text);
            string produto = nomeProduto.Text;
            float preco = float.Parse(valorProduto.Text.Replace("R$" , "").Trim());
            totalPedido += preco;

            valorProduto.Text = "";
            y = "";
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
            pagoCliente.Enabled = true;
        }

        private void pago_Click(object sender, EventArgs e)
        {
            float troco = totalPedido - float.Parse(pagoCliente.Text);
            if (float.Parse(pagoCliente.Text) < totalPedido)
            {
                MessageBox.Show("ATENÇÃO: Valor pago é insuficiente");
            }
            else
            {
                string divisao = "------------------------------------------------------------";
                notaFiscal.AppendText(divisao + Environment.NewLine + "LANCHONETE DELÍCIA" + Environment.NewLine);

                labelNota.Visible = true;
                notaFiscal.Visible = true;
            }
        }
    }
}
