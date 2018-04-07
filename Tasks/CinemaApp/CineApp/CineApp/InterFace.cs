using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineApp
{
    public partial class InterFace : Form
    {
        public InterFace()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            CinemaHall hall = new CinemaHall();
            hall.Show();
            

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            CinemaHall hall = new CinemaHall();
            hall.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CinemaHall hall = new CinemaHall();
            hall.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CinemaHall hall = new CinemaHall();
            hall.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CinemaHall hall = new CinemaHall();
            hall.Show();
        }

    }
}
