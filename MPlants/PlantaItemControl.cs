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
    public partial class PlantaItemControl : UserControl
    {
        private int id;
        public PlantaItemControl()
        {
            InitializeComponent();
            
        }

        private void PlantaItemControl_Load(object sender, EventArgs e)
        {

        }

        public void PreencherDados(plantasUsuarios plantas)
        {
            id = plantas.id;

            label1.Text = plantas.plant_name;
            label2.Text = plantas.description;
            label3.Text = plantas.age.ToString();

            string caminhoImagem = $"Imagens/{id}.jpg";

            if (System.IO.File.Exists(caminhoImagem)) { 
                pictureBox1.Image = Image.FromFile(caminhoImagem);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
    }
}
