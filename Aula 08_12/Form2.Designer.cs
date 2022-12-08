namespace Aula_08_12
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImputTexto = new System.Windows.Forms.TextBox();
            this.tela = new System.Windows.Forms.TextBox();
            this.botaolimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImputTexto
            // 
            this.ImputTexto.Location = new System.Drawing.Point(121, 39);
            this.ImputTexto.Name = "ImputTexto";
            this.ImputTexto.Size = new System.Drawing.Size(122, 20);
            this.ImputTexto.TabIndex = 0;
            this.ImputTexto.TextChanged += new System.EventHandler(this.ImputTexto_TextChanged);
            this.ImputTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // tela
            // 
            this.tela.Location = new System.Drawing.Point(121, 83);
            this.tela.Multiline = true;
            this.tela.Name = "tela";
            this.tela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tela.Size = new System.Drawing.Size(406, 290);
            this.tela.TabIndex = 1;
            this.tela.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // botaolimpar
            // 
            this.botaolimpar.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaolimpar.Location = new System.Drawing.Point(522, 27);
            this.botaolimpar.Name = "botaolimpar";
            this.botaolimpar.Size = new System.Drawing.Size(149, 41);
            this.botaolimpar.TabIndex = 2;
            this.botaolimpar.Text = "Limpa";
            this.botaolimpar.UseVisualStyleBackColor = true;
            this.botaolimpar.Click += new System.EventHandler(this.botaolimpar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaolimpar);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.ImputTexto);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImputTexto;
        private System.Windows.Forms.TextBox tela;
        private System.Windows.Forms.Button botaolimpar;
    }
}