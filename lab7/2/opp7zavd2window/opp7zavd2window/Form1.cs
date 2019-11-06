using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opp7zavd2window
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class a { }
        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            crc_OK = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            /*Graphics gr = e.Graphics;
            Pen p = new Pen(Color.Blue, 5);// цвет линии и ширина
            Point p1 = new Point(5, 10);// первая точка
            Point p2 = new Point(40, 100);// вторая точка
            gr.DrawLine(p, p1, p2);// рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            */
        }
        bool crc_OK;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // проверка флага нажатия
            if (!crc_OK)
                return;

            // 
            Bitmap tmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(tmp);
            g.DrawEllipse(new Pen(Color.Black, 3), e.X, e.Y, 50, 50);
            pictureBox1.Image = tmp;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
