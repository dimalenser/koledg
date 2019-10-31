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
            this.Text = "Замовлення путівок";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double potivki = Double.Parse(textBox1.Text);
            double dni = Double.Parse(textBox2.Text);
            double vartist = 0;
            if(comboBox1.SelectedIndex==0 && radioButton1.Checked)
            {
                vartist =  dni * 100;
            }
            //-----------------------------
            if (comboBox1.SelectedIndex == 0 && radioButton2.Checked)
            {
                vartist = dni * 150;
            }
            //-----------------------------
            if (comboBox1.SelectedIndex == 1 && radioButton1.Checked)
            {
                vartist = dni * 160;
            }
            //-----------------------------
            if (comboBox1.SelectedIndex == 1 && radioButton2.Checked)
            {
                vartist = dni * 200;
            }
            //-----------------------------
            if (comboBox1.SelectedIndex == 2 && radioButton1.Checked)
            {
                vartist = dni * 120;
            }
            //-----------------------------
            if (comboBox1.SelectedIndex == 2 && radioButton2.Checked)
            {
                vartist = dni * 180;
            }
            //******************************
            vartist *= potivki; //множу вартість однієї потівки на кількість потівок
            if(checkBox1.Checked)
            {
                vartist += dni*50;
            }
            label_vartist.Text = $"Вартість путівки: ${vartist}";
        }
    }
}
