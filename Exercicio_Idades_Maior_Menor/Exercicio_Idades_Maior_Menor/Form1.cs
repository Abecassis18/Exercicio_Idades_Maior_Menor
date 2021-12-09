using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Idades_Maior_Menor
{
    public partial class Form1 : Form
    {
       public int saidaIdade = 0;
       public int pessoaMaisVelha, idadeInserida = 0;
       public int pessoaMaisNova;
       public int quantPessoas = 0;
       public int somaIdades = 0;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            NotificacaoInicial.Visible = true;
            NotificacaoInicial.BalloonTipText = "Está Rodando";
            NotificacaoInicial.ShowBalloonTip(6000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIdade.Focus();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {   
            if (txtIdade.Text != "")
            {
                idadeInserida = int.Parse(txtIdade.Text);// O Primeiro a se fazer é puxar a idade da Interface.

                bool validarIdade = int.TryParse(txtIdade.Text, out saidaIdade);
                if(validarIdade == true && idadeInserida > 0)//O fluxo de quebra começa aqui se não ele nao consegue achar a menor idade
                {
                    quantPessoas++; // Incrementamos logo a quantidade de pessoas.

                    if(quantPessoas == 1)//Pra iniciar as variáveis das pessoas mais vekhas e novas tem que a primeira pessoa ter indicado uma idade.
                    {
                        pessoaMaisVelha = idadeInserida;
                        pessoaMaisNova = idadeInserida; 
                    }                    
                     
                    if(idadeInserida > pessoaMaisVelha)
                    {                        
                        pessoaMaisVelha = idadeInserida;                        
                    }
                    if(idadeInserida < pessoaMaisNova) 
                    {
                        pessoaMaisNova = idadeInserida;
                                               
                    }

                    somaIdades += idadeInserida;
                    
                    lblQuantPessoas.Text = quantPessoas.ToString();
                    lblMediaIdades.Text = ((double)somaIdades / (double)quantPessoas).ToString();
                    lblPessoaMaisVelha.Text = pessoaMaisVelha.ToString();
                    lblPessoaMaisNova.Text = pessoaMaisNova.ToString();

                    txtIdade.Clear();
                    txtIdade.Focus();
                }          
                else MessageBox.Show("Insira uma idade válida", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}