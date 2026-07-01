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
    public partial class Parent : Form
    {
        public PlantsDatabaseEntities ct = new PlantsDatabaseEntities();
        public Parent()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Parent_Load(object sender, EventArgs e)
        {

        }
    }
}
