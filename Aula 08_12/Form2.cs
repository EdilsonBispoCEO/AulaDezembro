using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_08_12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            tela.AppendText("\r\n" + "Pressione a Tecla: " + e.KeyCode);
            tela.AppendText("\r\n" + "\t" +  "Codigo da Tecla: " + ((int)e.KeyCode));
        }

        private void ImputTexto_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void botaolimpar_Click(object sender, EventArgs e)
        {
            botaolimpar.Text + false;    
        }
    }
}
