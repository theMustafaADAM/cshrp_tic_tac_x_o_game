using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xo_tic_tac
{
    public partial class tictacXO : Form
    {
        public tictacXO()
        {
            InitializeComponent();
        }

        stGameStatus GameStatus;

        enum enPlayer { frstPlayer = 1, scndPlayer = 2 }
        enum enWinner { frstPlayer = 1, scndPlayer = 2 , Draw, GameInProgress }
        
        enPlayer PlayerTurn = enPlayer.frstPlayer;  

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        void EndGame()
        {
            lblTurn.Text = "Game Over";
            switch(GameStatus.Winner)
            {
                case enWinner.frstPlayer: lblwinner.Text = "1st Player"; break;
                case enWinner.scndPlayer: lblwinner.Text = "2nd Player"; break;
                default : lblwinner.Text = "It's Draw !!"; break;
            }

            MessageBox.Show("GAME OVER", "game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if(btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Lime;
                btn2.BackColor = Color.Lime;
                btn3.BackColor = Color.Lime;

                if(btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.frstPlayer;
                    GameStatus.GameOver = true;
                    EndGame();
                    ReStartGame();
                    return true;
                } else
                {
                    GameStatus.Winner = enWinner.scndPlayer;
                    GameStatus.GameOver = true;
                    EndGame();
                    ReStartGame();
                    return true;
                }
            }

            GameStatus.GameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            // checking rows

            // horizental rows
            if (CheckValues(btn1, btn2, btn3)) return;
            if (CheckValues(btn4, btn5, btn6)) return;
            if (CheckValues(btn7, btn8, btn9)) return;

            // Vertical rows
            if (CheckValues(btn1, btn4, btn7)) return;
            if (CheckValues(btn2, btn5, btn8)) return;
            if (CheckValues(btn3, btn6, btn9)) return;

            // X rows
            if (CheckValues(btn1, btn5, btn9)) return;
            if (CheckValues(btn7, btn5, btn3)) return;
        }

        public void changeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.frstPlayer:
                        btn.Image = Properties.Resources.X;
                        PlayerTurn = enPlayer.scndPlayer;
                        lblTurn.Text = "2nd Player";
                        ++GameStatus.PlayCount;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.scndPlayer:
                        btn.Image = Properties.Resources.O;
                        PlayerTurn = enPlayer.frstPlayer;
                        lblTurn.Text = "1st Player";
                        ++GameStatus.PlayCount;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }

            else { MessageBox.Show("Selected already", "Pass", MessageBoxButtons.OK); }

            if (GameStatus.PlayCount == 9) 
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
                ReStartGame();
            }

        }

        private void ReSetButton(Button btn)
        {
            btn.Image = Properties.Resources.Q;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        private void ReStartGame()
        {
            ReSetButton(btn1);
            ReSetButton(btn2);
            ReSetButton(btn3);
            ReSetButton(btn4);
            ReSetButton(btn5);
            ReSetButton(btn6);
            ReSetButton(btn7);
            ReSetButton(btn8);
            ReSetButton(btn9);

            PlayerTurn = enPlayer.frstPlayer;
            lblTurn.Text = "1st Player";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lblwinner.Text = "In Progress";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReStartGame();
        }

        private void tictacXO_Paint(object sender, PaintEventArgs e)
        {
            Color purple = Color.FromArgb(128, 0, 128);
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen WhitePen = new Pen(White);
            Pen PurplePen = new Pen(purple);
            PurplePen.Width = 15;
            WhitePen.Width = 15;

            WhitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            PurplePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            WhitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            PurplePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Horizental
            e.Graphics.DrawLine(PurplePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(PurplePen, 400, 460, 1050, 460);

            //Vertical
            e.Graphics.DrawLine(WhitePen, 610, 140, 610, 620);
            e.Graphics.DrawLine(WhitePen, 840, 140, 840, 620);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReStartGame();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            changeImage(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            changeImage(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            changeImage(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            changeImage(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            changeImage(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            changeImage(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            changeImage(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            changeImage(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            changeImage(btn9);
        }
    }
}
