using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using МашиностроительнаяБиблиотека;
using System.Diagnostics;

namespace РасчетПробокПоГОСТ24853_81
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal номинальныйРазмер = decimal.Parse(textBox1.Text);
                decimal нижнееОтклонение = decimal.Parse(textBox3.Text);
                decimal верхнееОтклонение = decimal.Parse(textBox2.Text);
                РазмерCОтклонениями размерОтверстия = new РазмерCОтклонениями(номинальныйРазмер, нижнееОтклонение, верхнееОтклонение);

                РазмерCОтклонениями размерПробкиПР = КалькуляторПробок.ВычислитьРазмерПробкиПР(размерОтверстия);
                textBox6.Text = размерПробкиПР.НоминальныйРазмер.ToString();
                textBox4.Text = размерПробкиПР.НижнееОтклонение.ToString();
                textBox5.Text = размерПробкиПР.ВерхнееОтклонение.ToString();

                decimal размерПробкиПРизнош = КалькуляторПробок.ВычислитьРазмерПробкиПРизнош(размерОтверстия);
                textBox7.Text = размерПробкиПРизнош.ToString();

                РазмерCОтклонениями размерПробкиНЕ = КалькуляторПробок.ВычислитьРазмерПробкиНЕ(размерОтверстия);
                textBox10.Text = размерПробкиНЕ.НоминальныйРазмер.ToString();
                textBox8.Text = размерПробкиНЕ.НижнееОтклонение.ToString();
                textBox9.Text = размерПробкиНЕ.ВерхнееОтклонение.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',') e.KeyChar = System.Windows.Forms.Application.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 1)
            {
                int квалитет = comboBox1.SelectedIndex + 5;
                decimal номинальныйРазмер = decimal.Parse(textBox1.Text);
                decimal допуск = ТаблицаДопусков.НайтиДопуск(номинальныйРазмер, квалитет);
                textBox3.Text = "0";
                textBox2.Text = допуск.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("gost24853-81.pdf");
        }
    }
}
