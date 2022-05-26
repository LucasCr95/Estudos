
namespace _013___ParametrosValorRef
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
            this.lblVarA = new System.Windows.Forms.Label();
            this.lblVarB = new System.Windows.Forms.Label();
            this.lblResA = new System.Windows.Forms.Label();
            this.lblResB = new System.Windows.Forms.Label();
            this.txtVarA = new System.Windows.Forms.TextBox();
            this.txtVarB = new System.Windows.Forms.TextBox();
            this.txtResA = new System.Windows.Forms.TextBox();
            this.txtResB = new System.Windows.Forms.TextBox();
            this.btnValor = new System.Windows.Forms.Button();
            this.btnReferencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVarA
            // 
            this.lblVarA.AutoSize = true;
            this.lblVarA.Location = new System.Drawing.Point(43, 40);
            this.lblVarA.Name = "lblVarA";
            this.lblVarA.Size = new System.Drawing.Size(41, 13);
            this.lblVarA.TabIndex = 0;
            this.lblVarA.Text = "Valor A";
            // 
            // lblVarB
            // 
            this.lblVarB.AutoSize = true;
            this.lblVarB.Location = new System.Drawing.Point(43, 76);
            this.lblVarB.Name = "lblVarB";
            this.lblVarB.Size = new System.Drawing.Size(41, 13);
            this.lblVarB.TabIndex = 1;
            this.lblVarB.Text = "Valor B";
            // 
            // lblResA
            // 
            this.lblResA.AutoSize = true;
            this.lblResA.Location = new System.Drawing.Point(43, 162);
            this.lblResA.Name = "lblResA";
            this.lblResA.Size = new System.Drawing.Size(65, 13);
            this.lblResA.TabIndex = 2;
            this.lblResA.Text = "Resultado A";
            // 
            // lblResB
            // 
            this.lblResB.AccessibleDescription = "Re";
            this.lblResB.AutoSize = true;
            this.lblResB.Location = new System.Drawing.Point(43, 201);
            this.lblResB.Name = "lblResB";
            this.lblResB.Size = new System.Drawing.Size(65, 13);
            this.lblResB.TabIndex = 3;
            this.lblResB.Text = "Resultado B";
            // 
            // txtVarA
            // 
            this.txtVarA.Location = new System.Drawing.Point(120, 40);
            this.txtVarA.Name = "txtVarA";
            this.txtVarA.Size = new System.Drawing.Size(100, 20);
            this.txtVarA.TabIndex = 4;
            // 
            // txtVarB
            // 
            this.txtVarB.Location = new System.Drawing.Point(120, 76);
            this.txtVarB.Name = "txtVarB";
            this.txtVarB.Size = new System.Drawing.Size(100, 20);
            this.txtVarB.TabIndex = 5;
            // 
            // txtResA
            // 
            this.txtResA.Location = new System.Drawing.Point(120, 162);
            this.txtResA.Name = "txtResA";
            this.txtResA.Size = new System.Drawing.Size(100, 20);
            this.txtResA.TabIndex = 6;
            // 
            // txtResB
            // 
            this.txtResB.Location = new System.Drawing.Point(120, 201);
            this.txtResB.Name = "txtResB";
            this.txtResB.Size = new System.Drawing.Size(100, 20);
            this.txtResB.TabIndex = 7;
            // 
            // btnValor
            // 
            this.btnValor.Location = new System.Drawing.Point(23, 116);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(75, 23);
            this.btnValor.TabIndex = 8;
            this.btnValor.Text = "Valor";
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // btnReferencia
            // 
            this.btnReferencia.Location = new System.Drawing.Point(163, 116);
            this.btnReferencia.Name = "btnReferencia";
            this.btnReferencia.Size = new System.Drawing.Size(75, 23);
            this.btnReferencia.TabIndex = 9;
            this.btnReferencia.Text = "Referência";
            this.btnReferencia.UseVisualStyleBackColor = true;
            this.btnReferencia.Click += new System.EventHandler(this.btnReferencia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 286);
            this.Controls.Add(this.btnReferencia);
            this.Controls.Add(this.btnValor);
            this.Controls.Add(this.txtResB);
            this.Controls.Add(this.txtResA);
            this.Controls.Add(this.txtVarB);
            this.Controls.Add(this.txtVarA);
            this.Controls.Add(this.lblResB);
            this.Controls.Add(this.lblResA);
            this.Controls.Add(this.lblVarB);
            this.Controls.Add(this.lblVarA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVarA;
        private System.Windows.Forms.Label lblVarB;
        private System.Windows.Forms.Label lblResA;
        private System.Windows.Forms.Label lblResB;
        private System.Windows.Forms.TextBox txtVarA;
        private System.Windows.Forms.TextBox txtVarB;
        private System.Windows.Forms.TextBox txtResA;
        private System.Windows.Forms.TextBox txtResB;
        private System.Windows.Forms.Button btnValor;
        private System.Windows.Forms.Button btnReferencia;
    }
}

