using System;
using System.Numerics;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class Form1 : Form
    {
        private Random random;
        private int correctAnswer;
        private int minNumber;
        private int maxNumber;
        private string operation;

        public Form1(int difficulty, int operation)
        {
            InitializeComponent();
            random = new Random();
            SetDifficulty(difficulty);
            SetOperation(operation);
            GenerateQuestion();
        }
        private void SetDifficulty(int difficulty)
        {
            switch (difficulty)
            {
                case 1: // Легкий
                    minNumber = 1;
                    maxNumber = 10;
                    break;
                case 2: // Средний
                    minNumber = 11;
                    maxNumber = 50;
                    break;
                case 3: // Сложный
                    minNumber = 51;
                    maxNumber = 100;
                    break;
            }
        }

        private void SetOperation(int operation)
        {
            switch (operation)
            {
                case 1:
                    this.operation = "addition";
                    break;
                case 2:
                    this.operation = "subtraction";
                    break;
                case 3:
                    this.operation = "multiplication";
                    break;
                case 4:
                    this.operation = "division";
                    break;
            }
        }

        private void GenerateQuestion()
        {
            int num1 = random.Next(minNumber, maxNumber + 1);
            int num2 = random.Next(minNumber, maxNumber + 1);

            switch (operation)
            {
                case "addition":
                    correctAnswer = num1 + num2;
                    questionLabel.Text = $"{num1} + {num2} = ?";
                    break;
                case "subtraction":
                    correctAnswer = num1 - num2;
                    questionLabel.Text = $"{num1} - {num2} = ?";
                    break;
                case "multiplication":
                    correctAnswer = num1 * num2;
                    questionLabel.Text = $"{num1} * {num2} = ?";
                    break;
                case "division":
                    // Убедимся, что делим на ненулевое число
                    if (num2 == 0) num2 = 1; // Избегаем деления на ноль
                    correctAnswer = num1 / num2;
                    questionLabel.Text = $"{num1} / {num2} = ?";
                    break;

            }
            resultLabel.Text = "";
            SetAnswerOptions(correctAnswer);
        }



        private void SetAnswerOptions(int correctAnswer)
        {
            // Генерируем варианты ответов
            List<int> options = new List<int> { correctAnswer };
            while (options.Count < 4)
            {
                int randomOption = random.Next(correctAnswer - 5, correctAnswer + 5);
                if (!options.Contains(randomOption) && randomOption >= 0) // Убедимся, что ответ не повторяется и не отрицательный
                {
                    options.Add(randomOption);
                }
            }

            // Перемешиваем варианты ответов
            options = options.OrderBy(x => random.Next()).ToList();

            // Устанавливаем текст кнопок
            answerButton1.Text = options[0].ToString();
            answerButton2.Text = options[1].ToString();
            answerButton3.Text = options[2].ToString();

            ResetButtonColors();
        }



        private void AnswerButton_Click(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int selectedAnswer = int.Parse(clickedButton.Text);
                BlockAllButtons();
                if (selectedAnswer == correctAnswer)
                {
                    resultLabel.Text = "Правильно!";
                    clickedButton.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    resultLabel.Text = $"Неправильно. Правильный ответ: {correctAnswer}";
                    clickedButton.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        private void ResetButtonColors()
        {
            answerButton1.BackColor = SystemColors.Control;
            answerButton2.BackColor = SystemColors.Control;
            answerButton3.BackColor = SystemColors.Control;

            // Разблокируем кнопки
            answerButton1.Enabled = true;
            answerButton2.Enabled = true;
            answerButton3.Enabled = true;
        }
        private void BlockAllButtons()
        {
            answerButton1.Enabled = false;
            answerButton2.Enabled = false;
            answerButton3.Enabled = false;
        }

        private void NextQ_Click(object sender, EventArgs e)
        {
            // Генерируем новый вопрос
            GenerateQuestion();
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Закрываем текущую форму и открываем Form2
            this.Hide(); // Скрываем текущую форму
            Form2 form2 = new Form2(); // Создаем экземпляр Form2
            form2.Show(); // Показываем Form2
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}