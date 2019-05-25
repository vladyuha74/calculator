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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string s_ch1 = "";
        public string s_ch2 = "";
        public string result = "";
        public bool stat = false;

        public void Matematic_Display() //  Метод для проверки что хотят сделать и вывести на экран результат
        {
            double chislo1 = 0;
            double chislo2 = 0;
            double itog = 0;
            // Проверка что хотят сделать
            if (result == "+")
            {

                chislo1 = Convert.ToDouble(s_ch1); // Переводим все числа которые были записаны в 1 строку в число 
                chislo2 = Convert.ToDouble(s_ch2);
                itog = chislo1 + chislo2; // Вычисление 
                textBox1.Text = Convert.ToString(itog); // Вывод на экран в textBox1

            }
            if (result == "-")
            {
                chislo1 = Convert.ToDouble(s_ch1); // Переводим все числа которые были записаны в 1 строку в число 
                chislo2 = Convert.ToDouble(s_ch2);
                itog = chislo1 - chislo2; // Вычисление 
                textBox1.Text = Convert.ToString(itog); // Вывод на экран в textBox1
            }
            if (result == "/")
            {
                if (s_ch2 == "0")
                {
                    textBox1.Text = "Деление на ноль невозможно"; // Вывод на экран в textBox1 ОШИБКУ 
                }
                else
                {
                    chislo1 = Convert.ToDouble(s_ch1); // Переводим все числа которые были записаны в 1 строку в число 
                    chislo2 = Convert.ToDouble(s_ch2);
                    itog = chislo1 / chislo2; // Вычисление 
                    textBox1.Text = Convert.ToString(itog);
                }
            }
            if (result == "*")
            {
                chislo1 = Convert.ToDouble(s_ch1); // Переводим все числа которые были записаны в 1 строку в число 
                chislo2 = Convert.ToDouble(s_ch2);
                itog = chislo1 * chislo2; // Вычисление 
                textBox1.Text = Convert.ToString(itog); // Вывод на экран в textBox1
            }
            if (result == "x^2") // Во втрой степени 1 число
            {
                chislo1 = Convert.ToDouble(s_ch1); // Переводим все числа которые были записаны в 1 строку в число  
                itog = chislo1 * chislo1;
                textBox1.Text = Convert.ToString(itog);
            }
            if (result == "√") //Корень квадратный из 1 числа
            {
                chislo1 = Convert.ToDouble(s_ch1);// Переводим все числа которые были записаны в 1 строку в число
                itog = Math.Sqrt(chislo1); // Переводим сначала в double для вычисления корня а потом итог переводим в decimal
                textBox1.Text = Convert.ToString(itog);
            }
            if (result == "1/x")
            {
                chislo1 = Convert.ToDouble(s_ch1);// Переводим все числа которые были записаны в 1 строку в число
                itog = 1 / chislo1;
                textBox1.Text = Convert.ToString(itog);
            }
            if(result == "x^y")
            {
                chislo1 = Convert.ToDouble(s_ch1); // Переводим все числа которые были записаны в 1 строку в число 
                chislo2 = Convert.ToDouble(s_ch2);
                itog = 1;
                for (int i=1; i <= chislo2; i++)
                {
                    itog = itog * chislo1;
                }
               // itog = chislo1 * chislo2; // Вычисление 
                textBox1.Text = Convert.ToString(itog); // Вывод на экран в textBox1
            }
            if (result == "n!")
            {
                chislo1 = Convert.ToDouble(s_ch1); // Переводим все числа которые были записаны в 1 строку в число
                if (chislo1 != 0)
                {
                    itog = 1;
                    for (int i = 1; i <= chislo1; i++)
                    {
                        itog = itog * i;
                    }
                }
                else
                {
                    itog = 1;
                }
                textBox1.Text = Convert.ToString(itog); // Вывод на экран в textBox1
            }
            if(result == "sin")
            {
                chislo1 = Convert.ToDouble(s_ch1);
                itog = Math.Sin(chislo1);
                textBox1.Text = Convert.ToString(itog);
            }
            if (result == "cos")
            {
                chislo1 = Convert.ToDouble(s_ch1);
                itog = Math.Cos(chislo1);
                textBox1.Text = Convert.ToString(itog);
            }
            if (result == "tang")
            {
                chislo1 = Convert.ToDouble(s_ch1);
                itog = Math.Tan(chislo1);
                textBox1.Text = Convert.ToString(itog);
            }
            if (result == "<x")
            {
                s_ch1 = s_ch1.Remove(s_ch1.Length - 1);
                textBox1.Text = Convert.ToString(s_ch1);   
            }
        }

        // Метод действий которая нажата кнопка (+,-,/,x^2,√,1/x,x^y,n!,<x)
        public void Info(int nb)
        {
            switch (nb) // Выбор действия
            {
                case 11:
                    stat = true; // Индекс который открывает доступ к заполнению второго числа
                    textBox1.Text = ""; // Очистка заполнения первого числа
                    result = "+";
                    break;
                case 12:
                    stat = true;
                    textBox1.Text = "";
                    result = "-";
                    break;
                case 13:
                    stat = true;
                    textBox1.Text = "";
                    result = "*";
                    break;
                case 14:
                    stat = true;
                    textBox1.Text = "";
                    result = "/";
                    break;
                case 15:
                    textBox1.Text = "";
                    result = "x^2";
                    Matematic_Display();
                    break;
                case 16:
                    textBox1.Text = "";
                    result = "√";
                    Matematic_Display();
                    break; 
                case 20:
                    textBox1.Text = "";
                    result = "1/x";
                    Matematic_Display();
                    break;
                case 21:
                    result = "<x";
                    Matematic_Display();
                    break;
                case 22:
                    stat = true;
                    textBox1.Text = "";
                    result = "x^y";
                    break;
                case 23:
                    textBox1.Text = "";
                    result = "n!";
                    Matematic_Display();
                    break;
                case 25:
                    textBox1.Text = "";
                    result = "sin";
                    Matematic_Display();
                    break;
                case 26:
                    textBox1.Text = "";
                    result = "cos";
                    Matematic_Display();
                    break;
                case 27:
                    textBox1.Text = "";
                    result = "tang";
                    Matematic_Display();
                    break;
            }
        }

        // Метод для заполнения чисел
        public void Chislo(int nb)
        {
            if (stat == false) // Условие на выбор числа для заполнения.
            {
                switch (nb)
                {
                    case 1:
                        s_ch1 = s_ch1 + Convert.ToString(nb);
                        textBox1.Text = s_ch1;
                        break;
                    case 2:
                        s_ch1 = s_ch1 + Convert.ToString(nb);
                        textBox1.Text = s_ch1;
                        break;
                    case 3:
                        s_ch1 = s_ch1 + Convert.ToString(nb);
                        textBox1.Text = s_ch1;
                        break;
                    case 4:
                        s_ch1 = s_ch1 + Convert.ToString(nb);
                        textBox1.Text = s_ch1;
                        break;
                    case 5:
                        s_ch1 = s_ch1 + Convert.ToString(nb);
                        textBox1.Text = s_ch1;
                        break;
                    case 6:
                        s_ch1 = s_ch1 + Convert.ToString(nb);
                        textBox1.Text = s_ch1;
                        break;
                    case 7:
                        s_ch1 = s_ch1 + Convert.ToString(nb);
                        textBox1.Text = s_ch1;
                        break;
                    case 8:
                        s_ch1 = s_ch1 + Convert.ToString(nb);
                        textBox1.Text = s_ch1;
                        break;
                    case 9:
                        s_ch1 = s_ch1 + Convert.ToString(nb);
                        textBox1.Text = s_ch1;
                        break;
                    case 0:
                        s_ch1 = s_ch1 + Convert.ToString(nb);
                        textBox1.Text = s_ch1;
                        break;
                    case 17:
                        s_ch1 = s_ch1 + ",";
                        textBox1.Text = s_ch1;
                        break;
                }
            }
            else
            {
                switch (nb)
                {
                    case 1:
                        s_ch2 = s_ch2 + Convert.ToString(nb);
                        textBox1.Text = s_ch2;
                        break;
                    case 2:
                        s_ch2 = s_ch2 + Convert.ToString(nb);
                        textBox1.Text = s_ch2;
                        break;
                    case 3:
                        s_ch2 = s_ch2 + Convert.ToString(nb);
                        textBox1.Text = s_ch2;
                        break;
                    case 4:
                        s_ch2 = s_ch2 + Convert.ToString(nb);
                        textBox1.Text = s_ch2;
                        break;
                    case 5:
                        s_ch2 = s_ch2 + Convert.ToString(nb);
                        textBox1.Text = s_ch2;
                        break;
                    case 6:
                        s_ch2 = s_ch2 + Convert.ToString(nb);
                        textBox1.Text = s_ch2;
                        break;
                    case 7:
                        s_ch2 = s_ch2 + Convert.ToString(nb);
                        textBox1.Text = s_ch2;
                        break;
                    case 8:
                        s_ch2 = s_ch2 + Convert.ToString(nb);
                        textBox1.Text = s_ch2;
                        break;
                    case 9:
                        s_ch2 = s_ch2 + Convert.ToString(nb);
                        textBox1.Text = s_ch2;
                        break;
                    case 0:
                        s_ch2 = s_ch2 + Convert.ToString(nb);
                        textBox1.Text = s_ch2;
                        break;
                    case 17:
                        s_ch2 = s_ch2 + ",";
                        textBox1.Text = s_ch2;
                        break;
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

        private void button11_Click(object sender, EventArgs e) // +
        {
            int numb = 11; // Номер кнопки
            Info(numb);
        }

        private void button12_Click(object sender, EventArgs e) // -
        {
            int numb = 12;// Номер кнопки
            Info(numb);
        }

        private void button13_Click(object sender, EventArgs e) // *
        {
            int numb = 13;// Номер кнопки
            Info(numb);
        }

        private void button14_Click(object sender, EventArgs e) // /
        {
            int numb = 14; // Номер кнопки
            Info(numb);
        }

        private void button15_Click(object sender, EventArgs e) // x^2
        {
            int numb = 15; // Номер кнопки
            Info(numb);
            Matematic_Display();
        }

        private void button16_Click(object sender, EventArgs e) // √
        {
            int numb = 16;// Номер кнопки
            Info(numb);
        }

        private void button17_Click(object sender, EventArgs e) // запятая ( чсла с запятой)
        {
            //Сброс всех настроек для ввода новых двух чисел
            int numb = 17;// Номер кнопки
            Chislo(numb);
        }

        private void button18_Click(object sender, EventArgs e) // сброс всех настроек
        {
            s_ch1 = "";
            s_ch2 = "";
            textBox1.Text = "";

            stat = false;
        }

        private void button19_Click(object sender, EventArgs e) // Вывод 
        {
            Matematic_Display();
        }

        private void button20_Click(object sender, EventArgs e) // (1/х)
        {
            int numb = 20;
            Info(numb);
        }

        private void button21_Click(object sender, EventArgs e) // <x
        {
            int numb = 21;
            Info(numb);
        }

        private void button22_Click(object sender, EventArgs e) // x^y
        {
            int numb = 22;
            Info(numb);
        }

        private void button23_Click(object sender, EventArgs e) // n!
        {
            int numb = 23;
            Info(numb);

        }

        private void button24_Click(object sender, EventArgs e) // Число пи
        {
            double pi = 3.14159265358979;
            textBox1.Text = Convert.ToString(pi);
        }

        private void button25_Click(object sender, EventArgs e) // sin
        {
            int numb = 25;
            Info(numb);
        }

        private void button26_Click(object sender, EventArgs e) // cos
        {
            int numb = 26;
            Info(numb);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int numb = 27;
            Info(numb);
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Visible = false;
        }
    }
}
