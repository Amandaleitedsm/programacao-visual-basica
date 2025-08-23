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
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }
        float totalPedido = 0;
        int x = 1;
        string y = "";
        string produtos = "";
        string divisao = "-----------------------------------------------" + Environment.NewLine;
        string divisaoLista = "...........................................................";
        bool ativo = false;
        private void um_Click(object sender, EventArgs e)
        {
            if (ativo)
            {
                y += "1";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            } else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void dois_Click(object sender, EventArgs e)
        {
            if (ativo)
            {
                y += "2";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            }
            else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            if (ativo)
            {
                y += "3";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            }
            else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            if (ativo)
            {
                y += "4";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            }
            else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            if (ativo)
            {
                y += "5";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            }
            else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void seis_Click(object sender, EventArgs e)
        {
            if (ativo)
            {
                y += "6";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            }
            else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void sete_Click(object sender, EventArgs e)
        {
            if (ativo)
            {
                y += "7";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            }
            else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void oito_Click(object sender, EventArgs e)
        {
            if (ativo)
            {
                y += "8";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            }
            else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void nove_Click(object sender, EventArgs e)
        {
            if (ativo)
            {
                y += "9";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            }
            else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void zero_Click(object sender, EventArgs e)
        { 
            if (ativo)
            {
                y += "0";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            }
            else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (ativo)
            {
                y += ",";
                valorProduto.Text = String.Format("{0:C2}", float.Parse(y));
            }
            else
            {
                MessageBox.Show("Não é possível utilizar essa função no momento. Termine a operação em andamento.");
            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            valorCaixa.Enabled = false;
            ativo = true;
            nomeProduto.Enabled = true;
            confirmaCaixa.Visible = true;

        }

        private void enter_Click(object sender, EventArgs e)
        {
            float valorTotal = float.Parse(valorCaixa.Text);
            string produto = nomeProduto.Text;
            float preco = float.Parse(valorProduto.Text.Replace("R$" , ""));
            totalPedido += preco;
            
            valorProduto.Text = "";
            y = "";
            nomeProduto.Clear();
            confirmaProduto.Text = String.Format("Produto adicionado à lista. ({0})", x++);
            confirmaProduto.Visible = true;

            string espacos = "          ";
            string precoFormat = "R$ " + espacos.Substring(0, 7 - preco.ToString("0.00").Length) + preco.ToString("0.00");
            int tamanho = 40 - produto.Length - precoFormat.Length;
            produtos += String.Format("- {0} {1} {2}" + Environment.NewLine, produto, divisaoLista.Substring(0, tamanho), precoFormat);

            
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            ativo = true;
            totalPedido = 0;
            x = 1;
            confirmaProduto.Visible = false;
            notaFiscal.Clear();
            notaFiscal.Visible = false;
            labelNota.Visible = false;
        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            pagoCliente.Enabled = true;
            pago.Enabled = true;
            labelPago.ForeColor = Color.Black;
        }

        private void pago_Click(object sender, EventArgs e)
        {
            ativo = false;
            float vPago = float.Parse(pagoCliente.Text);
            labelPago.ForeColor = Color.DimGray;
            pagoCliente.Enabled = false;
            pago.Enabled = false;
            pagoCliente.Clear();
            if (vPago < totalPedido)
            {
                MessageBox.Show("ATENÇÃO: Valor pago é insuficiente");
            }
            else
            {
                DateTime diaHora = DateTime.Now;
                string data = String.Format(Environment.NewLine + "Data: {0}, {1}" + Environment.NewLine,
                                            diaHora.ToString("dddd"), diaHora.ToString("dd 'de' MMMM 'de' yyyy"));
                string hora = String.Format("Hora: {0}" + Environment.NewLine, diaHora.ToString("HH:mm:ss"));

                float troco = vPago - totalPedido;
                string espacos = "          ";
                string trocoStr = "R$ " + espacos.Substring(0, 7 - troco.ToString("0.00").Length) + troco.ToString("0.00");
                string pagoStr = "R$ " + espacos.Substring(0, 7 - vPago.ToString("0.00").Length) + vPago.ToString("0.00");
                string strTotal = "R$ " + espacos.Substring(0, 7 - totalPedido.ToString("0.00").Length) + totalPedido.ToString("0.00");

                int subTamanho = 40 - "SUBTOTAL".Length - strTotal.Length + 1;
                int pagoTamanho = 40 - "VALOR PAGO".Length - pagoStr.Length + 1;
                int trocoTamanho = 40 - "TROCO".Length - trocoStr.Length + 1;

                string subtotal = String.Format("SUBTOTAL: {0} {1}" + Environment.NewLine, divisaoLista.Substring(0,subTamanho), strTotal);
                string valorPago = String.Format("VALOR PAGO: {0} {1}" + Environment.NewLine, divisaoLista.Substring(0, pagoTamanho), pagoStr);
                string trocoF = String.Format("TROCO: {0} {1}" + Environment.NewLine, divisaoLista.Substring(0, trocoTamanho), trocoStr);

                notaFiscal.AppendText(divisao + "LANCHONETE DELÍCIA" + Environment.NewLine + data + hora 
                                    + divisao + Environment.NewLine + "PRODUTOS" + Environment.NewLine 
                                    + produtos + Environment.NewLine + divisao + subtotal + valorPago + trocoF 
                                    + divisao + Environment.NewLine + "OBRIGADO PELA PREFERÊNCIA!" + Environment.NewLine + divisao);


                labelNota.Visible = true;
                notaFiscal.Visible = true;

            }
        }
    }
}
