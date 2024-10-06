using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace TicTacGame
{
    struct Position
    {
        public bool P1;
        public bool P2;
        public bool P3;
        public bool P4;
        public bool P5;
        public bool P6;
        public bool P7;
        public bool P8;
        public bool P9;
    };
    public partial class Form1 : Form
    {
        private Timer timer;
        private bool OnAndOff = false;
        private bool ChaningPlayer = true;
        private short Player1WinTimes = 0;
        private short Player2WinTimes = 0;
        

        Position Player1;
        Position Player2;
        Position ClickedButtons;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(OnAndOff == true)
            {
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.Crimson;
                OnAndOff = false;
            }
            else
            {
                label2.ForeColor = Color.Crimson;
                label3.ForeColor = Color.White;
                OnAndOff = true;
            }
        }

        private void ResestForNewGame(ref Position Player)
        {
            Player.P1 = false;
            Player.P2 = false;
            Player.P3 = false;
            Player.P4 = false;
            Player.P5 = false;
            Player.P6 = false;
            Player.P7 = false;
            Player.P8 = false;
            Player.P9 = false;
        }

        private void ResetClickedButtons()
        {
            ClickedButtons.P1 = false;
            ClickedButtons.P2 = false;
            ClickedButtons.P3 = false;
            ClickedButtons.P4 = false;
            ClickedButtons.P5 = false;
            ClickedButtons.P6 = false;
            ClickedButtons.P7 = false;
            ClickedButtons.P8 = false;
            ClickedButtons.P9 = false;
        }

        void PosisionSelected(Guna2Button ButtonSelected, ref Position Player)
        {
            if (ButtonSelected == Pos1)
                Player.P1 = true;
            else if (ButtonSelected == Pos2)
                Player.P2 = true;
            else if (ButtonSelected == Pos3)
                Player.P3 = true;
            else if (ButtonSelected == Pos4)
                Player.P4 = true;
            else if (ButtonSelected == Pos5)
                Player.P5 = true;
            else if (ButtonSelected == Pos6)
                Player.P6 = true;
            else if (ButtonSelected == Pos7)
                Player.P7 = true;
            else if (ButtonSelected == Pos8)
                Player.P8 = true;
            else
                Player.P9 = true;
        }

        private bool ButtonClicked(Guna2Button ButtonSelected)
        {
            if (ButtonSelected == Pos1)
                if (ClickedButtons.P1 == false)
                    ClickedButtons.P1 = true;
                else
                    return true;
            else if (ButtonSelected == Pos2)
                if (ClickedButtons.P2 == false)
                    ClickedButtons.P2 = true;
                else
                    return true;
            else if (ButtonSelected == Pos3)
                if (ClickedButtons.P3 == false)
                    ClickedButtons.P3 = true;
                else
                    return true;
            else if (ButtonSelected == Pos4)
                if (ClickedButtons.P4 == false)
                    ClickedButtons.P4 = true;
                else
                    return true;
            else if (ButtonSelected == Pos5)
                if (ClickedButtons.P5 == false)
                    ClickedButtons.P5 = true;
                else
                    return true;
            else if (ButtonSelected == Pos6)
                if (ClickedButtons.P6 == false)
                    ClickedButtons.P6 = true;
                else
                    return true;
            else if (ButtonSelected == Pos7)
                if (ClickedButtons.P7 == false)
                    ClickedButtons.P7 = true;
                else
                    return true;
            else if (ButtonSelected == Pos8)
                if (ClickedButtons.P8 == false)
                    ClickedButtons.P8 = true;
                else
                    return true;
            else if(ButtonSelected == Pos9)
                if (ClickedButtons.P9 == false)
                    ClickedButtons.P9 = true;
                else
                    return true;

            return false;
        }

        private void IsCompeletePosition(Position Player)
        {
            if ((Player.P1 && Player.P2 && Player.P3) == true ||
                (Player.P4 && Player.P5 && Player.P6) == true ||
                (Player.P7 && Player.P8 && Player.P9) == true ||//Until here statements of rows 
                (Player.P1 && Player.P4 && Player.P7) == true ||
                (Player.P2 && Player.P5 && Player.P8) == true ||
                (Player.P3 && Player.P6 && Player.P9) == true ||//Until here statments of cloumns
                (Player.P1 && Player.P5 && Player.P9) == true ||
                (Player.P3 && Player.P5 && Player.P7) == true)//Until here statments of cross
            {
                if(Player.Equals(Player1))
                {
                    MessageBox.Show("Player1 Won");
                    Player1WinTimes += 1;
                }
                else
                {
                    MessageBox.Show("Player2 Won");
                    Player2WinTimes += 1;
                }
                RestartTheGame();
            }
        }

        private void Click_Position(object sender, EventArgs e)
        {
            Guna2Button ButtonClick = (Guna2Button)sender;
            if (ButtonClicked(ButtonClick) == true)
                return;

            if (ChaningPlayer)
            {
                PosisionSelected(ButtonClick, ref Player1);
                ButtonClick.Image = Image.FromFile("TicTacGame\\Resources\\close (1).png");
                IsCompeletePosition(Player1);
                ChaningPlayer = false;
            }
            else
            {
                PosisionSelected(ButtonClick, ref Player2);
                ButtonClick.Image = Image.FromFile("TicTacGame\\Resources\\letter-o.png");
                IsCompeletePosition(Player2);
                ChaningPlayer = true;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void RestartTheGame()
        {
            this.Controls.Clear();
            InitializeComponent();
            ResestForNewGame(ref Player1);
            ResestForNewGame(ref Player2);
            ResetClickedButtons();
            label5.Text = Player1WinTimes.ToString();
            label6.Text = Player2WinTimes.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RestartTheGame();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
