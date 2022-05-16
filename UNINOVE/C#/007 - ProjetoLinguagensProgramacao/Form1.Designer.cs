
namespace _007___ProjetoLinguagensProgramacao
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
            this.cbAnimais = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbAnimais
            // 
            this.cbAnimais.FormattingEnabled = true;
            this.cbAnimais.Items.AddRange(new object[] {
            "HTML5",
            "CSS3",
            "JavaScript",
            "Java",
            "PHP",
            "C#"});
            this.cbAnimais.Location = new System.Drawing.Point(64, 41);
            this.cbAnimais.Name = "cbAnimais";
            this.cbAnimais.Size = new System.Drawing.Size(121, 21);
            this.cbAnimais.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.cbAnimais);
            this.Name = "Form1";
            this.Text = "Linguagens Programação";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAnimais;
    }
}

