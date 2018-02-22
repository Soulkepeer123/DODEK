using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DODEK
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Invalidate();
        }
        private void Form1_Load(object sender, PaintEventArgs e)
        {
            this.Paint += new PaintEventHandler(Form1_Paint);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Circle c = new Circle();
            c.setXYC(1, 2, 3);
            c.DoDraw(e);
            Pen pen = new Pen(Color.Aqua);
            e.Graphics.DrawEllipse(pen, 130, 130, 100, 100);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            Pen pen = new Pen(Color.Aqua);
            e.Graphics.DrawEllipse(pen, 130, 130, 100, 100);
        }
    }

    class Figure
    {
        int x, y, c;
        public void setXYC(int x, int y, int c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
        public virtual void DoDraw(PaintEventArgs e) { }

    }
    class Circle : Figure
    {
        public void DoDraw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Aqua);
            e.Graphics.DrawEllipse(pen, 130, 130, 100, 100);
        }
    }
}
