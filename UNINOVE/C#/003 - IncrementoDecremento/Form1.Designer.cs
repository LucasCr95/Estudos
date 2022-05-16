
namespace _003___IncrementoDecremento
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
            this.btbPre = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btbPre
            // 
            this.btbPre.Location = new System.Drawing.Point(85, 105);
            this.btbPre.Name = "btbPre";
            this.btbPre.Size = new System.Drawing.Size(75, 23);
            this.btbPre.TabIndex = 0;
            this.btbPre.Text = "Pré-Fixado";
            this.btbPre.UseVisualStyleBackColor = true;
            this.btbPre.Click += new System.EventHandler(this.btbPre_Click);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(201, 105);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(75, 23);
            this.btnPos.TabIndex = 1;
            this.btnPos.Text = "Pós-Fixado";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(67, 37);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(56, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "Valor de X";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(155, 37);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.btbPre);
            this.Name = "Form1";
            this.Text = "Operador de Incremento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbPre;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtNum;
    }
}

