using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class FormMiniGames : Form
    {
        Random rand = new Random();
        List<string> options = new List<string>();
        private int correctAnswers = 0;
        private int currentAnswer; // Правильный ответ
        private int MaxCountCorrected;
        private int countCorrected = 0;
        private int wrongAnswers = 0;

        private int seconds = 0;
        private int Minuts = 0;
        private int controlMinunts = 0;

        private int count = 0;

        public FormMiniGames()
        {
            InitializeComponent();
            MaxCountCorrected = rand.Next(7, 15);
            currentAnswer = rand.Next(15, 70);
            GenerateOptions();
            InitializeMaze();
            timer.Start();
            labelTop.Text += $"{currentAnswer} \nкол-во правильных ответов = {MaxCountCorrected}";

        }

        private void InitializeMaze()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        Text = GenerateMathQuestion(),
                        FlatStyle = FlatStyle.Flat
                    };
                    btn.Tag = CalculateAnswer(btn.Text);
                    btn.Click += Button_Click;
                    tableLayoutPanel.Controls.Add(btn, j, i);
                }
            }
        }

        private string GenerateMathQuestion()
        {
            if (count >= options.Count)
            {
                throw new InvalidOperationException("Нет доступных вопросов.");
            }
            return options[count++];
        }

        private void GenerateOptions()
        {
            int num1 = rand.Next(1, 70);
            int num2 = rand.Next(1, 70);
            while (countCorrected < MaxCountCorrected)
            {
                num1 = rand.Next(1, 70);
                num2 = rand.Next(1, 70);
                while (num1 + num2 != currentAnswer)
                {
                    num1 = rand.Next(1, 70);
                    num2 = rand.Next(1, 70);
                }
                options.Add($"{num1} + {num2}");
                countCorrected++;
            }
            while (options.Count < 25)
            {
                num1 = rand.Next(1, 70);
                num2 = rand.Next(1, 70);
                if (num1 + num2 != currentAnswer)
                {
                    options.Add($"{num1} + {num2}");
                }
            }

            options = options.OrderBy(x => rand.Next()).ToList();
        }

        private int CalculateAnswer(string question)
        {
            try
            {
                string[] parts = question.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int num1 = int.Parse(parts[0]);
                int num2 = int.Parse(parts[2]);
                return num1 + num2;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении ответа: {ex.Message}");
                return 0; // Возвращаем 0 в случае ошибки
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
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
        }

        private void IsWin()
        {
            if (correctAnswers == MaxCountCorrected)
            {

                timer.Stop();
                Label lab = new Label
                {
                    Text = $"Победа! Ваше время  0{Minuts}:{seconds}",
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                tableLayoutPanel.Visible = false;
                panelFill.Controls.Add( lab );
                //MessageBox.Show($"Победа! Ваше время  0{Minuts}:{seconds}");
                //this.Hide();
            }
            else if (wrongAnswers == 5)
            {
                MessageBox.Show("Поражение!");
                this.Hide();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                seconds = 0;
                Minuts++;
            }
            if (seconds < 10)
            {
                labelTimer.Text = $"0{Minuts}:0{seconds}";
            }
            else if (seconds >= 10 && seconds < 60)
            {
                labelTimer.Text = $"0{Minuts}:{seconds}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form  = new Form2();
            form.ShowDialog();
            this.Close();
        }
    }
}