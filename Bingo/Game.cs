using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BingoEngine;

namespace Bingo
{
    public partial class Game : Form
    {
        private Label[,] labels = new Label[5, 5];
        private BingoBoard bingoBoard;
        private int randomNumber;
        public Game()
        {
            InitializeComponent();
            GetNumberBtn.Enabled = false;
        }

        private Label AddLabel(string text, int labelX, int labelY)
        {
            Label label = new Label();
            label.Name = text;
            label.Text = text;
            label.Width = 50;
            label.Height = 50;
            label.Location = new Point(labelX, labelY);
            label.BackColor = Color.White;
            label.Font = new Font("Serif", 18, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(5);
            return label;
        }

        private void GetBoardBtn_Click(object sender, EventArgs e)
        {
            int labelX = 260;
            int labelY = 100;
            int labelXtmp = labelX;
            bingoBoard = new BingoBoard(1, 52, 5, 5);
            var boardNumbers = bingoBoard.GetBingoBoardNumbers();

            for (int i = 0; i < labels.GetLength(0); i++)
            {
                for (int j = 0; j < labels.GetLength(1); j++)
                {
                    labels[i, j] = AddLabel(boardNumbers[i, j].ToString(), labelX, labelY);

                    labelX += 70;
                }
                labelX = labelXtmp;
                labelY += 70;
            }

            for (int i = 0; i < labels.GetLength(0); i++)
            {
                for (int j = 0; j < labels.GetLength(1); j++)
                {
                    Controls.Add(labels[i, j]);
                }
            }
            GetNumberBtn.Enabled = true;
            GetBoardBtn.Enabled = false;
        }

        private void GetNumberBtn_Click(object sender, EventArgs e)
        {
            
            randomNumber = RandomNumber.GetRandomNumber(1, 52);
            ShowNumberTextBox.Text = randomNumber.ToString();

            CheckNumberForConcurrence(randomNumber);
            CheckLinesForWin();
        }

        private void CheckNumberForConcurrence(int randomNumber)
        {
            int x, y;

            bool ifConcurrent = bingoBoard.CheckForConcurrence(randomNumber, out x, out y);

            if (ifConcurrent)
                labels[x, y].ForeColor = Color.Red;
        }


        private void CheckLinesForWin()
        {
            bingoBoard.CheckLines();

            var horizontalWin = CheckHorizontalLines();
            var verticalWin = CheckVertikalLines();
            var leftDiagonalWin = CheckLeftDiagonal();
            var rightDiagonalWin = CheckRightDiagonal();

            if (horizontalWin || verticalWin || leftDiagonalWin || rightDiagonalWin)
            {
                GetNumberBtn.Enabled = false;
                MessageBox.Show("!!!!!!!!!!!!!!BINGO!!!!!!!!!!!!!!!!");
            }
        }

        private bool CheckHorizontalLines()
        {
            int indexHorizontal;

            var checkHorizontal = bingoBoard.CheckHorizontal(out indexHorizontal) == true;

            if (checkHorizontal == true)
            {
                for (int i = 0; i < labels.GetLength(0); i++)
                {
                    labels[indexHorizontal, i].BackColor = Color.Yellow;
                }
                return true;
            }
            return false;
        }
        private bool CheckVertikalLines()
        {
            int indexVertical;

            var checkVertical = bingoBoard.CheckVertical(out indexVertical) == true;

            if (checkVertical == true)
            {
                for (int i = 0; i < labels.GetLength(1); i++)
                {
                    labels[i, indexVertical].BackColor = Color.Yellow;
                }
                return true;
            }
            return false;
        }
        private bool CheckLeftDiagonal()
        {
            if (bingoBoard.CheckLeftDiagonal() == true)
            {
                for (int i = 0; i < labels.GetLength(0); i++)
                {
                    for (int j = 0; j < labels.GetLength(1); j++)
                    {
                        if (i == j)
                            labels[i, j].BackColor = Color.Yellow;
                    }
                }
                return true;
            }
            return false;
        }

        private bool CheckRightDiagonal()
        {
            if (bingoBoard.CheckRightDiagonal() == true)
            {
                int rightDiagonal = labels.GetLength(1) - 1;
                for (int i = 0; i < labels.GetLength(0); i++)
                {
                    for (int j = 0; j < labels.GetLength(1); j++)
                    {
                        if (j == rightDiagonal)
                            labels[i, j].BackColor = Color.Yellow;
                    }
                    rightDiagonal--;
                }
                return true;
            }
            return false;
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Refresh();
            Application.DoEvents();
            Hide();
            Game newGame = new Game();
            newGame.ShowDialog();
        }
    }
}
