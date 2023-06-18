using System.Reflection.Metadata.Ecma335;

namespace T_Rex_Endless_Runner_Project
{
    public partial class Form1 : Form
    {

        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;

        List<int> obstaclePositions = new List<int>();
        //List to store obstacle positions

        public Form1()
        {
            InitializeComponent();

            GameReset();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            trex.Top += jumpSpeed;
            txtScore.Text = "Score:" + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            //modified fall speed for floaty jumps + added a double jump
            else
            {
                jumpSpeed += 1;
            }

            if (trex.Top > 366 && jumping == false)
            {
                force = 12;
                trex.Top = 367;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        ///generate a new position until the obstacles don't collide
                        do
                        {
                            position = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        }
                        while (ObstacleCollides(position));

                        //update obstacle position
                        x.Left = position;
                        score++;
                    }
                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        trex.Image = Properties.Resources.dead;
                        txtScore.Text += "Press R to restart the game!";
                        isGameOver = true;
                    }

                }
            }

            if (score > 5)
            {
                obstacleSpeed = 15;
            }
            if (score > 10)
            {
                obstacleSpeed = 20;
            }
            if (score > 15)
            {
                obstacleSpeed = 25;
            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }
        //created obstacle collides method
        private bool ObstacleCollides(int position)
        {
            foreach (int obstaclePos in obstaclePositions)
            {
                if(Math.Abs(obstaclePos - position) < 100)
                {
                    return true;
                }
            }
            return false;
        }

        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score: " + score;
            trex.Image = Properties.Resources.running;
            isGameOver = false;
            trex.Top = 367;

            //clear obstaclePositions list to avoid crashes and set static first time spawn positions
            obstaclePositions.Clear();

            obstaclePositions.Add(500);

            obstaclePositions.Add(1000);

            obstaclePositions.Add(1500);

            obstaclePositions.Add(2000);

            //Added static first time spawn positions

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    //Retrieve the position from the obstacle positions list
                    position = obstaclePositions[0];

                    // Remove the retireved position from the obstaclePositions list
                    obstaclePositions.RemoveAt(0);

                    //update the position of the obstacle
                    x.Left = position;

                    //Added code to prevent duplicate or colliding first time spawns
                }
            }
            gameTimer.Start();


        }
    }
}