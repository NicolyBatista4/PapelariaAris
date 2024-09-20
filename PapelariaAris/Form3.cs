using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapelariaAris
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1 + " Sua conta foi criada com sucesso!");

            this.Visible = false;
            Form4 tela5 = new Form4();
            tela5.ShowDialog();
            this.Visible = true;
        
    }
    }
}
