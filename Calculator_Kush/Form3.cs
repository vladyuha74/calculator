using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Kush
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string s_chislo = "";
        public double chislo = 0;
        public string sys_result = ""; // Системное выполнение
        public double itog = 0;
        
        public void Izmerenya()
        {
            if (sys_result == "<x") //Удаление последнего элемента
            {
                s_chislo = s_chislo.Remove(s_chislo.Length - 1);
                textBox1.Text = Convert.ToString(s_chislo);
            }
            // Перевод одинаковых индексов(милиметры в милиметры; сантиметры в сантиметры; метры в метры; километры в километры)
            if (((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 0)) ||
                ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 1)) ||
                ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 2)) ||
                ((comboBox1.SelectedIndex == 3) && (comboBox2.SelectedIndex == 3)))
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo;
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 1)) // Перевод миллиметры в сантиметры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo / 10;
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 2)) // Перевод миллиметры в метры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo / 1000;
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 3)) // Перевод миллиметры в километры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo / 1000000;

                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 0))// Перевод сантиметры в миллиметры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo * 10;
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 2))// Перевод сантиметры в метры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo / 100;
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 3))// Перевод сантиметры в километры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo / 100000;
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 0))// Перевод метры в миллиметры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo * 1000;
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 1))// Перевод метры в сантиметры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo * 100;
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 3))// Перевод метры в километры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo / 1000;//
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 3) && (comboBox2.SelectedIndex == 0))// Перевод километры в миллиметры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo * 1000000;
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 3) && (comboBox2.SelectedIndex == 1))// Перевод километры в сантиметры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo * 100000;
                textBox2.Text = Convert.ToString(itog);
            }
            else if ((comboBox1.SelectedIndex == 3) && (comboBox2.SelectedIndex == 2))// Перевод километры в метры
            {
                chislo = Convert.ToDouble(s_chislo);
                itog = chislo * 1000;
                textBox2.Text = Convert.ToString(itog);
            }
        }

        public void Info(int nb)
        {
            switch (nb) // Выбор действия
            {
                case 13:
                    sys_result = "<x";
                    Izmerenya();
                    break;
            }
        }

        public void Chislo(int nb)
        {
            switch (nb)
            {
                case 1:
                    s_chislo = s_chislo + Convert.ToString(nb);
                    textBox1.Text = s_chislo;
                    break;
                case 2:
                    s_chislo = s_chislo + Convert.ToString(nb);
                    textBox1.Text = s_chislo;
                    break;
                case 3:
                    s_chislo = s_chislo + Convert.ToString(nb);
                    textBox1.Text = s_chislo;
                    break;
                case 4:
                    s_chislo = s_chislo + Convert.ToString(nb);
                    textBox1.Text = s_chislo;
                    break;
                case 5:
                    s_chislo = s_chislo + Convert.ToString(nb);
                    textBox1.Text = s_chislo;
                    break;
                case 6:
                    s_chislo = s_chislo + Convert.ToString(nb);
                    textBox1.Text = s_chislo;
                    break;
                case 7:
                    s_chislo = s_chislo + Convert.ToString(nb);
                    textBox1.Text = s_chislo;
                    break;
                case 8:
                    s_chislo = s_chislo + Convert.ToString(nb);
                    textBox1.Text = s_chislo;
                    break;
                case 9:
                    s_chislo = s_chislo + Convert.ToString(nb);
                    textBox1.Text = s_chislo;
                    break;
                case 0:
                    s_chislo = s_chislo + Convert.ToString(nb);
                    textBox1.Text = s_chislo;
                    break;
                case 11:
                    s_chislo = s_chislo + ",";
                    textBox1.Text = s_chislo;
                    break;
            }
        }

        //Нажатие кнопок для записи числа
        private void button1_Click_1(object sender, EventArgs e)
        {
            int numb = 1;
            Chislo(numb);
            Izmerenya();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int numb = 2;
            Chislo(numb);
            Izmerenya();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int numb = 3;
            Chislo(numb);
            Izmerenya();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int numb = 4;
            Chislo(numb);
            Izmerenya();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int numb = 5;
            Chislo(numb);
            Izmerenya();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int numb = 6;
            Chislo(numb);
            Izmerenya();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int numb = 7;
            Chislo(numb);
            Izmerenya();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int numb = 8;
            Chislo(numb);
            Izmerenya();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int numb = 9;
            Chislo(numb);
            Izmerenya();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int numb = 0;
            Chislo(numb);
            Izmerenya();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            int numb = 11;
            Chislo(numb);
            Izmerenya();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            s_chislo = "";
            textBox1.Text = "";
            textBox2.Text = "";
            sys_result = "";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            int numb = 13;
            Info(numb);
        }
        //Переход между формами с помощью меню
        private void обычныйToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Visible = false;
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Visible = false;
        }

        private void единицаИзмДлинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Visible = false;
        }
    }
    
}
