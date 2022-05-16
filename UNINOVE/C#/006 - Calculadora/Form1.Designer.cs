
namespace _006___Calculadora
{
    partial class Calculadora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDividi = new System.Windows.Forms.RadioButton();
            this.rdSubtrai = new System.Windows.Forms.RadioButton();
            this.rdMultiplica = new System.Windows.Forms.RadioButton();
            this.rdSomar = new System.Windows.Forms.RadioButton();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtSegundoConjunto = new System.Windows.Forms.TextBox();
            this.txtPrimeiroConjunto = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblDois = new System.Windows.Forms.Label();
            this.lblUm = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDividi);
            this.groupBox1.Controls.Add(this.rdSubtrai);
            this.groupBox1.Controls.Add(this.rdMultiplica);
            this.groupBox1.Controls.Add(this.rdSomar);
            this.groupBox1.Location = new System.Drawing.Point(39, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 122);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdDividi
            // 
            this.rdDividi.AutoSize = true;
            this.rdDividi.Location = new System.Drawing.Point(153, 67);
            this.rdDividi.Name = "rdDividi";
            this.rdDividi.Size = new System.Drawing.Size(54, 17);
            this.rdDividi.TabIndex = 3;
            this.rdDividi.TabStop = true;
            this.rdDividi.Text = "Dividir";
            this.rdDividi.UseVisualStyleBackColor = true;
            // 
            // rdSubtrai
            // 
            this.rdSubtrai.AutoSize = true;
            this.rdSubtrai.Location = new System.Drawing.Point(38, 67);
            this.rdSubtrai.Name = "rdSubtrai";
            this.rdSubtrai.Size = new System.Drawing.Size(61, 17);
            this.rdSubtrai.TabIndex = 2;
            this.rdSubtrai.TabStop = true;
            this.rdSubtrai.Text = "Subtrair";
            this.rdSubtrai.UseVisualStyleBackColor = true;
            // 
            // rdMultiplica
            // 
            this.rdMultiplica.AutoSize = true;
            this.rdMultiplica.Location = new System.Drawing.Point(153, 29);
            this.rdMultiplica.Name = "rdMultiplica";
            this.rdMultiplica.Size = new System.Drawing.Size(72, 17);
            this.rdMultiplica.TabIndex = 1;
            this.rdMultiplica.TabStop = true;
            this.rdMultiplica.Text = "Multiplicar";
            this.rdMultiplica.UseVisualStyleBackColor = true;
            // 
            // rdSomar
            // 
            this.rdSomar.AutoSize = true;
            this.rdSomar.Checked = true;
            this.rdSomar.Location = new System.Drawing.Point(38, 29);
            this.rdSomar.Name = "rdSomar";
            this.rdSomar.Size = new System.Drawing.Size(55, 17);
            this.rdSomar.TabIndex = 0;
            this.rdSomar.TabStop = true;
            this.rdSomar.Text = "Somar";
            this.rdSomar.UseVisualStyleBackColor = true;
            this.rdSomar.CheckedChanged += new System.EventHandler(this.rdSomar_CheckedChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(123, 98);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 15;
            // 
            // txtSegundoConjunto
            // 
            this.txtSegundoConjunto.Location = new System.Drawing.Point(123, 53);
            this.txtSegundoConjunto.Name = "txtSegundoConjunto";
            this.txtSegundoConjunto.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoConjunto.TabIndex = 14;
            // 
            // txtPrimeiroConjunto
            // 
            this.txtPrimeiroConjunto.Location = new System.Drawing.Point(123, 27);
            this.txtPrimeiroConjunto.Name = "txtPrimeiroConjunto";
            this.txtPrimeiroConjunto.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeiroConjunto.TabIndex = 13;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(59, 98);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblDois
            // 
            this.lblDois.AutoSize = true;
            this.lblDois.Location = new System.Drawing.Point(77, 53);
            this.lblDois.Name = "lblDois";
            this.lblDois.Size = new System.Drawing.Size(40, 13);
            this.lblDois.TabIndex = 11;
            this.lblDois.Text = "Digite: ";
            // 
            // lblUm
            // 
            this.lblUm.AutoSize = true;
            this.lblUm.Location = new System.Drawing.Point(77, 27);
            this.lblUm.Name = "lblUm";
            this.lblUm.Size = new System.Drawing.Size(40, 13);
            this.lblUm.TabIndex = 10;
            this.lblUm.Text = "Digite: ";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(217, 296);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(123, 296);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(39, 296);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 17;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 358);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtSegundoConjunto);
            this.Controls.Add(this.txtPrimeiroConjunto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDois);
            this.Controls.Add(this.lblUm);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcula);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDividi;
        private System.Windows.Forms.RadioButton rdSubtrai;
        private System.Windows.Forms.RadioButton rdMultiplica;
        private System.Windows.Forms.RadioButton rdSomar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtSegundoConjunto;
        private System.Windows.Forms.TextBox txtPrimeiroConjunto;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblDois;
        private System.Windows.Forms.Label lblUm;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcula;
    }
}

