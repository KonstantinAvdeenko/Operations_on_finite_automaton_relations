using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace OperaciiNadOtnosheniyamiKonethnyhAvtomatov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Синтез_Click(object sender, EventArgs e)
        {   
            dataGridView1.Rows.Clear(); //обновление таблицы 
            int s;
            bool result1 = Int32.TryParse(textBox1.Text, out s); // проверка введенных пользователем данных на пригодность
            if (result1 ==! result1 || s>1 || s<0) 
            textBox1.Text = ("Введите 0 или 1");
            int s1;
            bool result2 = Int32.TryParse(textBox2.Text, out s); 
            if (result2 == !result2 || s1 > 1 || s1 < 0)
                textBox2.Text = ("Введите 0 или 1");
            int n;
            bool result = Int32.TryParse(textBox3.Text, out n); 
            if (result & n > 0 & result1)
            {
                int q = int.Parse(textBox3.Text); //инициализация числа состояний krd
                Random x = new Random(); //задание случайной переменной х
                for (int i = 0; i < q; i++) //задание цикла случайного ввода
                //значений каждой ячейки krd
                {
                    dataGridView1.Rows.Add(x.Next(q), x.Next(2), x.Next(q), x.Next(2)); //создание заголовка каждого ряда krd, например, для 1 ряда - q0
                    dataGridView1.Rows[i].HeaderCell.Value = "q" + i.ToString();
                }
            }
            else
            {
                textBox3.Text = ("Введите число без пробелов больше 0"); // Отклик программы на непригодность введенных пользователем данных
                textBox2.Text = ("Введите 0 или 1");
                textBox1.Text = ("Введите 0 или 1");
            }
        }

        private void Пуск_Click(object sender, EventArgs e)
        {
            int K = 0; // входное значение 
            int Krd = 0; // инициализация числа состояний krd 
            int V = 0;  // выходное значение
            dataGridView1.Rows[K].HeaderCell.Style.BackColor = Color.WhiteSmoke; //восстановление цвета при считывании данных из таблицы
            int r;
            bool result1 = Int32.TryParse(textBox3.Text, out r);
            if (result1 ==! result1 || r<1) 
            textBox3.Text = ("Введите число без пробелов больше 0");
                int s;
                bool result = Int32.TryParse(textBox1.Text, out s);
                if (result & s < 2 & s > -1 & result1)
                {
                    int a = int.Parse(textBox1.Text); //инициализация входного символа 0 или 1
                    if (a == 0) 
                    {
                        V = (int)dataGridView1[1, Krd].Value; //формирование выходного символа
                        Krd = (int)dataGridView1[0, K].Value; //переход в очередное состояний krd
                    }
                    else
                    {
                        V = (int)dataGridView1[3, Krd].Value; //формирование выходного символа
                        Krd = (int)dataGridView1[2, K].Value; //переход в очередное состояний krd
                    }
                    textBox2.Text = V.ToString();//выдача выходного символа
                    textBox3.Text = Krd.ToString();//показ очередного состояния krd
                    dataGridView1.Rows[Krd].HeaderCell.Style.BackColor = Color.LightPink; // восстановление цвета фона и перезапись значений в таблице исходя из новых данных
                }
                else
                {
                    textBox1.Text = ("Введите 0 или 1");
                    textBox3.Text = ("Введите число без пробелов больше 0");
                    textBox2.Text = ("Введите 0 или 1");
                }
           
        }

        private void Стоп_Click(object sender, EventArgs e)
        {
            Close(); 
        }

    }
}