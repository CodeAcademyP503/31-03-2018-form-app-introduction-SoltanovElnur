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
    public partial class CinemaHall : Form
    {
        public static List<int> melumatlar = new List<int>();
        Button hallSeat = new Button();
        ComboBox seans = new ComboBox();
        Label lb = new Label();
        Button rezerv = new Button();
        Button YR = new Button();
        public CinemaHall()
        {
            InitializeComponent();
            Seats();
            Seans();
            lbSeans();
            Rezerv();
            YeniRezerv();
        }
        public void Seats()
        {
            int i = 1;
            int top = 100;
            int left = 180;
            int row = 0;
            int column = 0;
            int k = 11;
            

            for (row = 0; row < 4; row++)
            {
                
                for (column = 0; column < k; column++)
                {
                    hallSeat = new Button();
                    hallSeat.Text = i.ToString();
                    hallSeat.BackColor = Color.Red;
                    hallSeat.Width = 40;
                    hallSeat.Height = 40;
                    hallSeat.Top = top;
                    hallSeat.Left = left;
                    hallSeat.Click += new EventHandler(click);
                    Controls.Add(hallSeat);
                    i++;
                    left += hallSeat.Width;
                    
                }
                k++;
                top += hallSeat.Height;
                left -= hallSeat.Width * k - (hallSeat.Width / 2);
                

            }
            

        }
        public void click(object obj, EventArgs e)
        { 
            Button clc = obj as Button;
            if (clc.BackColor == Color.Red)
            {
                
                clc.BackColor = Color.Green;
                melumatlar.Add(Convert.ToInt32(clc.Text));

            }
            else
            {
                clc.BackColor = Color.Red;
                melumatlar.Remove(Convert.ToInt32(clc.Text));
                
            }



        }
        public void lbSeans()
        {
            lb = new Label();
            lb.Text = "Vaxti secin: ";
            lb.BackColor = Color.Transparent;
            lb.Width = 70;
            lb.Height = 20;
            lb.Top = 303;
            lb.Left = 150;
            Controls.Add(lb);
        }
        public void Seans()
        {
            seans = new ComboBox();
            seans.Width = 150;
            seans.Height = 20;
            seans.Top = 300;
            seans.Left = 220;
            Controls.Add(seans);
            this.seans.Items.AddRange(new object[] {
            "Saat: 11:00",
            "Saat: 13:00",
            "Saat: 15:00",
            "Saat: 18:00",
            "Saat: 21:00"});
        }

        public void Rezerv()
        {
            rezerv = new Button();
            rezerv.Text = "Rezerv Et";
            rezerv.BackColor = Color.Chocolate;
            rezerv.Width = 150;
            rezerv.Height = 22;
            rezerv.Top = 300;
            rezerv.Left = 450;
            Controls.Add(rezerv);
            rezerv.Click+=new EventHandler (click_rezerv);
        }
        public void click_rezerv(object obj, EventArgs es)
        {
            string seatCount = "";
            foreach (var item in melumatlar)
            {
                seatCount += item + " , "; 
            }
            MessageBox.Show("Yerler: " + seatCount);
        }
        public void YeniRezerv()
        {
            YR = new Button();
            YR.Text = "Yeni Rezervasion";
            YR.BackColor = Color.Chocolate;
            YR.Width = 200;
            YR.Height = 25;
            YR.Top = 350;
            YR.Left = 310;
            YR.Click += new EventHandler(yr);
            Controls.Add(YR);
        }
        public void yr(object obj, EventArgs e)
        {
            InterFace clcYR = new InterFace();
            clcYR.Show();
            this.Close();
        }

          
        
        
    }
}
