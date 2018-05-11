using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PruebasPlano
{
    
    public partial class Form1 : Form
    {
        private const int Meter = 30;
        private Graphics graphic;

        public Form1()
        {
            InitializeComponent();
            this.graphic = this.panel.CreateGraphics();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 1);
            this.graphic.DrawLine(pen, 5,5,495,5);
            this.graphic.DrawLine(pen, 495, 5, 495, 495);
            Console.WriteLine(panel.Width + " X " + panel.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
