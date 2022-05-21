
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cboLinguagens = new System.Windows.Forms.ComboBox();
            this.pctLinguagens = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLinguagens)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(82, 86);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(162, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cboLinguagens
            // 
            this.cboLinguagens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLinguagens.FormattingEnabled = true;
            this.cboLinguagens.Location = new System.Drawing.Point(52, 41);
            this.cboLinguagens.Name = "cboLinguagens";
            this.cboLinguagens.Size = new System.Drawing.Size(222, 21);
            this.cboLinguagens.Sorted = true;
            this.cboLinguagens.TabIndex = 0;
            this.cboLinguagens.SelectedIndexChanged += new System.EventHandler(this.cboLinguagens_SelectedIndexChanged);
            // 
            // pctLinguagens
            // 
            this.pctLinguagens.Location = new System.Drawing.Point(52, 175);
            this.pctLinguagens.Name = "pctLinguagens";
            this.pctLinguagens.Size = new System.Drawing.Size(222, 174);
            this.pctLinguagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLinguagens.TabIndex = 2;
            this.pctLinguagens.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 361);
            this.Controls.Add(this.pctLinguagens);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cboLinguagens);
            this.Name = "Form1";
            this.Text = "Linguagens Programação";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLinguagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cboLinguagens;
        private System.Windows.Forms.PictureBox pctLinguagens;
    }
}

