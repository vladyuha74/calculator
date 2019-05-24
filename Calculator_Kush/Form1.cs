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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string s_ch1 = "";
        public string s_ch2 = "";
        public string mathem = "";
        public string result = "";
        public bool stat = false;

        public void Display() //  Метод для проверки что хотят сделать и вывести на экран результат
        {
            double chislo1 = 0;
            double chislo2 = 0;
            double itog = 0;
            chislo1 = Convert.ToDouble(s_ch1);
            chislo2 = Convert.ToDouble(s_ch2);
            // Проверка что хотят сделать
            if (result == "+")
            {
                itog = chislo1 + chislo2;
                textBox1.Text = Convert.ToString(itog);

            }
            if (result == "-")
            {
                itog = chislo1 - chislo2;
                textBox1.Text = Convert.ToString(itog);
            }
            if (result == "/")
            {
                itog = chislo1 / chislo2;
                textBox1.Text = Convert.ToString(itog);

            }
            if (result == "*")
            {
                itog = chislo1 * chislo2;
                textBox1.Text = Convert.ToString(itog);
            }
        }

        public void Info(int nb) // Объявление действия которое будет производиться (+,-,/)
        {
            if (nb == 11)
            {
                stat = true;
                textBox1.Text = "";
                result = "+";

            }
            if (nb == 12)
            {
                stat = true;
                textBox1.Text = "";
                result = "-";
            }
            if (nb == 13)
            {
                stat = true;
                textBox1.Text = "";
                result = "*";
            }
            if (nb == 14)
            {
                stat = true;
                textBox1.Text = "";
                result = "/";
            }
        }


        public void Chislo(int nb)
        {
            if(stat == false)
            {
                if (nb == 1) // Проверка нажатия конкретной кнопки 
                {
                    s_ch1 = s_ch1 + Convert.ToString(nb);
                    textBox1.Text = s_ch1;
                }
                if (nb == 2) // Проверка нажатия конкретной кнопки 
                {
                    s_ch1 = s_ch1 + Convert.ToString(nb);
                    textBox1.Text = s_ch1;
                }
                if (nb == 3)
                {
                    s_ch1 = s_ch1 + Convert.ToString(nb);
                    textBox1.Text = s_ch1;
                }
                if (nb == 4) // Проверка нажатия конкретной кнопки 
                {
                    s_ch1 = s_ch1 + Convert.ToString(nb);
                    textBox1.Text = s_ch1;
                }
                if (nb == 5)
                {
                    s_ch1 = s_ch1 + Convert.ToString(nb);
                    textBox1.Text = s_ch1;
                }
                if (nb == 6) // Проверка нажатия конкретной кнопки 
                {
                    s_ch1 = s_ch1 + Convert.ToString(nb);
                    textBox1.Text = s_ch1;
                }
                if (nb == 7)
                {
                    s_ch1 = s_ch1 + Convert.ToString(nb);
                    textBox1.Text = s_ch1;
                }
                if (nb == 8) // Проверка нажатия конкретной кнопки 
                {
                    s_ch1 = s_ch1 + Convert.ToString(nb);
                    textBox1.Text = s_ch1;
                }
                if (nb == 9)
                {
                    s_ch1 = s_ch1 + Convert.ToString(nb);
                    textBox1.Text = s_ch1;
                }
                if (nb == 0) // Проверка нажатия конкретной кнопки 
                {
                    s_ch1 = s_ch1 + Convert.ToString(nb);
                    textBox1.Text = s_ch1;

                }
                if (nb == 16)
                {
                    s_ch1 = s_ch1 + ",";
                    textBox1.Text = s_ch1;
                }
            }
            else
            {
                if (nb == 1) // Проверка нажатия конкретной кнопки 
                {
                    s_ch2 = s_ch2 + Convert.ToString(nb);
                    textBox1.Text = s_ch2;
                }
                if (nb == 2) // Проверка нажатия конкретной кнопки 
                {
                    s_ch2 = s_ch2 + Convert.ToString(nb);
                    textBox1.Text = s_ch2;
                }
                if (nb == 3)
                {
                    s_ch2 = s_ch2 + Convert.ToString(nb);
                    textBox1.Text = s_ch2;
                }
                if (nb == 4) // Проверка нажатия конкретной кнопки 
                {
                    s_ch2 = s_ch2 + Convert.ToString(nb);
                    textBox1.Text = s_ch2;
                }
                if (nb == 5)
                {
                    s_ch2 = s_ch2 + Convert.ToString(nb);
                    textBox1.Text = s_ch2;
                }
                if (nb == 6) // Проверка нажатия конкретной кнопки 
                {
                    s_ch2 = s_ch2 + Convert.ToString(nb);
                    textBox1.Text = s_ch2;
                }
                if (nb == 7)
                {
                    s_ch2 = s_ch2 + Convert.ToString(nb);
                    textBox1.Text = s_ch2;
                }
                if (nb == 8) // Проверка нажатия конкретной кнопки 
                {
                    s_ch2 = s_ch2 + Convert.ToString(nb);
                    textBox1.Text = s_ch2;
                }
                if (nb == 9)
                {
                    s_ch2 = s_ch2 + Convert.ToString(nb);
                    textBox1.Text = s_ch2;
                }
                if (nb == 0) // Проверка нажатия конкретной кнопки 
                {
                    s_ch2 = s_ch2 + Convert.ToString(nb);
                    textBox1.Text = s_ch2;
                }
                if (nb == 16)
                {
                    s_ch2 = s_ch2 + ",";
                    textBox1.Text = s_ch2;
                }
            }
        }


        public void Infomation_btn_click1(int nb)
        {
            if (nb == 1) // Проверка нажатия конкретной кнопки 
            {
                s_ch1 = s_ch1 + Convert.ToString(nb);
                textBox1.Text = s_ch1;
            }
            if (nb == 2) // Проверка нажатия конкретной кнопки 
            {
                s_ch1 = s_ch1 + Convert.ToString(nb);
                textBox1.Text = s_ch1;
            }
            if (nb == 3)
            {
                s_ch1 = s_ch1 + Convert.ToString(nb);
                textBox1.Text = s_ch1;
            }
            if (nb == 4) // Проверка нажатия конкретной кнопки 
            {
                s_ch1 = s_ch1 + Convert.ToString(nb);
                textBox1.Text = s_ch1;
            }
            if (nb == 5)
            {
                s_ch1 = s_ch1 + Convert.ToString(nb);
                textBox1.Text = s_ch1;
            }
            if (nb == 6) // Проверка нажатия конкретной кнопки 
            {
                s_ch1 = s_ch1 + Convert.ToString(nb);
                textBox1.Text = s_ch1;
            }
            if (nb == 7)
            {
                s_ch1 = s_ch1 + Convert.ToString(nb);
                textBox1.Text = s_ch1;
            }
            if (nb == 8) // Проверка нажатия конкретной кнопки 
            {
                s_ch1 = s_ch1 + Convert.ToString(nb);
                textBox1.Text = s_ch1;
            }
            if (nb == 9)
            {
                s_ch1 = s_ch1 + Convert.ToString(nb);
                textBox1.Text = s_ch1;
            }
            if (nb == 0) // Проверка нажатия конкретной кнопки 
            {
                s_ch1 = s_ch1 + Convert.ToString(nb);
                textBox1.Text = s_ch1;

            }
            if (nb == 16)
            {
                s_ch1 = s_ch1 + ",";
                textBox1.Text = s_ch1;
            }
        }

        public void Infomation_btn_click2(int nb)
        {
            if (nb == 1) // Проверка нажатия конкретной кнопки 
            {
                s_ch2 = s_ch2 + Convert.ToString(nb);
                textBox1.Text = s_ch2;
            }
            if (nb == 2) // Проверка нажатия конкретной кнопки 
            {
                s_ch2 = s_ch2 + Convert.ToString(nb);
                textBox1.Text = s_ch2;
            }
            if (nb == 3)
            {
                s_ch2 = s_ch2 + Convert.ToString(nb);
                textBox1.Text = s_ch2;
            }
            if (nb == 4) // Проверка нажатия конкретной кнопки 
            {
                s_ch2 = s_ch2 + Convert.ToString(nb);
                textBox1.Text = s_ch2;
            }
            if (nb == 5)
            {
                s_ch2 = s_ch2 + Convert.ToString(nb);
                textBox1.Text = s_ch2;
            }
            if (nb == 6) // Проверка нажатия конкретной кнопки 
            {
                s_ch2 = s_ch2 + Convert.ToString(nb);
                textBox1.Text = s_ch2;
            }
            if (nb == 7)
            {
                s_ch2 = s_ch2 + Convert.ToString(nb);
                textBox1.Text = s_ch2;
            }
            if (nb == 8) // Проверка нажатия конкретной кнопки 
            {
                s_ch2 = s_ch2 + Convert.ToString(nb);
                textBox1.Text = s_ch2;
            }
            if (nb == 9)
            {
                s_ch2 = s_ch2 + Convert.ToString(nb);
                textBox1.Text = s_ch2;
            }
            if (nb == 0) // Проверка нажатия конкретной кнопки 
            {
                s_ch2 = s_ch2 + Convert.ToString(nb);
                textBox1.Text = s_ch2;
            }
            if (nb == 16)
            {
                s_ch2 = s_ch2 + ",";
                textBox1.Text = s_ch2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Переменые кторые фиксирует нажата кнопка или нет.
            int numb = 1; // Номер кнопки
            Info(numb);
            Chislo(numb);
            //if (stat == false)
           // {
           //     Infomation_btn_click1(numb);
          //  }
            //if (stat == true)
          //  {
           //     Infomation_btn_click2(numb);
           // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numb = 2;// Номер кнопки
            Chislo(numb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numb = 3; // Номер кнопки
            Chislo(numb);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numb = 4; // Номер кнопки
            Chislo(numb);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numb = 5; // Номер кнопки
            Chislo(numb);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int numb = 6;
            Chislo(numb);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int numb = 7; // Номер кнопки
            Chislo(numb);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int numb = 8; // Номер кнопки
            Chislo(numb);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int numb = 9;// Номер кнопки
            Chislo(numb);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int numb = 0;// Номер кнопки
            Chislo(numb);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int numb = 11; // Номер кнопки
            Info(numb);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int numb = 12;// Номер кнопки
            Info(numb);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int numb = 13;// Номер кнопки
            Info(numb);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int numb = 14; // Номер кнопки
            Info(numb);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int numb = 16;// Номер кнопки
            Chislo(numb);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            s_ch1 = "";
            s_ch2 = "";
            textBox1.Text = "";
            stat = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}
