using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosaic3
{
    public partial class Mosaic : Form
    {
        public Mosaic()
        {
            InitializeComponent();
        }

        private void Mosaic_Load(object sender, EventArgs e)
        {

        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dashoard");
        }

        private void UserProfile_Click(object sender, EventArgs e)
        {
             MessageBox.Show(typeof(Mosaic).FullName);
        }
    }
}
