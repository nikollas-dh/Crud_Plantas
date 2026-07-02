using MPlants.Domain;
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
    public partial class Explore : Parent
    {
        List<plantas> listaPlantas = new List<plantas>();
        usuarios usuarioLogado;
        public Explore(usuarios us)
        {
            InitializeComponent();
            usuarioLogado = us;
        }

        private void Explore_Load(object sender, EventArgs e)
        {
            listaPlantas = ct.plantas.ToList();
            preencherDataGrid(listaPlantas);
        }

        private void preencherDataGrid(List<plantas> lista)
        {
            dataGridView1.DataSource = lista.Select(u => new
            {
                Id = u.id,
                Nome = u.name,
                Descrição =  u.description
            }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2(usuarioLogado).Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string termo = textBox1.Text.ToLower();

            var listaFiltrada = listaPlantas.Where(u=>u.name.ToLower().Contains(termo)).ToList();
            preencherDataGrid(listaFiltrada);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridView1[0, e.RowIndex].Value;
            new Modal((int)id).Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label13.Text);
        }

        private void PesquisaPorLetra(string text)
        {
            string letra = text;

            var listaLetra = listaPlantas.Where(u => u.name.StartsWith(letra, StringComparison.OrdinalIgnoreCase)).ToList();

            preencherDataGrid(listaLetra);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label14.Text);

        }

        private void label15_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label15.Text);

        }

        private void label16_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label16.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label1.Text);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label2.Text);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label3.Text);

        }

        private void label4_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label4.Text);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label5.Text);

        }

        private void label6_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label6.Text);

        }

        private void label7_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label7.Text);

        }

        private void label8_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label8.Text);

        }

        private void label9_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label9.Text);

        }

        private void label10_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label10.Text);

        }

        private void label11_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label11.Text);

        }

        private void label12_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label12.Text);

        }

        private void label19_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label19.Text);

        }

        private void label21_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label21.Text);

        }

        private void label17_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label17.Text);

        }

        private void label18_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label18.Text);

        }

        private void label20_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label20.Text);

        }

        private void label22_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label22.Text);

        }

        private void label23_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label23.Text);

        }

        private void label24_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label24.Text);

        }

        private void label25_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label25.Text);

        }

        private void label26_Click(object sender, EventArgs e)
        {
            preencherDataGrid(listaPlantas);
        }

        private void label27_Click(object sender, EventArgs e)
        {
            PesquisaPorLetra(label27.Text);

        }
    }
}
