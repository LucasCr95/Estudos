
namespace _010___EstruturaRepetiçãoII
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
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.btnPar = new System.Windows.Forms.Button();
            this.brnImpar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.lblSecondNum = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(12, 113);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(165, 303);
            this.listBoxNumeros.TabIndex = 0;
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(194, 133);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(75, 23);
            this.btnPar.TabIndex = 1;
            this.btnPar.Text = "Pares";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnMostrarPares_Click);
            // 
            // brnImpar
            // 
            this.brnImpar.Location = new System.Drawing.Point(194, 176);
            this.brnImpar.Name = "brnImpar";
            this.brnImpar.Size = new System.Drawing.Size(75, 23);
            this.brnImpar.TabIndex = 2;
            this.brnImpar.Text = "Impares";
            this.brnImpar.UseVisualStyleBackColor = true;
            this.brnImpar.Click += new System.EventHandler(this.brnImpar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(194, 295);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Location = new System.Drawing.Point(24, 27);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(60, 13);
            this.lblFirstNum.TabIndex = 5;
            this.lblFirstNum.Text = "Mostrar de:";
            // 
            // lblSecondNum
            // 
            this.lblSecondNum.AutoSize = true;
            this.lblSecondNum.Location = new System.Drawing.Point(58, 65);
            this.lblSecondNum.Name = "lblSecondNum";
            this.lblSecondNum.Size = new System.Drawing.Size(26, 13);
            this.lblSecondNum.TabIndex = 6;
            this.lblSecondNum.Text = "Até:";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(99, 27);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNum.TabIndex = 7;
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(99, 65);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNum.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.lblSecondNum);
            this.Controls.Add(this.lblFirstNum);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.brnImpar);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.listBoxNumeros);
            this.Name = "Form1";
            this.Text = "Exercício";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Button brnImpar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.Label lblSecondNum;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtSecondNum;
    }
}

