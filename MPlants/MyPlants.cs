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
    public partial class Form2 : Parent
    {
        usuarios us;
        //List<plantasUsuarios> listaPlantasUsuario;
        //List<string> listaImagens = new List<string>();
        //int indiceListe = 0;
        public Form2(Domain.usuarios usuarioLogado)
        {
            InitializeComponent();
            us = usuarioLogado;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Explore(us).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //listaPlantasUsuario = ct.plantasUsuarios.ToList();
            //preecherDatagrid(listaPlantasUsuario);
            CarregarListaPlantas();
        }

        private void CarregarListaPlantas()
        {
            flowLayoutPanel1.Controls.Clear();
            var listaPlantas = ct.plantasUsuarios.Where(u=>u.user_id == us.id).ToList();
            foreach (var plant in listaPlantas)
            {
                PlantaItemControl card = new PlantaItemControl();
                card.PreencherDados(plant);
                card.Margin = new Padding(0, 0, 0, 15);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void preecherDatagridComImagem()
        {
        }

        private void preecherDatagrid(List<plantasUsuarios> listaPlantasUsuario)
        {
            //dataGridView1.DataSource = listaPlantasUsuario.Where(i=>i.user_id == us.id).Select(u => new
            //{
            //    u.plant_name,
            //    u.age,
            //    u.description,
            //}).ToList();
        }
    }
}
