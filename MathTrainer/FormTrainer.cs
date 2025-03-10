using System;
using System.Numerics;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class FormTrainer : Form
    {
        //��� ��������� �����
        private Random random;
        private int correctAnswer;
        private int lastAnswer=0;
        private int minNumber;
        private int maxNumber;
        private int minNumberNum1;
        private int minNumberNum2;
        private int minDegree;
        private int maxDegree;

        //��� ��������� ��������� ��������
        private string operation;
        private string operationRus;
        private string difficultyRus;

        //��� �������
        private const int timerTime = 10;//����� �� �����
        private int timerControl=timerTime;

        //��� ��������
        private int maxCountQuestion= 5;
        private int countQuestion = 1;
        private int countCorrectAnswers=0;

        public FormTrainer(int difficulty, int operation, int maxCountQuestion)
        {
            InitializeComponent();
            SetOperation(operation, difficulty);
            this.maxCountQuestion = maxCountQuestion;
            random = new Random();
            GenerateQuestion();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //NextQ.Enabled = false;
            labelNumber.Text = $"������ {countQuestion}/{maxCountQuestion}";
            this.FormBorderStyle = FormBorderStyle.None;
            labelTimer.Text = "00:" + timerControl;
            timer.Start();
            NextQ.Visible = false;
        }

        private void SetOperation(int operation, int difficulty)// ������������� 
        {
            switch (difficulty)
            {
                case 1: // ������
                    this.difficultyRus = "������ �������";
                    minNumber = 1;
                    maxNumber = 10;
                    break;
                case 2: // �������
                    this.difficultyRus = "������� �������";
                    minNumber = 11;
                    maxNumber = 100;
                    break;
                case 3: // �������
                    this.difficultyRus = "������� �������";
                    minNumber = 101;
                    maxNumber = 300;
                    break;
            }

            switch (operation)
            {
                case 1: // +
                    this.operation = "addition";
                    this.operationRus = "��������";
                    break;
                case 2: // -
                    this.operation = "subtraction";
                    this.operationRus = "���������";
                    break;
                case 3: // *
                    this.operation = "multiplication";
                    this.operationRus = "���������";
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
                    this.operationRus = "�������";
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
                case 5:
                    this.operation = "degree";
                    this.operationRus = "������� �����";
                    
                    switch (difficulty)
                    {
                        case 1:
                            minNumber = 1;
                            maxNumber = 5;

                            minDegree = 0;
                            maxDegree = 3;
                            break;
                        case 2:
                            minNumber = 2;
                            maxNumber = 8;

                            minDegree = 3;
                            maxDegree = 4;
                            break;
                        case 3:
                            minNumber = 8;
                            maxNumber = 15;

                            minDegree = 2;
                            maxDegree = 4;
                            break;
                    }
                    break;
                case 6:
                    this.operation = "comparison";
                    this.operationRus = "���������";

                    switch (difficulty)
                    {
                        case 1:
                            minNumber = 1;
                            maxNumber = 20;
                            break;
                        case 2:
                            minNumber = 15;
                            maxNumber = 45;
                            break;
                        case 3:
                            minNumber = 45;
                            maxNumber = 100;
                            break;
                    }
                    break;
            }
            labelDifficulty.Text = $"{operationRus} : {difficultyRus}";
        }

        private void GenerateQuestion()// ���������� ������
        {
            int num1 = 0;
            int num2 = 0;
            
            if (operation != "division")
            {
                num1 = random.Next(minNumber + 1, maxNumber + 1);
                num2 = random.Next(minNumber, num1 + 1);
                if (operation == "degree")
                {
                    num1 = random.Next(minNumber + 1, maxNumber + 1);
                    num2 = random.Next(minDegree, maxDegree);
                }
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
                    // ��������, ��� ����� �� ��������� �����
                    if (num2 == 0) num2 = 2; // �������� ������� �� ����

                    while (num1 % num2 != 0 | num1 == num2) //����� �� ������ �������� �� ����
                    {
                        num2 = random.Next(minNumberNum2 + 1, num1 + 1);
                    }
                    correctAnswer = num1 / num2;
                    questionLabel.Text = $"{num1} / {num2} = ?";
                    break;
                case "degree":
                    correctAnswer = (int)Math.Pow(num1, num2);
                    questionLabel.Text = $"{num1}^{num2} = ?";
                    break;

            }
            resultLabel.Text = "";
            SetAnswerOptions(correctAnswer);
        }



        private void SetAnswerOptions(int correctAnswer)// ������������� �������� ������ �� �����
        {
            // ���������� �������� �������
            List<int> options = new List<int> { correctAnswer };
            while (options.Count < 3) // ���� ���������� ��������������� ��������� ������ 3
            {
                int randomOption;
                if (operation == "division") //���� �������� �������
                {
                    randomOption = random.Next(correctAnswer - 2, correctAnswer + 2); //������������� ������� �������� �� -2 �� 2
                }
                else if(operation == "degree")//���� �������� ���������� � �������
                {
                    int rand = random.Next(0, 3); //������������� ������� �������� �� -10 �� +10
                    if (rand == 1)
                    {
                        randomOption = random.Next(correctAnswer - 3, correctAnswer + 3);
                    }
                    else if(rand == 3)
                    {
                        randomOption = correctAnswer - 10;
                    }
                    else 
                    {
                        randomOption = correctAnswer + 10;
                    }
                }
                else if(operation == "multiplication" & difficultyRus != "������ �������") // ���� ��������� �� ������ �������
                {
                    int rand = random.Next(0, 4);
                    switch (rand) // ������������� ������� �������� �� -20 �� + 20
                    {
                        case 0:
                            randomOption = correctAnswer - 10;
                            break;
                        case 1:
                            randomOption = correctAnswer + 10;
                            break;
                        case 2:
                            randomOption = correctAnswer - 20;
                            break;
                        case 3:
                            randomOption = correctAnswer + 20;
                            break;
                        default:
                            randomOption = correctAnswer + 20;
                            break;
                    }
                }
                else // ��� ���� ���������
                {
                    randomOption = random.Next(correctAnswer - 5, correctAnswer + 5);
                }
                if (!options.Contains(randomOption) && randomOption > 0) // ��������, ��� ����� �� ����������� � �� �������������
                {
                    options.Add(randomOption);//��������� ������� 
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



        private void AnswerButton_Click(object sender, EventArgs e)// �������� ������
        {
            timer.Stop();
            NextQ.Visible = true;
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int selectedAnswer = int.Parse(clickedButton.Text);
                BlockAllButtons();
                if (selectedAnswer == correctAnswer)
                {
                    resultLabel.Text = "���������!";
                    countCorrectAnswers++;
                    clickedButton.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    resultLabel.Text = $"�����������. ���������� �����: {correctAnswer}";
                    clickedButton.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            timerControl--;
            if( timerControl < 10)
            {
                labelTimer.Text = "00:0" + timerControl;
            }
            else
            {
                labelTimer.Text = "00:" + timerControl;
            }
            
            if(timerControl==0)
            {
                NextQ.Visible = true;
                BlockAllButtons();
                resultLabel.Text = $"����� �����. ���������� �����: {correctAnswer}";
                if(int.Parse(answerButton1.Text)==correctAnswer)
                {
                    answerButton1.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    answerButton1.BackColor = System.Drawing.Color.Red;
                }
                if (int.Parse(answerButton2.Text) == correctAnswer)
                {
                    answerButton2.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    answerButton2.BackColor = System.Drawing.Color.Red;
                }
                if (int.Parse(answerButton3.Text) == correctAnswer)
                {
                    answerButton3.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    answerButton3.BackColor = System.Drawing.Color.Red;
                }
                timer.Stop();
            }

        }
        private void ResetButtonColors()
        {
            answerButton1.BackColor = Color.FromArgb(35, 34, 73);
            answerButton2.BackColor = Color.FromArgb(35, 34, 73);
            answerButton3.BackColor = Color.FromArgb(35, 34, 73);

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
            
            
            countQuestion++;
            NextQ.Visible = false;
            if (countQuestion>maxCountQuestion)
            {
                answerButton1.Visible = false;
                answerButton2.Visible = false;
                answerButton3.Visible = false;
                NextQ.Visible = false;
                resultLabel.Dock = DockStyle.Fill;
                label.Visible = false;
                questionLabel.Dock = DockStyle.Fill;
                resultLabel.Text = $"�� �������� ��������� �� {countCorrectAnswers} �������� �� {maxCountQuestion}";
                if (countCorrectAnswers < maxCountQuestion/2)
                {
                    questionLabel.Text = "\n���������� �������������";
                }
                else if(countCorrectAnswers > maxCountQuestion / 2 && countCorrectAnswers < maxCountQuestion / 1.4)
                {
                    questionLabel.Text = "\n�������, ������� ���������";
                }
                else if(countCorrectAnswers > maxCountQuestion / 1.4)
                {
                    questionLabel.Text = "\n�������� ���������, �������!";
                }
            }
            else
            {
                timerControl = timerTime;
                labelTimer.Text = "00:" + timerControl;
                GenerateQuestion();
                labelNumber.Text = $"������ {countQuestion}/{maxCountQuestion}";
                timer.Start();
            }
            
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
            // ��������� ������� ����� � ��������� Form2
            this.Hide(); // �������� ������� ����
            FormWelcome form2 = new FormWelcome(); // ������� ��������� Form2
            form2.Show(); // ���������� Form2
        }
        

        

        
    }
}