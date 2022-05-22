
namespace _011___EstruturaRepetiçãoIII
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblValorX = new System.Windows.Forms.Label();
            this.lblValorY = new System.Windows.Forms.Label();
            this.txtValorX = new System.Windows.Forms.TextBox();
            this.txtValorY = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.ltbLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Identificar números pares e fazer a soma, dentro do intervalo proposto.";
            // 
            // lblValorX
            // 
            this.lblValorX.AutoSize = true;
            this.lblValorX.Location = new System.Drawing.Point(37, 67);
            this.lblValorX.Name = "lblValorX";
            this.lblValorX.Size = new System.Drawing.Size(24, 13);
            this.lblValorX.TabIndex = 1;
            this.lblValorX.Text = "De:";
            // 
            // lblValorY
            // 
            this.lblValorY.AutoSize = true;
            this.lblValorY.Location = new System.Drawing.Point(35, 115);
            this.lblValorY.Name = "lblValorY";
            this.lblValorY.Size = new System.Drawing.Size(26, 13);
            this.lblValorY.TabIndex = 2;
            this.lblValorY.Text = "Até:";
            // 
            // txtValorX
            // 
            this.txtValorX.Location = new System.Drawing.Point(86, 67);
            this.txtValorX.Name = "txtValorX";
            this.txtValorX.Size = new System.Drawing.Size(100, 20);
            this.txtValorX.TabIndex = 3;
            // 
            // txtValorY
            // 
            this.txtValorY.Location = new System.Drawing.Point(86, 115);
            this.txtValorY.Name = "txtValorY";
            this.txtValorY.Size = new System.Drawing.Size(100, 20);
            this.txtValorY.TabIndex = 4;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(251, 67);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(251, 115);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(217, 160);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 7;
            // 
            // ltbLista
            // 
            this.ltbLista.FormattingEnabled = true;
            this.ltbLista.Location = new System.Drawing.Point(38, 160);
            this.ltbLista.Name = "ltbLista";
            this.ltbLista.Size = new System.Drawing.Size(148, 251);
            this.ltbLista.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.ltbLista);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtValorY);
            this.Controls.Add(this.txtValorX);
            this.Controls.Add(this.lblValorY);
            this.Controls.Add(this.lblValorX);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Soma Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValorX;
        private System.Windows.Forms.Label lblValorY;
        private System.Windows.Forms.TextBox txtValorX;
        private System.Windows.Forms.TextBox txtValorY;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox ltbLista;
    }
}

