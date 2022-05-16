
namespace _005___EstruturaRepeticao
{
    partial class Seleciona
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
            this.lblDia = new System.Windows.Forms.Label();
            this.diaSemanaValue = new System.Windows.Forms.NumericUpDown();
            this.btnVerDia = new System.Windows.Forms.Button();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblTxtDiaSemanaReturn = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diaSemanaValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(62, 48);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(26, 13);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dia:";
            // 
            // diaSemanaValue
            // 
            this.diaSemanaValue.Location = new System.Drawing.Point(111, 46);
            this.diaSemanaValue.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.diaSemanaValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diaSemanaValue.Name = "diaSemanaValue";
            this.diaSemanaValue.Size = new System.Drawing.Size(120, 20);
            this.diaSemanaValue.TabIndex = 1;
            this.diaSemanaValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnVerDia
            // 
            this.btnVerDia.Location = new System.Drawing.Point(65, 152);
            this.btnVerDia.Name = "btnVerDia";
            this.btnVerDia.Size = new System.Drawing.Size(75, 23);
            this.btnVerDia.TabIndex = 2;
            this.btnVerDia.Text = "Mostrar";
            this.btnVerDia.UseVisualStyleBackColor = true;
            this.btnVerDia.Click += new System.EventHandler(this.btnVerDia_Click);
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(24, 103);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaSemana.TabIndex = 3;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // lblTxtDiaSemanaReturn
            // 
            this.lblTxtDiaSemanaReturn.AutoSize = true;
            this.lblTxtDiaSemanaReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtDiaSemanaReturn.Location = new System.Drawing.Point(113, 100);
            this.lblTxtDiaSemanaReturn.Name = "lblTxtDiaSemanaReturn";
            this.lblTxtDiaSemanaReturn.Size = new System.Drawing.Size(0, 16);
            this.lblTxtDiaSemanaReturn.TabIndex = 4;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(154, 152);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Seleciona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 225);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTxtDiaSemanaReturn);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.btnVerDia);
            this.Controls.Add(this.diaSemanaValue);
            this.Controls.Add(this.lblDia);
            this.Name = "Seleciona";
            this.ShowInTaskbar = false;
            this.Text = "Seleciona Dia";
            this.Load += new System.EventHandler(this.Seleciona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diaSemanaValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.NumericUpDown diaSemanaValue;
        private System.Windows.Forms.Button btnVerDia;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblTxtDiaSemanaReturn;
        private System.Windows.Forms.Button btnFechar;
    }
}

