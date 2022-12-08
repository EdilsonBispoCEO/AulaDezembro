namespace Aula_08_12
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
            this.Imput = new System.Windows.Forms.TextBox();
            this.labelDigit = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.MensagemFim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Imput
            // 
            this.Imput.Location = new System.Drawing.Point(288, 81);
            this.Imput.Name = "Imput";
            this.Imput.Size = new System.Drawing.Size(148, 20);
            this.Imput.TabIndex = 0;
            this.Imput.Text = "-";
            // 
            // labelDigit
            // 
            this.labelDigit.AutoSize = true;
            this.labelDigit.Font = new System.Drawing.Font("SimSun", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigit.Location = new System.Drawing.Point(284, 48);
            this.labelDigit.Name = "labelDigit";
            this.labelDigit.Size = new System.Drawing.Size(174, 19);
            this.labelDigit.TabIndex = 1;
            this.labelDigit.Text = "Digite um nome:";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(325, 120);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 2;
            this.buttonEnviar.Text = "enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // MensagemFim
            // 
            this.MensagemFim.AutoSize = true;
            this.MensagemFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensagemFim.Location = new System.Drawing.Point(261, 159);
            this.MensagemFim.Name = "MensagemFim";
            this.MensagemFim.Size = new System.Drawing.Size(224, 25);
            this.MensagemFim.TabIndex = 3;
            this.MensagemFim.Text = "O nome digitado foi:";
            this.MensagemFim.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MensagemFim);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.labelDigit);
            this.Controls.Add(this.Imput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Imput;
        private System.Windows.Forms.Label labelDigit;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Label MensagemFim;
    }
}

