using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MathTrainer
{
    public partial class FormMiniGames : Form
    {
        Random rand = new Random();
        List<string> options = new List<string> { };
        private int correctAnswers = 0; 
        private int currentAnswer; // Правильный ответ
        private int MaxCountCorrected;
        private int countCorrected = 0;
        private int wrongAnswers = 0;

        private int count = 0;
        public FormMiniGames()
        {
            
            GenerateOptions();
            MessageBox.Show("Скомпилировалось");
            InitializeComponent();
            InitializeMaze();
            
        }
        private void InitializeMaze()
        {
            MaxCountCorrected = rand.Next(7, 15);
            currentAnswer = rand.Next(5, 10);
            labelTop.Text += $"{currentAnswer} \nкол-во правильных ответов = {MaxCountCorrected}"; 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Text = GenerateMathQuestion(rand);
                    btn.Tag = CalculateAnswer(btn.Text);
                    btn.Click += Button_Click;
                    tableLayoutPanel1.Controls.Add(btn, j, i);
                }
            }


        }

        private string GenerateMathQuestion(Random rand)
        {
            return options[count++];

        }
        private void GenerateOptions()
        {
            int num1 = rand.Next(1, 10);
            int num2 = rand.Next(1, 10);
            while (options.Count < 25)
            {
                if (countCorrected <= MaxCountCorrected)
                {
                    countCorrected++;
                    while (num1 + num2 != currentAnswer)
                    {
                        num1 = rand.Next(1, 10);
                        num2 = rand.Next(1, 10);
                    }
                }
                options.Add($"{num1} + {num2} = ?");
            }

            options = options.OrderBy(x => rand.Next()).ToList();
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
            if (currentAnswer == (int)(btn.Tag))
            {
                btn.BackColor = Color.Green;
                correctAnswers++;
            }
            else
            {
                wrongAnswers++;
                btn.BackColor = Color.Red;
            }

            btn.Enabled = false; // Деактивируем кнопку после ответа
            IsWin();

        }
        private void IsWin()
        {
            if (correctAnswers == MaxCountCorrected)
            {
                MessageBox.Show("Победа!");
                this.Hide();
            }
            else if (wrongAnswers == 5)
            {
                MessageBox.Show("Поражение!");
            }

        }
    }
}
