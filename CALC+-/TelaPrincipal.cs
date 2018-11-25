using CALC__.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC__
{
    public partial class TelaPrincipal : Form
    {
        List<Restricoes> restricoes = new List<Restricoes>();
        FuncaoObjetivo funObj;

        /// <summary>
        /// Construtor da aplicação
        /// </summary>
        public TelaPrincipal()
        {
            InitializeComponent();
            maximizacaoRadioButton.Checked = true;
            restricaoInequaComboBox.Items.Add(">=");
            restricaoInequaComboBox.Items.Add("<=");
            msglabel.Text = "Aplicativo Calc+- 'Versão Alpha'. Projeto disponível em:";
            linkLabel1.Text = "github.com/brunovallin/CalcPlusMinus";
            linkLabel1.Links.Add(0, 50, "https://github.com/brunovallin/CalcPlusMinus");
        }

        /// <summary>
        /// Evento que altera o nome da variável x conforme entrada do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nomeXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!nomeXTextBox.Text.Equals(string.Empty))
                nomeXLabel.Text = nomeXTextBox.Text;
            else
                nomeXLabel.Text = "X";
        }

        /// <summary>
        /// Evento que altera o nome da variavel y conforme entrada do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nomeYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!nomeYTextBox.Text.Equals(string.Empty))
                nomeYLabel.Text = nomeYTextBox.Text;
            else
                nomeYLabel.Text = "Y";
        }

        /// <summary>
        /// Método que define a função objetivo da operação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void funcaoObjetivoButton_Click(object sender, EventArgs e)
        {
            try
            {
                funObj = new FuncaoObjetivo()
                {
                    NomeVarX = nomeXTextBox.Text.Trim(),
                    NomeVarY = nomeYTextBox.Text.Trim(),
                    ValidaOperacao = maximizacaoRadioButton.Checked ? "Maximização" : "Minimização"
                };

                if (valorXTextBox.Text.Equals(""))
                {
                    throw new InvalidOperationException("Variável X não possui valor para calcular.");
                }
                funObj.ValorX = double.Parse(valorXTextBox.Text.Trim());
                if (valorYTextBox.Text.Equals(""))
                {
                    throw new InvalidOperationException("Variável Y não possui valor para calcular.");
                }
                funObj.ValorY = double.Parse(valorYTextBox.Text.Trim());

                MessageBox.Show("Função Objetivo definida com sucesso!", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método para adicionar uma restrição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRestricaoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Restricoes restricao = new Restricoes()
                {
                    ValorX = restricaoXTextBox.Text.Trim().Equals(string.Empty) ? 0.0 : double.Parse(restricaoXTextBox.Text),
                    ValorY = restricaoYTextBox.Text.Trim().Equals(string.Empty) ? 0.0 : double.Parse(restricaoYTextBox.Text),
                    Operacao = (string)restricaoInequaComboBox.SelectedItem,
                    LimiteRestricao = double.Parse(limiteRestricaoTextBox.Text.Trim())
                };
                if ((restricao.Operacao.Equals("<=") && funObj.ValidaOperacao.Equals("Minimização")) || ((restricao.Operacao.Equals(">=") && funObj.ValidaOperacao.Equals("Maximização"))))
                {
                    throw new InvalidOperationException("Restrição não compatível com a Função Objetivo");
                }
                restricao.RestricaoCompleta = string.Format("{0}x + {1}y {2} {3}", restricao.ValorX, restricao.ValorY, restricaoInequaComboBox.SelectedItem, limiteRestricaoTextBox.Text.Trim());
                foreach (var item in restricoes)
                {
                    if (item.RestricaoCompleta.Equals(restricao.RestricaoCompleta))
                    {
                        throw new InvalidOperationException("Restrição já existente.");
                    }
                }
                restricoes.Add(restricao);
                restricoesListBox.Items.Add(restricao.RestricaoCompleta);
                restricaoXTextBox.Clear();
                restricaoYTextBox.Clear();
                restricaoInequaComboBox.SelectedIndex = -1;
                limiteRestricaoTextBox.Clear();
                restricaoXTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Método que copia o resultado para a área de transferência
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyClipboarButton_Click(object sender, EventArgs e)
        {
            if (!resultadoTextBox.Text.Equals(""))
            {
                Clipboard.SetText(resultadoTextBox.Text);
            }
            else
            {
                MessageBox.Show("Não há texto para ser copiado");
            }
        }

        /// <summary>
        /// Método para resetar tudo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetOperaçãoButton_Click(object sender, EventArgs e)
        {
            try
            {
                funObj = new FuncaoObjetivo();
                restricoes.Clear();
                nomeXTextBox.Text = nomeYTextBox.Text = valorXTextBox.Text = valorYTextBox.Text = restricaoXTextBox.Text = restricaoYTextBox.Text = limiteRestricaoTextBox.Text = resultadoTextBox.Text = "";
                restricaoInequaComboBox.SelectedIndex = -1;
                restricoesListBox.Items.Clear();
                maximizacaoRadioButton.Checked = true;
                MessageBox.Show("Funções resetadas com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Método para remover uma restrição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delRestricaoButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in restricoes)
                {
                    if (item.RestricaoCompleta.Equals(restricoesListBox.SelectedItem))
                    {
                        restricoes.Remove(item);
                        restricoesListBox.Items.Remove(restricoesListBox.SelectedItem);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resolucaoDoProblemaButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultadoTextBox.Text = SolucaoOtima(funObj, restricoes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Método para resolução do problema previamente digitado
        /// </summary>
        /// <param name="f"></param>
        /// <param name="restr"></param>
        /// <returns></returns>
        public string SolucaoOtima(FuncaoObjetivo f, List<Restricoes> restr)
        {
            if (funObj == null)
            {
                throw new InvalidOperationException("Não há função objetivo definida");
            }
            double x, y, z, a;

            switch (restricoesListBox.Items.Count)
            {
                case 2:
                    a = Matriz.MatrizDeterminanteA2x2(Matriz.DefinirMatriz(restr));
                    x = Matriz.MatrizDeterminanteX2x2(Matriz.DefinirMatriz(restr)) / a;
                    y = Matriz.MatrizDeterminanteY2x2(Matriz.DefinirMatriz(restr)) / a;
                    f.X = x < 0 ? x * -1 : x;
                    f.Y = y < 0 ? y * -1 : y;
                    break;
                case 3:
                    a = Matriz.MatrizDeterminanteA3x3(Matriz.DefinirMatriz(restr));
                    x = Matriz.MatrizDeterminanteX3x3(Matriz.DefinirMatriz(restr)) / a;
                    y = Matriz.MatrizDeterminanteY3x3(Matriz.DefinirMatriz(restr)) / a;
                    f.X = x < 0 ? x * -1 : x;
                    f.Y = y < 0 ? y * -1 : y;
                    break;
                //case 4:
                //    a = Matriz.MatrizDeterminanteA4x4(Matriz.DefinirMatriz(restr));
                //    x = Matriz.MatrizDeterminanteX4x4(Matriz.DefinirMatriz(restr)) / a;
                //    y = Matriz.MatrizDeterminanteY4x4(Matriz.DefinirMatriz(restr)) / a;
                //    f.X = x < 0 ? x * -1 : x;
                //    f.Y = y < 0 ? y * -1 : y;
                //    break;
                //case 5:
                //    a = Matriz.MatrizDeterminanteA5x5(Matriz.DefinirMatriz(restr));
                //    x = Matriz.MatrizDeterminanteX5x5(Matriz.DefinirMatriz(restr)) / a;
                //    y = Matriz.MatrizDeterminanteY5x5(Matriz.DefinirMatriz(restr)) / a;
                //    f.X = x < 0 ? x * -1 : x;
                //    f.Y = y < 0 ? y * -1 : y;
                //    break;
                default:
                    a = Matriz.MatrizDeterminanteA3x3(Matriz.DefinirMatriz(restr));
                    x = Matriz.MatrizDeterminanteX3x3(Matriz.DefinirMatriz(restr)) / a;
                    y = Matriz.MatrizDeterminanteY3x3(Matriz.DefinirMatriz(restr)) / a;
                    f.X = x < 0 ? x * -1 : x;
                    f.Y = y < 0 ? y * -1 : y;
                    break;
            }
            if (maximizacaoRadioButton.Checked)
            {
                f.ValidaOperacao = "maximização";
            }
            else if (minimizacaoRadioButton.Checked)
            {
                f.ValidaOperacao = "minimização";
            }
            else
            {
                throw new InvalidOperationException("Não há operação de otimização selecionada");
            }
            f.ValorOtimo = f.ValorX * f.X + f.ValorY * f.Y;
            return string.Format("A Solução ótima desta operação será:{6}{0:n2} {1}{6}{2:n2} {3} para {4} esta operação.{6}Total:{5:n2}", f.X, f.NomeVarX, f.Y, f.NomeVarY, f.ValidaOperacao, f.ValorOtimo, Environment.NewLine);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
