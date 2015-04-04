using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 90; i < 390; i++)
            {

                int aux = Convert.ToInt32(Math.Round(Math.Sin(i / 4) * 3)) + 100;
                Brush aBrush = (Brush)Brushes.Cyan;
                Graphics g = this.CreateGraphics();
                g.FillRectangle(aBrush, i, aux, 1, 1);

                for (int j = aux + 2 + 1; j < 260; j++)
                {
                    Brush bBrush = (Brush)Brushes.Blue;
                    Graphics h = this.CreateGraphics();
                    h.FillRectangle(bBrush, i, j, 1, 1);


                }

            }
        }
    }
}
