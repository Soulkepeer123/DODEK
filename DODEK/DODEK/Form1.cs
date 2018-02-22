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
    class Figure
    {
        int x, y, c;
        public void setXYC( int x, int y, int c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
        public virtual void DoDraw(PaintEventArgs e) { }

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
