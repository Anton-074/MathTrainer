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
    public partial class FormMiniGames2 : Form
    {

        private const int Size = 5;
        private Button[,] buttons = new Button[Size, Size];
        private int currentResult;

        private int currentRow = 0;
        private int currentCol = 0;

        private int LocI = 0;
        private int LocJ = 0;

        private Boolean GameOver = false;

        public FormMiniGames2()
        {
            InitializeComponent();
            InitializeButtons();
            GenerateMathProblems();
            GenerateLocationCurrenResult();
            HighlightCurrentCell();
        }

        private void InitializeButtons()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    buttons[i, j] = new Button
                    {
                        Size = new Size(50, 50),
                        Location = new Point(j * 50, i * 50),
                        BackColor = Color.LightGray,
                        FlatStyle = FlatStyle.Flat
                    };
                    buttons[i, j].Click += Button_Click;
                    Controls.Add(buttons[i, j]);

                }
            }
        }

        private void GenerateMathProblems()
        {
            Random rand = new Random();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    int a = rand.Next(1, 10);
                    int b = rand.Next(1, 10);
                    buttons[i, j].Text = $"{a} + {b}"; // Пример: "3 + 4"
                    buttons[i, j].Tag = a + b; // Сохраняем результат в Tag
                    buttons[i, j].Enabled = false;//закрываем все ячейки
                }
            }
            // Устанавливаем результат в верхнем левом углу
            currentResult = (int)buttons[0, 0].Tag;


            //открываем все ячейки
            buttons[0, 0].Enabled = true;
            buttons[0, 1].Enabled = true;
            buttons[1, 0].Enabled = true;
        }

        private void GenerateLocationCurrenResult()
        {
            while (GameOver != true)
            {
                Random rand = new Random();
                int next = rand.Next(1, 5);
                int a = rand.Next(1, 10);
                int b = rand.Next(1, 10);
                while (a + b != currentResult)
                {
                    a = rand.Next(1, 10);
                    b = rand.Next(1, 10);

                }
                if (next == 1)
                {
                    if (LocI + 1 < Size)
                    {
                        buttons[LocI + 1, LocJ].Text = $"{a} + {b}";
                        buttons[LocI + 1, LocJ].Tag = a + b;
                        LocI += 1;

                    }
                    else next = 2;

                }
                if (next == 2)
                {
                    if (LocJ + 1 < Size)
                    {
                        buttons[LocI, LocJ + 1].Text = $"{a} + {b}";
                        buttons[LocI, LocJ + 1].Tag = a + b;
                        LocJ += 1;
                    }
                    else next = 3;

                }
                if (next == 3)
                {
                    if (LocI - 1 < Size && LocI - 1 >0)
                    {
                        buttons[LocI - 1, LocJ].Text = $"{a} + {b}";
                        buttons[LocI - 1, LocJ].Tag = a + b;
                        LocI -= 1;
                    }
                    else next = 4;

                }
                if (next == 4)
                {
                    if (LocJ-1<Size && LocJ-1>0)
                    {
                        buttons[LocI, LocJ - 1].Text = $"{a} + {b}";
                        buttons[LocI, LocJ - 1].Tag = a + b;
                        LocJ -= 1;
                    }
                    else next = 1;
                }
                if (next == 1)
                {
                    if (LocI + 1 < Size)
                    {
                        buttons[LocI + 1, LocJ].Text = $"{a} + {b}";
                        buttons[LocI + 1, LocJ].Tag = a + b;
                        LocI += 1;
                    }
                    else next = 2;
                }
                if (LocI == 4 && LocJ == 4)
                {
                    GameOver = true;
                }
            }
        }
        /*
         *              buttons[LocI, LocJ - 1].Enabled = true;//открываем сверху
                        buttons[LocI, LocJ + 1].Enabled = true;//открываем снизу
                        buttons[LocI + 1, LocJ].Enabled = true;//открываем справа
                        buttons[LocI - 1, LocJ].Enabled = true;//открываем слева*/
        private void HighlightCurrentCell()
        {
            buttons[currentRow, currentCol].BackColor = Color.Green;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            int clickedResult = (int)clickedButton.Tag;
            if (clickedResult == currentResult)
            {
                // Верный ответ
                buttons[currentRow, currentCol].BackColor = Color.Green;
                currentRow = GetRow(clickedButton);
                currentCol = GetCol(clickedButton);
                HighlightAdjacentCells(clickedButton);
                currentResult = clickedResult; // Обновляем текущий результат
            }
            else
            {
                // Неверный ответ
                clickedButton.BackColor = Color.Red;
            }

            // Проверка на завершение лабиринта
            if (currentRow == Size - 1 && currentCol == Size - 1)
            {
                MessageBox.Show("Поздравляем! Вы завершили лабиринт!");
                Application.Exit();
            }
        }

        private void HighlightAdjacentCells(Button clickedButton)
        {
            // Сбрасываем цвета
            foreach (var button in buttons)
            {
                button.Enabled = false;
                if (button.BackColor == Color.Yellow)
                {
                    button.BackColor = System.Drawing.Color.Gray;
                }

            }
            int first=-1;
            // Подсвечиваем смежные ячейки и открываем их
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (Math.Abs(i) + Math.Abs(j) == 1) // Только смежные ячейки 
                    {
                        if(first <0)
                        {
                            first = 1;

                        }
                        int newRow = currentRow + i;
                        int newCol = currentCol + j;
                        if (IsInBounds(newRow, newCol))
                        {
                            if(first <0)
                            {
                                
                            }
                            buttons[newRow, newCol].BackColor = Color.Yellow;
                            buttons[newRow, newCol].Enabled = true;

                        }
                    }
                }
            }
        }

        private bool IsInBounds(int row, int col)
        {
            return row >= 0 && row < Size && col >= 0 && col < Size;
        }

        private int GetRow(Button button)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (buttons[i, j] == button)
                        return i;
                }
            }
            return -1; // Если не найдено
        }



        private int GetCol(Button button)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (buttons[i, j] == button)
                        return j;
                }
            }
            return -1; // Если не найдено
        }
    }
}

