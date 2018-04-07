using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheasBoard
{
    public partial class Board : Form
    {
        Button btn;
        int top = 0;
        int left = 0;
        int row = 8;
        int column = 8;
        int i = 0;

        public Board()
        {
            InitializeComponent();
            this.BackColor = Color.DarkRed;
            this.Width = 8 * 75 + 17;
            this.Height = 8 * 75 + 40;

            for (row = 0; row < 8; row++)
            {
                for (column = 0; column < 8; column++)
                {

                    btn = new Button();
                    btn.Enabled = false;
                    btn.Height = 75;
                    btn.Width = 75;
                    btn.Top = top;
                    btn.Left = left;
                    btn.FlatStyle = FlatStyle.Popup;
                    Controls.Add(btn);
                    left += btn.Width;
                    if (i % 2 == 0)
                    {
                        btn.BackColor = Color.Black;
                    }
                    i++;
                }
                i++;
                top += btn.Width;
                left = 0;
            }
        }
    }
}
