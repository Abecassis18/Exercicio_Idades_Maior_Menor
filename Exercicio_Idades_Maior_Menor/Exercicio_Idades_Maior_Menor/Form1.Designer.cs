namespace Exercicio_Idades_Maior_Menor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantPessoas = new System.Windows.Forms.Label();
            this.lblMediaIdades = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPessoaMaisVelha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPessoaMaisNova = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NotificacaoInicial = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(95, 14);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(212, 12);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(94, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira a Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade de Pessoas Inseridas";
            // 
            // lblQuantPessoas
            // 
            this.lblQuantPessoas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantPessoas.Location = new System.Drawing.Point(219, 35);
            this.lblQuantPessoas.Name = "lblQuantPessoas";
            this.lblQuantPessoas.Size = new System.Drawing.Size(37, 21);
            this.lblQuantPessoas.TabIndex = 4;
            this.lblQuantPessoas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMediaIdades
            // 
            this.lblMediaIdades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMediaIdades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMediaIdades.Location = new System.Drawing.Point(219, 67);
            this.lblMediaIdades.Name = "lblMediaIdades";
            this.lblMediaIdades.Size = new System.Drawing.Size(37, 21);
            this.lblMediaIdades.TabIndex = 6;
            this.lblMediaIdades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Média das Idades Inseridas";
            // 
            // lblPessoaMaisVelha
            // 
            this.lblPessoaMaisVelha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPessoaMaisVelha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPessoaMaisVelha.Location = new System.Drawing.Point(219, 101);
            this.lblPessoaMaisVelha.Name = "lblPessoaMaisVelha";
            this.lblPessoaMaisVelha.Size = new System.Drawing.Size(37, 21);
            this.lblPessoaMaisVelha.TabIndex = 8;
            this.lblPessoaMaisVelha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Idade da Pessoa mais Velha";
            // 
            // lblPessoaMaisNova
            // 
            this.lblPessoaMaisNova.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPessoaMaisNova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPessoaMaisNova.Location = new System.Drawing.Point(219, 134);
            this.lblPessoaMaisNova.Name = "lblPessoaMaisNova";
            this.lblPessoaMaisNova.Size = new System.Drawing.Size(37, 21);
            this.lblPessoaMaisNova.TabIndex = 10;
            this.lblPessoaMaisNova.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Idade da Pessoa mais Nova";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(212, 253);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(94, 23);
            this.btnEncerrar.TabIndex = 11;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblQuantPessoas);
            this.groupBox1.Controls.Add(this.lblPessoaMaisNova);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblMediaIdades);
            this.groupBox1.Controls.Add(this.lblPessoaMaisVelha);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 181);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculo Idades";
            // 
            // NotificacaoInicial
            // 
            this.NotificacaoInicial.Icon = ((System.Drawing.Icon)(resources.GetObject("NotificacaoInicial.Icon")));
            this.NotificacaoInicial.Text = "notifyIcon1";
            this.NotificacaoInicial.Visible = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnInserir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtIdade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Exercicio Idades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuantPessoas;
        private System.Windows.Forms.Label lblMediaIdades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPessoaMaisVelha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPessoaMaisNova;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon NotificacaoInicial;
    }
}

