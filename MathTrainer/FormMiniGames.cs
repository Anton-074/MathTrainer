using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

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
        private int maxNumber = 70;

        private int seconds = 0;
        private int Minuts = 0;
        private int controlMinunts = 0;

        private int count = 0;

        Label labelInfo = new Label
        {
            Text = $"Нажмите кнопку \"Начать\"",
            Dock = DockStyle.Fill,
            BackColor = Color.Transparent,
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Arial", 16)
        };

        public FormMiniGames()
        {
            InitializeComponent();
            MaxCountCorrected = rand.Next(7, 15);
            currentAnswer = rand.Next(15, maxNumber);
            GenerateOptions();
            InitializeMaze();
            labelTop.Text += $"{currentAnswer}";
            tableLayoutPanel.Visible = false;
            panelFill.Controls.Add(labelInfo);
            this.FormBorderStyle = FormBorderStyle.None;
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
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Arial", 14)
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
            int num1;    
            int num2;    
            while (countCorrected < MaxCountCorrected)//пока не сгенерируем все правильные варианты
            {
                num1 = rand.Next(1, maxNumber);     //генерируем первое число
                num2 = rand.Next(1, maxNumber);     //генерируем второе число
                while (num1 + num2 != currentAnswer)//пока сумма не верная
                {
                    num1 = rand.Next(1, maxNumber);//генерируем первое число
                    num2 = rand.Next(1, maxNumber);//генерируем второе число
                }
                options.Add($"{num1} + {num2}");//добавяем вариант ответа 
                countCorrected++;//увеличиваем счетчик правильных ответов
            }
            //генерируем неправильные ответы
            while (options.Count < 25) //пока не наберется 25 вариантов
            {
                num1 = rand.Next(1, maxNumber);//генерируем первое число
                num2 = rand.Next(1, maxNumber);//генерируем второе число
                if (num1 + num2 != currentAnswer)//если сумма неверная
                {
                    options.Add($"{num1} + {num2}"); //добавляем вариант ответа
                }
            }

            options = options.OrderBy(x => rand.Next()).ToList();//перемешиавем варианты в рандомном порядке
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
                string time;
                if (seconds < 10)
                {
                    time = $"0{Minuts}:0{seconds}";
                }
                else
                {
                    time = $"0{Minuts}:{seconds}";
                }
                labelInfo.Text = $"Поздравляю, Вы победили!\n Ваше время {time}";
                labelInfo.Visible = true;
                tableLayoutPanel.Visible = false;
                buttonStart.Visible = true;
                buttonStart.Text = "Играть снова";
                buttonStart.Click += buttonRestart_Click;
                //MessageBox.Show($"Победа! Ваше время  0{Minuts}:{seconds}");
                //this.Hide();
            }
            else if (wrongAnswers == 5)
            {
                timer.Stop();
                labelInfo.Text = $"К сожалению вы проиграли!";
                labelInfo.Visible = true;
                tableLayoutPanel.Visible = false;
                buttonStart.Visible = true;
                buttonStart.Text = "Играть снова";
                buttonStart.Click += buttonRestart_Click;
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
        private void buttonRules_Click(object sender, EventArgs e)
        {
            FormRullesMiniGame form = new FormRullesMiniGame();
            this.Close();
            form.ShowDialog();
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelInfo.Visible = false;
            tableLayoutPanel.Visible = true;
            buttonStart.Visible = false;
            timer.Start();
        }
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            FormMiniGames form = new FormMiniGames();
            this.Close();
            form.ShowDialog();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();
            this.Close();
            form.ShowDialog();
        }
    }
}