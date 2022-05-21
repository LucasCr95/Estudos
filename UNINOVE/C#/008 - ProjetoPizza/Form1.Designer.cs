
namespace _008___ProjetoPizza
{
    partial class Pizza
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
            this.lblSabores = new System.Windows.Forms.Label();
            this.cboSabores = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAzeitona = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbComBorda = new System.Windows.Forms.RadioButton();
            this.rdbSemBorda = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSabores
            // 
            this.lblSabores.AutoSize = true;
            this.lblSabores.Location = new System.Drawing.Point(34, 44);
            this.lblSabores.Name = "lblSabores";
            this.lblSabores.Size = new System.Drawing.Size(46, 13);
            this.lblSabores.TabIndex = 0;
            this.lblSabores.Text = "Sabores";
            // 
            // cboSabores
            // 
            this.cboSabores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabores.FormattingEnabled = true;
            this.cboSabores.Location = new System.Drawing.Point(93, 44);
            this.cboSabores.Name = "cboSabores";
            this.cboSabores.Size = new System.Drawing.Size(121, 21);
            this.cboSabores.TabIndex = 1;
            this.cboSabores.SelectedIndexChanged += new System.EventHandler(this.cboSabores_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAzeitona);
            this.groupBox1.Controls.Add(this.chkCebola);
            this.groupBox1.Location = new System.Drawing.Point(37, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcional";
            // 
            // chkAzeitona
            // 
            this.chkAzeitona.AutoSize = true;
            this.chkAzeitona.Location = new System.Drawing.Point(6, 57);
            this.chkAzeitona.Name = "chkAzeitona";
            this.chkAzeitona.Size = new System.Drawing.Size(67, 17);
            this.chkAzeitona.TabIndex = 1;
            this.chkAzeitona.Text = "Azeitona";
            this.chkAzeitona.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(6, 34);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(59, 17);
            this.chkCebola.TabIndex = 0;
            this.chkCebola.Text = "Cebola";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbComBorda);
            this.groupBox2.Controls.Add(this.rdbSemBorda);
            this.groupBox2.Location = new System.Drawing.Point(37, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borda";
            // 
            // rdbComBorda
            // 
            this.rdbComBorda.AutoSize = true;
            this.rdbComBorda.Location = new System.Drawing.Point(6, 57);
            this.rdbComBorda.Name = "rdbComBorda";
            this.rdbComBorda.Size = new System.Drawing.Size(130, 17);
            this.rdbComBorda.TabIndex = 1;
            this.rdbComBorda.TabStop = true;
            this.rdbComBorda.Text = "Com Borda Recheada";
            this.rdbComBorda.UseVisualStyleBackColor = true;
            // 
            // rdbSemBorda
            // 
            this.rdbSemBorda.AutoSize = true;
            this.rdbSemBorda.Location = new System.Drawing.Point(6, 34);
            this.rdbSemBorda.Name = "rdbSemBorda";
            this.rdbSemBorda.Size = new System.Drawing.Size(130, 17);
            this.rdbSemBorda.TabIndex = 0;
            this.rdbSemBorda.TabStop = true;
            this.rdbSemBorda.Text = "Sem Borda Recheada";
            this.rdbSemBorda.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(37, 310);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(139, 310);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 391);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboSabores);
            this.Controls.Add(this.lblSabores);
            this.Name = "Pizza";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Pizza_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSabores;
        private System.Windows.Forms.ComboBox cboSabores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAzeitona;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbComBorda;
        private System.Windows.Forms.RadioButton rdbSemBorda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

