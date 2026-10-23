using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayın_Tarlası
{
    public partial class GameForm : Form
    {
        int rows, cols, mines , size;
        int[,] board;
        Button[,] buttons;

        public GameForm(int r, int c, int m, int s)
        {
            InitializeComponent();
            rows = r;
            cols = c;
            mines = m;
            size = s;

            StartGame();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void StartGame()
        {
            Create();
            Place();
            CalculateNumbers();
        }

        private void Create()
        {

            board = new int[rows, cols];
            buttons = new Button[rows, cols];

            this.Width = (cols * size) + (size*3) - (size/2);
            this.Height = rows * size + size;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Button b = new Button();
                    b.Width = size;
                    b.Height = size;
                    b.Location = new Point(c * size, r * size);
                    b.Tag = new Point(r, c);
                    b.MouseUp += CellClick;

                    this.Controls.Add(b);
                    buttons[r, c] = b;
                }
            }

            Button menuButton = new Button();
            menuButton.Width = size;
            menuButton.Height = size;
            menuButton.Location = new Point((rows * size) + size, 0);
            menuButton.Text = "⬅️";
            menuButton.Click += MenuButton_Click;
            this.Controls.Add(menuButton);

            Button restartButton = new Button();
            restartButton.Width = size;
            restartButton.Height = size;
            restartButton.Location = new Point((rows * size) + size, size);
            restartButton.Text = "⭮";
            restartButton.Click += RestartButton_Click;
            this.Controls.Add(restartButton);

            Button closeButton = new Button();
            closeButton.Width = size;
            closeButton.Height = size;
            closeButton.Location = new Point((rows * size) + size, size*2);
            closeButton.Text = "❌";
            closeButton.Click += CloseButton_Click;
            this.Controls.Add(closeButton);

        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            foreach (Button b in buttons)
            {
                this.Controls.Remove(b);
                b.Dispose();
            }

            StartGame();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Place()
        {
            Random rnd = new Random();
            int placed = 0;

            while (placed < mines)
            {
                int r = rnd.Next(rows);
                int c = rnd.Next(cols);

                if (board[r, c] == -1) continue;

                board[r, c] = -1;
                placed++;
            }
        }

        private void CalculateNumbers()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (board[r, c] == -1) continue;

                    int count = 0;

                    for (int rr = -1; rr <= 1; rr++)
                    {
                        for (int cc = -1; cc <= 1; cc++)
                        {
                            int nr = r + rr;
                            int nc = c + cc;

                            if (nr >= 0 && nr < rows && nc >= 0 && nc < cols)
                            {
                                if (board[nr, nc] == -1)
                                    count++;
                            }
                        }
                    }

                    board[r, c] = count;
                }
            }
        }


        private void CellClick(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Point p = (Point)b.Tag;
            int r = p.X;
            int c = p.Y;

            if (e.Button == MouseButtons.Right)
            {
                if (b.Text == "🚩") b.Text = "";
                else b.Text = "🚩";
                return;
            }

            Reveal(r, c);
        }


        private void Reveal(int r, int c)
        {
            Button b = buttons[r, c];
            if (!b.Enabled) return;

            b.Enabled = false;

            if (board[r, c] == -1)
            {
                b.Text = "💣";
                b.BackColor = Color.Red;
                GameOver();
                return;
            }

            if (board[r, c] > 0)
            {
                b.Text = board[r, c].ToString();
                b.BackColor = Color.LightGreen;
                return;
            }

            // boşsa çevresini aç
            b.Text = "";
            b.BackColor = Color.LightGreen;

            for (int rr = -1; rr <= 1; rr++)
            {
                for (int cc = -1; cc <= 1; cc++)
                {
                    int nr = r + rr;
                    int nc = c + cc;

                    if (nr >= 0 && nr < rows && nc >= 0 && nc < cols)
                        Reveal(nr, nc);
                }
            }
        }


        private void GameOver()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (board[r, c] == -1)
                    {
                        buttons[r, c].Text = "💣";
                        buttons[r, c].BackColor = Color.IndianRed;
                    }
                }
            }

            MessageBox.Show("Mayına bastın! Oyun bitti.");
        }

        private void GameForm_Leave(object sender, EventArgs e)
        {

        }
    }
}
