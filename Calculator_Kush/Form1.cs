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
            decimal chislo1 = 0;
            decimal chislo2 = 0;
            decimal itog = 0;
            // Проверка что хотят сделать
            if (result == "+")
            {

                chislo1 = Convert.ToDecimal(s_ch1); // Переводим все числа которые были записаны в 1 строку в число 
                chislo2 = Convert.ToDecimal(s_ch2);
                itog = chislo1 + chislo2; // Вычисление 
                textBox1.Text = Convert.ToString(itog); // Вывод на экран в textBox1

            }
            if (result == "-")
            {
                chislo1 = Convert.ToDecimal(s_ch1); // Переводим все числа которые были записаны в 1 строку в число 
                chislo2 = Convert.ToDecimal(s_ch2);
                itog = chislo1 - chislo2; // Вычисление 
                textBox1.Text = Convert.ToString(itog); // Вывод на экран в textBox1
            }
            if (result == "/")
            {
                chislo1 = Convert.ToDecimal(s_ch1); // Переводим все числа которые были записаны в 1 строку в число 
                chislo2 = Convert.ToDecimal(s_ch2);
                itog = chislo1 / chislo2; // Вычисление 
                textBox1.Text = Convert.ToString(itog); // Вывод на экран в textBox1

            }
            if (result == "*")
            {
                chislo1 = Convert.ToDecimal(s_ch1); // Переводим все числа которые были записаны в 1 строку в число 
                chislo2 = Convert.ToDecimal(s_ch2);
                itog = chislo1 * chislo2; // Вычисление 
                textBox1.Text = Convert.ToString(itog); // Вывод на экран в textBox1
            }
            if (result == "^") // Во втрой степени 1 число
            {
                chislo1 = Convert.ToDecimal(s_ch1); // Переводим все числа которые были записаны в 1 строку в число  
                itog = chislo1 * chislo1;
                textBox1.Text = Convert.ToString(itog);
            }
            if (result == "√") //Корень квадратный из 1 числа
            {
                chislo1 = Convert.ToDecimal(s_ch1);// Переводим все числа которые были записаны в 1 строку в число
                itog = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(chislo1))); // Переводим сначала в double для вычисления корня а потом итог переводим в decimal
                textBox1.Text = Convert.ToString(itog);
            }
            if(result == "1/x")
            {
                chislo1 = Convert.ToDecimal(s_ch1);// Переводим все числа которые были записаны в 1 строку в число
                itog = Convert.ToDecimal(1/chislo1); 
                textBox1.Text = Convert.ToString(itog);
            }
        }

        // Метод действий (+,-,/)
        public void Info(int nb) 
        {
            if (nb == 11)// Условие для выбора действия (+,-,/)
            {
                stat = true; // Индекс который открывает доступ к заполнению второго числа
                textBox1.Text = ""; // Очистка заполнения первого числа
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
            if (nb == 15)
            {
                stat = true;
                textBox1.Text = "";
                result = "^";
                Display();
            }
            if (nb == 16)
            {
                stat = true;
                textBox1.Text = "";
                result = "√";
                Display();
            }
            if (nb == 20)
            {
                stat = true;
                textBox1.Text = "";
                result = "1/x";
                Display();
            }
        }

        // Метод для заполнения чисел
        public void Chislo(int nb) 
        {
            if(stat == false) // Условие на выбор числа для заполнения.
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
                if (nb == 17)
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
                if (nb == 17)
                {
                    s_ch2 = s_ch2 + ",";
                    textBox1.Text = s_ch2;
                }
            }
        }

        // Управление кнопок 
        private void button1_Click(object sender, EventArgs e)
        {
            // Переменые кторые фиксирует нажата кнопка или нет.
            int numb = 1; // Номер кнопки
            Chislo(numb);
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
            int numb = 15; // Номер кнопки
            Info(numb);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int numb = 16;// Номер кнопки
            Info(numb);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Сброс всех настроек для ввода новых двух чисел
            int numb = 17;// Номер кнопки
            Chislo(numb);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            s_ch1 = "";
            s_ch2 = "";
            textBox1.Text = "";
            
            stat = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int numb=20;
            Info(numb);
        }
    }
}
