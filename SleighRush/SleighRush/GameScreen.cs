using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Purpose of this program:
/// An interactive game for the MEAU Christmas Contest.
/// This game will be played on the CNC M
/// </summary>
namespace SleighRush
{
    public partial class GameScreen : Form
    {
        //global variables
        int sleighSpeed = 5;
        int skySpeed = 5;
        bool sleighLeft;
        bool sleighRight;
        int trafficSpeed = 5;
        int Score = 0;
        Random rnd = new Random();

        private void Reset()
        {
            //trophy.Visible = false; //hide the trophy image
            Start.Enabled = false; //Disable the button when game is running
            Leader.Enabled = true ; //Disabled while game is running
            explosion.Visible = false; //Hide the explosion image
            trafficSpeed = 5; //Set default traffic speed
            sleighSpeed = 5; //Set the road speed back to default

            Score = 0; //Reset score to 0

            player.Left = 161; //Reset player left
            player.Top = 286; //Reset player top

            sleighLeft = false;  //Reset moving left to false
            sleighRight = false; //Reset moving right to false

            //Move the AI to default position this will be off the screen
            AI1.Left = 66;
            AI1.Top = -120;

            AI2.Left = 294;
            AI2.Top = -185;

            //Reset the road to their default position
            skyTrack2.Left = -3;
            skyTrack2.Top = -222;
            skyTrack1.Left = -2;
            skyTrack1.Top = -638;

            //Start the timer
            timer1.Start();
        }//end of Reset

        public GameScreen()
        {
            InitializeComponent();
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Score++; //Increase the score for each progression

            distance1.Text = "" + Score; //show the score on the distance label

            skyTrack1.Top += skySpeed; //Move the track 1 & 2 down with the +=
            skyTrack2.Top += skySpeed;

            //If the track has gone past -630 then set it back to default
            
            if(skyTrack1.Top > 630)
            {
                skyTrack1.Top = -630;
            }
            if(skyTrack2.Top > 630)
            {
                skyTrack2.Top = -630;
            }
            //end of track animation
            if(sleighLeft) { player.Left -= sleighSpeed; } //Move the sleigh if the sleigh left is true
            if(sleighRight) { player.Left += sleighSpeed; } //Move the sleigh if the sleigh right is true
            //end of sleigh movement

            //bounce the sleigh off boundaries of the panel
            if (player.Left < 1)
            {
                sleighLeft = false; //stop the sleigh from going off screen
            }
            else if (player.Left + player.Width > 380)
            {
                sleighRight = false;

            }

            //Move AI Objects down
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            //Respawn the AIs and change their images
            if(AI1.Top > panel1.Height)
            {
                changeAI1(); //Change the AI images once they left screen
                AI1.Left = rnd.Next(2, 160); //Random numbers where they appear on the left
                AI1.Top = rnd.Next(100, 200) * -1; //Random numbers where they appear on the Top

            }
            if(AI2.Top > panel1.Height)
            {
                changeAI2();
                AI2.Left = rnd.Next(185, 327); //Change numbers where they appear on the left
                AI2.Top = rnd.Next(100, 200) * -1; //Random numbers where they appear on top
            }
            //end of respawning AIs and the image changing

            //This is the Hit Test on player and AI
            //The conditional statements below will test if player hits AI or AI hits player
            if(player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver(); //This is run when the player gets hit by an object (AI)
            }
            //end of the Hit Test

            //Speeding up traffic
            //If Score is above 100 AND Below 500
            if(Score > 100 && Score < 500)
            {
                trafficSpeed = 6;
                skySpeed = 7;
            }
            //if score is above 500 AND Below 1000
           else if(Score > 500 && Score < 1000)
            {
                trafficSpeed = 7;
                skySpeed = 8;
            }
            //if score is above 1200
            else if(Score > 1200)
            {
                trafficSpeed = 9;
                skySpeed = 10;
            }
            else if(Score > 1400)
            {
                trafficSpeed = 11;
                skySpeed = 13;
            }
            //end of traffic speeding

            
        }

        private void moveCar(object sender, KeyEventArgs e)
        {
            //if pressed the lft key AND the player is inside the panel
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                sleighLeft = true;
            }
            //if player pressed the right key and the player left plus player width is less then the panel1 width
            //then we set player right to true
            if (e.KeyCode == Keys.Right && player.Left + player.Width < panel1.Width)
            {
                sleighRight = true;
            }
        }

        private void stopCar(object sender, KeyEventArgs e)
        {
            //if the LEFT key is up we set the car left to false
            if (e.KeyCode == Keys.Left)
            {
                sleighLeft = false;
            }
            //if the RIGHT key is up we set the car right to false;
            if (e.KeyCode == Keys.Right)
            {
                sleighRight = false;
            }
        }

        //Switch case where the images will cycle through
       private void changeAI1()
        {
            int num = rnd.Next(1, 7);
            switch (num)
            {
                case 1:
                    AI1.Image = Properties.Resources.airballoon;
                    break;
                case 2:
                    AI1.Image = Properties.Resources.fighter;
                    break;
                case 3:
                    AI1.Image = Properties.Resources.rocket1;
                    break;
                case 4:
                    AI1.Image = Properties.Resources.flock;
                    break;
                case 5:
                    AI1.Image = Properties.Resources.comet;
                    break;
                case 6:
                    AI1.Image = Properties.Resources.satellite;
                    break;
                case 7:
                    AI1.Image = Properties.Resources.rocket2;
                    break;
                default:
                    break;
                    
            }
        }//end of changeAI1

        //ChangeAI2
        private void changeAI2()
        {
            int num = rnd.Next(1, 7);
            switch (num)
            {
                case 1:
                    AI2.Image = Properties.Resources.rocket2;
                    break;
                case 2:
                    AI2.Image = Properties.Resources.fighter;
                    break;
                case 3:
                    AI2.Image = Properties.Resources.flock;
                    break;
                case 4:
                    AI2.Image = Properties.Resources.satellite;
                    break;
                case 5:
                    AI2.Image = Properties.Resources.rocket1;
                    break;
                case 6:
                    AI2.Image = Properties.Resources.comet;
                    break;
                case 7:
                    AI2.Image = Properties.Resources.airballoon;
                    break;
                default:
                    break;
                
            }
        }//end of changeAI2
        private void gameOver()
        {
            timer1.Stop();

            Start.Enabled = true;

            //showing the explosion image on top of sleigh
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            explosion.BringToFront();


        }//end of gameOver

        private void Start_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void skyTrack1_Click(object sender, EventArgs e)
        {

        }

        private void LeaderboardButtonClicked(object sender, EventArgs e)
        {
            this.Hide();
            LeaderBoard leaderboardForm = new LeaderBoard();
            leaderboardForm.ShowDialog();
            this.Close();
        }
    }//end of GameScreen : form
}//end of namespace
