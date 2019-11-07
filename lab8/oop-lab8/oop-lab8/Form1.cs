using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            one();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            one();
        }

        void one()
        {
            Graphics g = this.CreateGraphics(); //задаємо область малювання
            g.Clear(Color.White);   //очищуємо область (заливаємо білим кольором)
            Pen a = new Pen(Color.Blue, 1); //ручка для малювання осей
            Pen b = new Pen(Color.Green, 2);//ручка для малювання графіка
            Font drawFont = new Font("Arial", 12);  //шрифт яким будемо писати осі 
            Font signatureFont = new Font("Arial", 7);  //шрифт яким будемо підписувати ділення осі
            SolidBrush drawBrush = new SolidBrush(Color.Blue);  //колір цього шрифта
            StringFormat drawFormat = new StringFormat();   //формат букв (для підпису)
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;    //направлення тексту осі
            int sizeWidth = Form1.ActiveForm.Width; //ширина вікна програми
            int sizeHeight = Form1.ActiveForm.Height;   //висота вікна програми
            //х, у - координати центру (очки 0)
            Point center = new Point(((int)(sizeWidth/2)-8), (int)((sizeHeight / 2) - 19));
            
            ///додаємо код для малювання лсів та виведення підписів до них

            g.DrawLine(a, 10, center.Y, center.X, center.Y);                //ось Х-
            g.DrawLine(a, center.X, center.Y, 2 * center.X - 10, center.Y); //ось Х+
            g.DrawLine(a, center.X, 10, center.X, center.Y);                //ось У+
            g.DrawLine(a, center.X, center.Y, center.X, 2 * center.Y -10);  //ось У-
            g.DrawString("X", drawFont, drawBrush, new PointF(2 * center.X - 5, center.Y + 10), drawFormat); //підписали ч
            g.DrawString("Y", drawFont, drawBrush, new PointF(center.X + 30, 5), drawFormat);   //підписали у


            g.DrawLine(a, center.X, 10, center.X + 5, 20);  //стрілки: у+
            g.DrawLine(a, center.X, 10, center.X - 5, 20);  //у-
            //аналогічно намалювати стрілки х+ х-


            int stepForAxes = 25;   //відстань між діленням на осях
            int lenghtShtrih = 3;   //половина довжини штришка ділення
            int maxValueForAxesX = 16;  //максимальне знчення по осі Х
            int maxValueForAxesY = 25;  //по осі У

            float oneDelenieX = (float)maxValueForAxesX / ((float)center.X / (float)stepForAxes);
            //то, чим підписувати ділення Х
            float oneDelenieY = (float)maxValueForAxesY / ((float)center.Y / (float)stepForAxes);
            //то, чим підписувати ділення У
            for (int i = center.X, j = center.X, k = 1; i < 2 * center.X - 30; j -= stepForAxes, i+= stepForAxes, k++)
            {
                g.DrawLine(a, i, center.Y - lenghtShtrih, i, center.Y + lenghtShtrih);  //малюємо штрихи по осі Х вправо від центра
                g.DrawLine(a, j, center.Y - lenghtShtrih, j, center.Y + lenghtShtrih);  //малюємо штрихи по осі Х вліво від центра

                if(i < 2 * center.X - 55)
                {
                    g.DrawString((k * oneDelenieX).ToString("0.0"), signatureFont, drawBrush,
                            new PointF(i + stepForAxes + 9, center.Y + 6), drawFormat); //підписуємо ділення +
                    g.DrawString(((k * oneDelenieX).ToString("0.0").ToString()+ "-"), 
                        signatureFont, drawBrush, new PointF(j - stepForAxes + 9, center.Y + 6), drawFormat);
                }
            }
            //малюємо штрихи по осі У
            //підписуємо ділення по осі У
            //розраховуємо значення функції на заданому інтеревалі і побудуємо цим значенням графік
            int numOfPoint = 100;   //кількість точок для розрахування функції

            float[] first = new float[numOfPoint];  //точки для розрахування

            for(int i = 0; i < numOfPoint; i++)
            {
                first[i] = (float)maxValueForAxesX / (float)numOfPoint * (i + 1) - 6;   //інтервал від -6 до 10
            }

            float[] second = new float[numOfPoint]; 
            for(int i = 0; i< numOfPoint; i++)
            {
                second[i] = (float)(Math.Pow(Math.E, first[i] /2)*Math.Sin(2 *first[i]));
            }

            Point[] pointOne = new Point[numOfPoint];

            float tempX = 1 / oneDelenieX * stepForAxes;    //розраховуємо нові координати
            float tempY = 1 / oneDelenieY * stepForAxes;

            for(int i = 0; i< numOfPoint; i++)
            {
                pointOne[i].X = center.X + (int)(first[i] * tempX); //перехід до нових координатах
                pointOne[i].Y = center.Y + (int)(second[i] * tempY);
            }

            g.DrawLines(b, pointOne);   //малюємо графік (ломана лінія)
            g.DrawCurve(b, pointOne);   //малюємо сплайном
        }
    }
}
