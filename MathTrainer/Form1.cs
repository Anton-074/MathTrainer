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
        private int minNumberNum1;
        private int minNumberNum2;
        private string operation;
        private string operationRus;
        private string difficultyRus;

        public Form1(int difficulty, int operation)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            random = new Random();
            SetOperation(operation, difficulty);
            GenerateQuestion();
        }

        private void SetOperation(int operation, int difficulty)
        {
            switch (difficulty)
            {
                case 1: // Легкий
                    this.difficultyRus = "Легкий уровень";
                    minNumber = 1;
                    maxNumber = 10;
                    break;
                case 2: // Средний
                    this.difficultyRus = "Средний уровень";
                    minNumber = 11;
                    maxNumber = 100;
                    break;
                case 3: // Сложный
                    this.difficultyRus = "Сложный уровень";
                    minNumber = 101;
                    maxNumber = 300;
                    break;
            }

            switch (operation)
            {
                case 1: // +
                    this.operation = "addition";
                    this.operationRus = "Сложение";
                    break;
                case 2: // -
                    this.operation = "subtraction";
                    this.operationRus = "Вычитание";
                    break;
                case 3: // *
                    this.operation = "multiplication";
                    this.operationRus = "Умножение";
                    switch (difficulty)
                    {
                        case 1:
                            minNumber = 1;
                            maxNumber = 10;
                            break;
                        case 2:
                            minNumber = 11;
                            maxNumber = 20;
                            break;
                        case 3:
                            minNumber = 15;
                            maxNumber = 30;
                            break;
                    }
                    break;
                case 4: // /
                    this.operation = "division";
                    this.operationRus = "Деление";
                    switch (difficulty)
                    {
                        case 1:
                            minNumberNum1 = 4;
                            minNumberNum2 = 1;
                            maxNumber = 50;
                            break;
                        case 2:
                            minNumberNum1 = 50;
                            minNumberNum2 = 2;
                            maxNumber = 200;
                            break;
                        case 3:
                            minNumberNum1 = 200;
                            minNumberNum2 = 2;
                            maxNumber = 500;
                            break;
                    }
                    break;
            }
            labelDifficulty.Text = $"{operationRus} : {difficultyRus}";
        }

        private void GenerateQuestion()
        {
            int num1 = 0;
            int num2 = 0;
            if (operation != "division")
            {
                num1 = random.Next(minNumber + 1, maxNumber + 1);
                num2 = random.Next(minNumber, num1 + 1);
                
            }
            else
            {
                num1 = random.Next(minNumberNum1 + 1, maxNumber + 1);
                num2 = random.Next(minNumberNum2 + 1, num1 + 1);
                while (IsPrime(num1))
                {
                    num1 = random.Next(minNumber + 1, maxNumber + 1);
                }
            }


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
                    if (num2 == 0) num2 = 2; // Избегаем деления на ноль

                    while (num1 % num2 != 0 | num1==num2)
                    {
                        num2 = random.Next(minNumberNum2 + 1, num1 + 1);
                    }
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
            while (options.Count < 3)
            {
                int randomOption;
                if (operation=="division")
                {
                    randomOption = random.Next(correctAnswer - 2, correctAnswer + 2);
                }
                else
                {
                    randomOption = random.Next(correctAnswer - 5, correctAnswer + 5);
                }
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
            answerButton1.BackColor = Color.FromArgb(35, 34, 73);
            answerButton2.BackColor = Color.FromArgb(35, 34, 73);
            answerButton3.BackColor = Color.FromArgb(35, 34, 73);

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
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Закрываем текущую форму и открываем Form2
            this.Hide(); // Скрываем текущую форм
            Form2 form2 = new Form2(); // Создаем экземпляр Form2
            form2.Show(); // Показываем Form2
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelDifficulty_Click(object sender, EventArgs e)
        {

        }
    }
}