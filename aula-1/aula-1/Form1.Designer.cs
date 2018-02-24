namespace aula_1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPrimeiroNumero = new System.Windows.Forms.Label();
            this.txbPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.txbSegundoNumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.AutoSize = true;
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(191, 68);
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(120, 13);
            this.lblPrimeiroNumero.TabIndex = 2;
            this.lblPrimeiroNumero.Text = "Digite o primeiro número";
            this.lblPrimeiroNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbPrimeiroNumero
            // 
            this.txbPrimeiroNumero.Location = new System.Drawing.Point(191, 84);
            this.txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            this.txbPrimeiroNumero.Size = new System.Drawing.Size(185, 20);
            this.txbPrimeiroNumero.TabIndex = 3;
            this.txbPrimeiroNumero.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(191, 124);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(125, 13);
            this.lblSegundoNumero.TabIndex = 4;
            this.lblSegundoNumero.Text = "Digite o segundo número";
            // 
            // txbSegundoNumero
            // 
            this.txbSegundoNumero.Location = new System.Drawing.Point(191, 140);
            this.txbSegundoNumero.Name = "txbSegundoNumero";
            this.txbSegundoNumero.Size = new System.Drawing.Size(185, 20);
            this.txbSegundoNumero.TabIndex = 6;
            this.txbSegundoNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(306, 209);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(192, 180);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(44, 33);
            this.btnSoma.TabIndex = 8;
            this.btnSoma.Text = "+";
            this.toolTip1.SetToolTip(this.btnSoma, "Clique aqui sua besta");
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(242, 180);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(44, 30);
            this.btnDivisao.TabIndex = 9;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(192, 216);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(44, 31);
            this.btnSubtracao.TabIndex = 10;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(242, 215);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(44, 31);
            this.btnMultiplicacao.TabIndex = 11;
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // frmPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(555, 367);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbSegundoNumero);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.txbPrimeiroNumero);
            this.Controls.Add(this.lblPrimeiroNumero);
            this.Name = "frmPrincipal";
            this.Text = "&SOMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNumero;
        private System.Windows.Forms.TextBox txbPrimeiroNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.TextBox txbSegundoNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;

    }
}

