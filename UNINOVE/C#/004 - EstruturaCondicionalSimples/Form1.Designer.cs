
namespace _004___EstruturaCondicionalSimples
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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.btbMedia = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMediaReturn = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblSituacaoReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(95, 48);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(95, 82);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(95, 112);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(39, 13);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(95, 143);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(39, 13);
            this.lblNota4.TabIndex = 3;
            this.lblNota4.Text = "Nota 4";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(190, 48);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(190, 82);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(190, 112);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 7;
            this.txtNota3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(190, 143);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 20);
            this.txtNota4.TabIndex = 8;
            // 
            // btbMedia
            // 
            this.btbMedia.Location = new System.Drawing.Point(139, 188);
            this.btbMedia.Name = "btbMedia";
            this.btbMedia.Size = new System.Drawing.Size(75, 23);
            this.btbMedia.TabIndex = 9;
            this.btbMedia.Text = "Calcular";
            this.btbMedia.UseVisualStyleBackColor = true;
            this.btbMedia.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(98, 246);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(39, 13);
            this.lblMedia.TabIndex = 10;
            this.lblMedia.Text = "Média:";
            this.lblMedia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMediaReturn
            // 
            this.lblMediaReturn.AutoSize = true;
            this.lblMediaReturn.Location = new System.Drawing.Point(178, 245);
            this.lblMediaReturn.Name = "lblMediaReturn";
            this.lblMediaReturn.Size = new System.Drawing.Size(0, 13);
            this.lblMediaReturn.TabIndex = 11;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(98, 289);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 12;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblSituacaoReturn
            // 
            this.lblSituacaoReturn.AutoSize = true;
            this.lblSituacaoReturn.Location = new System.Drawing.Point(178, 289);
            this.lblSituacaoReturn.Name = "lblSituacaoReturn";
            this.lblSituacaoReturn.Size = new System.Drawing.Size(0, 13);
            this.lblSituacaoReturn.TabIndex = 13;
            this.lblSituacaoReturn.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.lblSituacaoReturn);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblMediaReturn);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btbMedia);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Name = "Form1";
            this.Text = "Calcular Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Button btbMedia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMediaReturn;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblSituacaoReturn;
    }
}

