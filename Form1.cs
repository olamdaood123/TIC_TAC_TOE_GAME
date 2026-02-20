using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE_GAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255);
            Pen Pen = new Pen(White);
            Pen.Width = 10;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(Pen, 300, 150, 600, 150);
            e.Graphics.DrawLine(Pen, 300, 250, 600, 250);
            e.Graphics.DrawLine(Pen, 400, 50, 400, 350);
            e.Graphics.DrawLine(Pen, 500, 50, 500, 350);
        }
        public enum en_Player
        {
            player1, player2
        };
        en_Player CurrentTurn = en_Player.player1;
        int Count = 0;
        en_Player Torn()
        {
            if (CurrentTurn == en_Player.player1)
            {
                CurrentTurn = en_Player.player2;
            }
            else
            {
                CurrentTurn = en_Player.player1;
            }
            return CurrentTurn;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            lb_Turn.Text = "Player 1";
            if (CurrentTurn == en_Player.player1)
            {
                pb.Image = Properties.Resources.pp_X;
                lb_Turn.Text = "player 2";
                pb.Enabled = false;
                pb.Tag = "X";
                Count++;

            }
            else
            {
                pb.Image = Properties.Resources.pp_O;
                lb_Turn.Text = "Player 1";
                pb.Enabled = false;
                pb.Tag = "O";
                Count++;
            }
            Torn();
            ChickWinner();
        }
        public void DeactiveButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name.StartsWith("pb_Box"))
                {
                   
                    c.Enabled = false;
                }
            }
        }
        public void ChickWinner()
        {
            if (pb_Box1.Tag.ToString() != "?")
            {
                if (pb_Box1.Tag.ToString() == pb_Box2.Tag.ToString() && pb_Box2.Tag.ToString() == pb_Box3.Tag.ToString())
                {
                    MessageBox.Show("Winner Is " + pb_Box1.Tag.ToString(), "WINNER", MessageBoxButtons.OK);
                    lb_winner.Text = pb_Box1.Tag.ToString();
                    DeactiveButtons();
                }

            }
            if (pb_Box4.Tag.ToString() != "?")
            {
                if (pb_Box4.Tag.ToString() == pb_Box5.Tag.ToString() && pb_Box5.Tag.ToString() == pb_Box6.Tag.ToString())
                {
                    MessageBox.Show("Winner Is " + pb_Box4.Tag.ToString(), "WINNER", MessageBoxButtons.OK);
                    lb_winner.Text = pb_Box4.Tag.ToString();
                    DeactiveButtons();
                }
            }
            if (pb_Box7.Tag.ToString() != "?")
            {
                if (pb_Box7.Tag.ToString() == pb_Box8.Tag.ToString() && pb_Box8.Tag.ToString() == pb_Box9.Tag.ToString())
                {
                    MessageBox.Show("Winner Is " + pb_Box7.Tag.ToString(), "WINNER", MessageBoxButtons.OK);
                    lb_winner.Text = pb_Box7.Tag.ToString();
                    DeactiveButtons();
                }
            }
            if (pb_Box1.Tag.ToString() != "?")
            {
                if (pb_Box1.Tag.ToString() == pb_Box4.Tag.ToString() && pb_Box4.Tag.ToString() == pb_Box7.Tag.ToString())
                {
                    MessageBox.Show("Winner Is " + pb_Box1.Tag.ToString(), "WINNER", MessageBoxButtons.OK);
                    lb_winner.Text = pb_Box1.Tag.ToString();
                    DeactiveButtons();
                }
            }
            if (pb_Box2.Tag.ToString() != "?")
            {
                if (pb_Box2.Tag.ToString() == pb_Box5.Tag.ToString() && pb_Box5.Tag.ToString() == pb_Box8.Tag.ToString())
                {
                    MessageBox.Show("Winner Is " + pb_Box2.Tag.ToString(), "WINNER", MessageBoxButtons.OK);
                    lb_winner.Text = pb_Box2.Tag.ToString();
                    DeactiveButtons();
                }
            }
            if (pb_Box3.Tag.ToString() != "?")
            {
                if (pb_Box3.Tag.ToString() == pb_Box6.Tag.ToString() && pb_Box6.Tag.ToString() == pb_Box9.Tag.ToString())
                {
                    MessageBox.Show("Winner Is " + pb_Box3.Tag.ToString(), "WINNER", MessageBoxButtons.OK);
                    lb_winner.Text = pb_Box3.Tag.ToString();
                    DeactiveButtons();
                }
            }
            if (pb_Box1.Tag.ToString() != "?")
            {
                if (pb_Box1.Tag.ToString() == pb_Box5.Tag.ToString() && pb_Box5.Tag.ToString() == pb_Box9.Tag.ToString())
                {
                    MessageBox.Show("Winner Is " + pb_Box1.Tag.ToString(), "WINNER", MessageBoxButtons.OK);
                    lb_winner.Text = pb_Box1.Tag.ToString();
                    DeactiveButtons();
                }
            }
            if (pb_Box3.Tag.ToString() != "?")
            {
                if (pb_Box3.Tag.ToString() == pb_Box5.Tag.ToString() && pb_Box5.Tag.ToString() == pb_Box7.Tag.ToString())
                {
                    MessageBox.Show("Winner Is " + pb_Box3.Tag.ToString(), "WINNER", MessageBoxButtons.OK);
                    lb_winner.Text = pb_Box3.Tag.ToString();
                    DeactiveButtons();
                }
            }
            if (Count == 9)
            {
                MessageBox.Show("No Winner", "Game Over !!!", MessageBoxButtons.OK);
                DeactiveButtons();
            }

        }

        private void bt_RestartGame_Click(object sender, EventArgs e)
        {
            Count = 0;
            CurrentTurn = en_Player.player1;
            lb_Turn.Text = "Player1";
            lb_winner.Text = "In Progress";

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name.StartsWith("pb_Box"))
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = Properties.Resources.pp_Q;
                    pb.Tag = "?";
                    pb.Enabled = true;
                }
            }
        }
    }
}
