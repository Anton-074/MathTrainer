using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int operation = 0;
            int difficulty = 0;

            // Определяем выбранную операцию
            if (radioAddition.Checked) operation = 1; // Сложение
            else if (radioSubtraction.Checked) operation = 2; // Вычитание
            else if (radioMultiplication.Checked) operation = 3; // Умножение
            else if (radioDivision.Checked) operation = 4; // Деление

            // Определяем уровень сложности
            if (radioEasy.Checked) difficulty = 1; // Легкий
            else if (radioMedium.Checked) difficulty = 2; // Средний
            else if (radioHard.Checked) difficulty = 3; // Сложный


            Form1 trainingForm = new Form1(difficulty, operation);
            trainingForm.Show();//Открываем следущую форму
            this.Hide(); // Скрыть текущую форму
        }

        private void btnExid_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
