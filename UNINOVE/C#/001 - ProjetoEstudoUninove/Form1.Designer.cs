
namespace ProjetoEstudoUninove001
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
            this.IblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IblNome
            // 
            this.IblNome.AutoSize = true;
            this.IblNome.Location = new System.Drawing.Point(26, 40);
            this.IblNome.Name = "IblNome";
            this.IblNome.Size = new System.Drawing.Size(35, 13);
            this.IblNome.TabIndex = 0;
            this.IblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(85, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(85, 66);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(75, 23);
            this.btnMensagem.TabIndex = 2;
            this.btnMensagem.Text = "Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.IblNome);
            this.Name = "Form1";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnMensagem;
    }
}

