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
            SetOperation(operation, difficulty);
            GenerateQuestion();
        }

        private void SetOperation(int operation, int difficulty)
        {
            switch (difficulty)
            {
                case 1: // ������
                    minNumber = 1;
                    maxNumber = 10;
                    break;
                case 2: // �������
                    minNumber = 11;
                    maxNumber = 100;
                    break;
                case 3: // �������
                    minNumber = 101;
                    maxNumber = 300;
                    break;
            }

            switch (operation)
            {
                case 1: // +
                    this.operation = "addition";
                    break;
                case 2: // -
                    this.operation = "subtraction";
                    break;
                case 3: // *
                    this.operation = "multiplication";
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
                    switch (difficulty)
                    {
                        case 1:
                            minNumber = 1;
                            maxNumber = 50;
                            break;
                        case 2:
                            minNumber = 2;
                            maxNumber = 200;
                            break;
                        case 3:
                            minNumber = 2;
                            maxNumber = 500;
                            break;
                    }
                    break;
            }
            
        }

        private void GenerateQuestion()
        {

            int num1 = random.Next(minNumber+1, maxNumber + 1);
            int num2 = random.Next(minNumber, num1+1);

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
                    // ��������, ��� ����� �� ��������� �����
                    if (num2 == 0) num2 = 1; // �������� ������� �� ����
                    while(num1 % num2 != 0)
                    {
                        num2 = random.Next(minNumber, num1 + 1);
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
            // ���������� �������� �������
            List<int> options = new List<int> { correctAnswer };
            while (options.Count < 3)
            {
                int randomOption = random.Next(correctAnswer - 5, correctAnswer + 5);
                if (!options.Contains(randomOption) && randomOption >= 0) // ��������, ��� ����� �� ����������� � �� �������������
                {
                    options.Add(randomOption);
                }
            }

            // ������������ �������� �������
            options = options.OrderBy(x => random.Next()).ToList();

            // ������������� ����� ������
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
                    resultLabel.Text = "���������!";
                    clickedButton.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    resultLabel.Text = $"�����������. ���������� �����: {correctAnswer}";
                    clickedButton.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        private void ResetButtonColors()
        {
            answerButton1.BackColor = SystemColors.Control;
            answerButton2.BackColor = SystemColors.Control;
            answerButton3.BackColor = SystemColors.Control;

            // ������������ ������
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
            // ���������� ����� ������
            GenerateQuestion();
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            // ��������� ������� ����� � ��������� Form2
            this.Hide(); // �������� ������� ����
            Form2 form2 = new Form2(); // ������� ��������� Form2
            form2.Show(); // ���������� Form2
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}