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
    public partial class Modal : Form
    {
        plantas p;
        PlantsDatabaseEntities ct = new PlantsDatabaseEntities();
     
        public Modal(int id)
        {
            InitializeComponent();
            var planta = ct.plantas.Where(u=>u.id == id).FirstOrDefault();
            p = planta;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Modal_Load(object sender, EventArgs e)
        {
            label1.Text = p.name;
            label2.Text = ct.plantas.Where(u => u.id == p.id).Select(s => s.TformatoFolha.name).FirstOrDefault();
            label3.Text = ct.plantas.Where(u => u.id == p.id).Select(s => s.TtipoFlor.name).FirstOrDefault();
            label4.Text = ct.plantas.Where(u => u.id == p.id).Select(s => s.TtipoFruta.name).FirstOrDefault();
            label4.Text = ct.plantas.Where(u => u.id == p.id).Select(s => s.TtipoHaste.name).FirstOrDefault();
            label5.Text = p.description;
            PreecncherPictureBox();
        }

        private void PreecncherPictureBox()
        {
            int i = p.id;
            if (System.IO.File.Exists($"Imagens/{i}.jpg"))
            {
                pictureBox1.Image = Image.FromFile($"Imagens/{i}.jpg");
            }
        }
    }
}
