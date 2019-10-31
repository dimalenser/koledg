using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double shuruna = Double.Parse(textBox1.Text);
            double vusota = Double.Parse(textBox2.Text);
            double kvmetr = shuruna * vusota;
            double vartist = 0;
            if(comboBox1.SelectedIndex==0 && radioButton1.Checked)
            {
                vartist = kvmetr * 0.25;
            }
            //-----------------------------
            if (comboBox1.SelectedIndex == 0 && radioButton2.Checked)
            {
                vartist = kvmetr * 0.3;
            }
            //-----------------------------
            if (comboBox1.SelectedIndex == 1 && radioButton1.Checked)
            {
                vartist = kvmetr * 0.05;
            }
            //-----------------------------
            if (comboBox1.SelectedIndex == 1 && radioButton2.Checked)
            {
                vartist = kvmetr * 0.10;
            }
            //-----------------------------
            if (comboBox1.SelectedIndex == 2 && radioButton1.Checked)
            {
                vartist = kvmetr * 0.15;
            }
            //-----------------------------
            if (comboBox1.SelectedIndex == 2 && radioButton2.Checked)
            {
                vartist = kvmetr * 0.20;
            }
            //******************************
            if(checkBox1.Checked)
            {
                vartist += 35;
            }
            label_vartist.Text = $"Вартість : {vartist} грн.";
        }
    }
}
