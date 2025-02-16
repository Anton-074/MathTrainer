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
    public partial class FormMiniGames : Form
    {
        private int correctAnswers = 0;
        private int totalQuestions = 0;
        public FormMiniGames()
        {
            InitializeComponent();
            InitializeMaze();
        }
        private void InitializeMaze()
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Text = GenerateMathQuestion(rand);
                    btn.Tag = CalculateAnswer(btn.Text).ToString();
                    btn.Click += Button_Click;
                    tableLayoutPanel1.Controls.Add(btn, j, i);
                }
            }
        }

        private string GenerateMathQuestion(Random rand)
        {
            int num1 = rand.Next(1, 10);
            int num2 = rand.Next(1, 10);
            return $"{num1} + {num2} = ?";
        }

        private int CalculateAnswer(string question)
        {
            string[] parts = question.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int num1 = int.Parse(parts[0]);
            int num2 = int.Parse(parts[2]);
            return num1 + num2;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string answer = Microsoft.VisualBasic.Interaction.InputBox("Введите ваш ответ:", "Ответ на вопрос", "");

            if (answer == btn.Tag.ToString())
            {
                MessageBox.Show("Правильно!");
                correctAnswers++;
            }
            else
            {
                MessageBox.Show($"Неправильно! Правильный ответ: {btn.Tag}");
            }

            totalQuestions++;
            btn.Enabled = false; // Деактивируем кнопку после ответа

            if (totalQuestions == 25)
            {
                MessageBox.Show($"Игра окончена! Правильных ответов: {correctAnswers}/25");
            }
        }
    }
}
