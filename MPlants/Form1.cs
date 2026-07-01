using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPlants
{
    public partial class Form1 : Parent
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var us = ct.usuarios.FirstOrDefault(u=>u.login== textBox1.Text && u.password == textBox2.Text);
            if(textBox1.Text =="" || textBox2.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            else if(us == null) {
                MessageBox.Show("Usuário ou senha incorretos!");
                return;
            }
            new Explore(us).Show();
            this.Hide();
        }
    }
}
