using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class SleepingDogs : Form
    {
        public SleepingDogs()
        {
            InitializeComponent();
        }


        public string NumberInvisible1, NumberInvisible2, NumberInvisible3, NumberInvisible4, NumberInvisible5; // Переменные для хранения искомых значений
        public Random rnd = new Random(); //Создание объекта для генерации чисел
        public string RandomNumber()
        {
            string value = rnd.Next(0, 9).ToString(); //Получить случайное число (в диапазоне от 0 до 9)
            return value;
        }

        public void startGameSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumberInvisible1 = RandomNumber();
            NumberInvisible2 = RandomNumber();
            NumberInvisible3 = RandomNumber();
            NumberInvisible4 = RandomNumber();
            NumberInvisible5 = RandomNumber();
            labelNumber1.Text = "0";
            labelNumber2.Text = "0";
            labelNumber3.Text = "0";
            labelNumber4.Text = "0";
            labelNumber5.Text = "0";
        }

        public int NumberUP(string Number)
        {
            int FinalNumber = Convert.ToInt32(Number);
            if (FinalNumber < 9)
            {
                FinalNumber++;
            }
            else { FinalNumber = 0; }
            return FinalNumber;
        } // Увеличение чисел в ячейках
        public int NumberDOWN(string Number)
        {
            int FinalNumber = Convert.ToInt32(Number);
            if (FinalNumber > 0)
            {
                FinalNumber--;
            }
            else { FinalNumber = 9; }
            return FinalNumber;
        } // Уменьшение чисел в ячейках

        private void buttonNumber1UP_Click(object sender, EventArgs e)
        {
            int UP = NumberUP(labelNumber1.Text);
            labelNumber1.Text = UP.ToString(); 
        }
        private void buttonNumber2UP_Click(object sender, EventArgs e)
        {
            int UP = NumberUP(labelNumber2.Text);
            labelNumber2.Text = UP.ToString();
        }
        private void buttonNumber3UP_Click(object sender, EventArgs e)
        {
            int UP = NumberUP(labelNumber3.Text);
            labelNumber3.Text = UP.ToString();
        }
        private void buttonNumber4UP_Click(object sender, EventArgs e)
        {
            int UP = NumberUP(labelNumber4.Text);
            labelNumber4.Text = UP.ToString();
        }
        private void buttonNumber5UP_Click(object sender, EventArgs e)
        {
            int UP = NumberUP(labelNumber5.Text);
            labelNumber5.Text = UP.ToString();
        }

        private void buttonNumber1DOWN_Click(object sender, EventArgs e)
        {
            int DOWN = NumberDOWN(labelNumber1.Text);
            labelNumber1.Text = DOWN.ToString();
        }
        private void buttonNumber2DOWN_Click(object sender, EventArgs e)
        {
            int DOWN = NumberDOWN(labelNumber2.Text);
            labelNumber2.Text = DOWN.ToString();
        }
        private void buttonNumber3DOWN_Click(object sender, EventArgs e)
        {
            int DOWN = NumberDOWN(labelNumber3.Text);
            labelNumber3.Text = DOWN.ToString();
        }
        private void buttonNumber4DOWN_Click(object sender, EventArgs e)
        {
            int DOWN = NumberDOWN(labelNumber4.Text);
            labelNumber4.Text = DOWN.ToString();
        }
        private void buttonNumber5DOWN_Click(object sender, EventArgs e)
        {
            int DOWN = NumberDOWN(labelNumber5.Text);
            labelNumber5.Text = DOWN.ToString();
        }

        public void buttonBreaking_Click(object sender, EventArgs e)
        {
            if (labelNumber1.Text == NumberInvisible1 &&
                labelNumber2.Text == NumberInvisible2 &&
                labelNumber3.Text == NumberInvisible3 &&
                labelNumber4.Text == NumberInvisible4 &&
                labelNumber5.Text == NumberInvisible5 )
            {
                MessageBox.Show("Победа!");
            }
            else
            {
                if (labelNumber1.Text == NumberInvisible1) { labelNumber1.BackColor = Color.LightGreen; }
                else if (labelNumber1.Text == NumberInvisible2 || labelNumber1.Text == NumberInvisible3
                         || labelNumber1.Text == NumberInvisible4 || labelNumber1.Text == NumberInvisible5)
                         { labelNumber1.BackColor = Color.Gold; }
                else { labelNumber1.BackColor = Color.White; }
                if (labelNumber2.Text == NumberInvisible2) { labelNumber2.BackColor = Color.LightGreen; }
                else if (labelNumber2.Text == NumberInvisible1 || labelNumber2.Text == NumberInvisible3 
                         || labelNumber2.Text == NumberInvisible4 || labelNumber2.Text == NumberInvisible5)
                         { labelNumber2.BackColor = Color.Gold; }
                else { labelNumber2.BackColor = Color.White; }
                if (labelNumber3.Text == NumberInvisible3) { labelNumber3.BackColor = Color.LightGreen; }
                else if (labelNumber3.Text == NumberInvisible2 || labelNumber3.Text == NumberInvisible1 
                         || labelNumber3.Text == NumberInvisible4 || labelNumber3.Text == NumberInvisible5)
                         { labelNumber3.BackColor = Color.Gold; }
                else { labelNumber3.BackColor = Color.White; }
                if (labelNumber4.Text == NumberInvisible4) { labelNumber4.BackColor = Color.LightGreen; }
                else if (labelNumber4.Text == NumberInvisible2 || labelNumber4.Text == NumberInvisible3 
                         || labelNumber4.Text == NumberInvisible1 || labelNumber4.Text == NumberInvisible5)
                         { labelNumber4.BackColor = Color.Gold; }
                else { labelNumber4.BackColor = Color.White; }
                if (labelNumber5.Text == NumberInvisible5) { labelNumber5.BackColor = Color.LightGreen; }
                else if (labelNumber5.Text == NumberInvisible2 || labelNumber5.Text == NumberInvisible3 
                         || labelNumber5.Text == NumberInvisible4 || labelNumber5.Text == NumberInvisible1)
                         { labelNumber5.BackColor = Color.Gold; }
                else { labelNumber5.BackColor = Color.White; }
            }
        }
    }
}
