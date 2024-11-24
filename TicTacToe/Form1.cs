using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class MainForm : Form
    {
        private Button[,] boardButtons;
        private int player1Score = 0;
        private int player2Score = 0;
        private int currentPlayer = 1;
        private int boardSize = 11;
        private int winCondition = 5;

        public MainForm()
        {
            InitializeComponent();
            InitializeGameBoard();
        }

        private void InitializeGameBoard()
        {
            boardButtons = new Button[boardSize, boardSize];

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    Button button = new Button
                    {
                        Width = tableLayoutPanel.Width / boardSize,
                        Height = tableLayoutPanel.Height / boardSize,
                        Tag = new Point(row, col),
                        Text = string.Empty,
                        Font = new Font("Arial", 24, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    button.Click += ButtonClick;
                    boardButtons[row, col] = button;

                    tableLayoutPanel.Controls.Add(button, col, row);
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.Text != string.Empty)
                return;

            if (currentPlayer == 1)
            {
                clickedButton.Text = "X";
            }
            else
            {
                clickedButton.Text = "O";
            }

            if (CheckForWinner())
            {
                MessageBox.Show($"Player {currentPlayer} won!");
                UpdateScore();
                ResetBoard();
            }
            else
            {
                currentPlayer = (currentPlayer == 1) ? 2 : 1;
            }
        }

        private bool CheckForWinner()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (boardButtons[row, col].Text != string.Empty)
                    {
                        if (CheckDirection(row, col, 1, 0) ||
                            CheckDirection(row, col, 0, 1) ||
                            CheckDirection(row, col, 1, 1) ||
                            CheckDirection(row, col, 1, -1))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool CheckDirection(int row, int col, int dRow, int dCol)
        {
            string playerSymbol = boardButtons[row, col].Text;
            int count = 1;

            for (int i = 1; i < winCondition; i++)
            {
                int newRow = row + i * dRow;
                int newCol = col + i * dCol;

                if (newRow >= 0 && newRow < boardSize && newCol >= 0 && newCol < boardSize &&
                    boardButtons[newRow, newCol].Text == playerSymbol)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i < winCondition; i++)
            {
                int newRow = row - i * dRow;
                int newCol = col - i * dCol;

                if (newRow >= 0 && newRow < boardSize && newCol >= 0 && newCol < boardSize &&
                    boardButtons[newRow, newCol].Text == playerSymbol)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count >= winCondition;
        }

        private void UpdateScore()
        {
            if (currentPlayer == 1)
                player1Score++;
            else
                player2Score++;

            lblPlayer1Score.Text = $"Player 1 (X): {player1Score}";
            lblPlayer2Score.Text = $"Player 2 (O): {player2Score}";
        }

        private void ResetBoard()
        {
            foreach (Button button in boardButtons)
            {
                button.Text = string.Empty;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetBoard();
            player1Score = 0;
            player2Score = 0;
            lblPlayer1Score.Text = "Player 1 (X): 0";
            lblPlayer2Score.Text = "Player 2 (O): 0";
            currentPlayer = 1;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetBoard();
            currentPlayer = 1;
        }
    }
}
