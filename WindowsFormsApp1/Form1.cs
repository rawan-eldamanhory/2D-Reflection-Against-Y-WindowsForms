using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//2D Reflection against Y
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //shape points
        private PointF[] points = { new PointF(300, 100), new PointF(400, 100), new PointF(350, 200) };
        private PointF[] newPoints = new PointF[3];

        //reflection against Y
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.Blue);

            // Draw the initial shape
            g.DrawPolygon(pen1, points);

            for (int i = 0; i < 3; i++)
            {
                float x = points[i].X - 210;
                float y = points[i].Y - 210;
                newPoints[i].X = (float)(-x);
                newPoints[i].Y = (float)(y);
                newPoints[i].X += 210;
                newPoints[i].Y += 210;
            }

            // Draw the shape after reflection
            g.DrawPolygon(pen2, newPoints);
        }
    }
}
