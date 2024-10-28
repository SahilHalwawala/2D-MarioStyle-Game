namespace SahilHalwawala_Assignment2
{
    public partial class Form1 : Form
    {

        //jumping variables
        private bool isJumping = false;
        int jumpHeight = 20;//jump height
        int gravity = 1;//gravity effect
        int groundHeight; //height of the ground, to be used for resetting the player to the ground
        bool isCoin1Captured = false;
        bool isCoin2Captured = false;
        bool isCoin3Captured = false;
        bool isCoin4Captured = false;
        bool isCoinAllCaptured = false;
        int timeItTook;
        int PlayerScore;

        //Code for moving Enemy1
        private int Enemy1Runs = 6;
        private bool Enemy1Left = true;
        private bool Enemy1Right = false;

        //Code for moving Enemy1
        private int Enemy2Runs = 6;
        private bool Enemy2Left = true;
        private bool Enemy2Right = false;






        //rightMovement
        private bool isGoingRight = false;

        //left Movement
        private bool isGoingLeft = false;

        //time related variables
        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();
            groundHeight = this.ClientSize.Height - player.Height;
            timer1.Start();
            startTime = DateTime.Now;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && !isGoingLeft)
            {//start moving left
                isGoingLeft = true;
            }

            if (e.KeyCode == Keys.Right && !isGoingRight)//start moving right
            {
                isGoingRight = true;
            }

            if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true;
            }
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //stop going left
            {
                isGoingLeft = false;
            }

            if (e.KeyCode == Keys.Right) //stop going right
            {
                isGoingRight = false;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            //calculating of time elapsing
            TimeSpan elapsedTime = DateTime.Now - startTime;
            TimeSpan timer = DateTime.Now - startTime;

            if (Enemy1Left && Enemy1.Location.X > this.ClientSize.Width / 2)
            {
                Enemy1.Left = Enemy1.Location.X - Enemy1Runs;
            }
            else
            { //enemy has reached the middle of the form on the x-axis
                Enemy1Left = false;
                Enemy1Right = true;

            }
            //enemy changes direction and starts moving right till it reaches the right end of the form boundary
            if (Enemy1Right && Enemy1.Location.X < this.ClientSize.Width + (Enemy1.Width + EndGame.Width - this.ClientSize.Width / 3))
            {
                Enemy1.Left = Enemy1.Location.X + Enemy1Runs;
            }
            else
            { //enemy has reached the end of the form, and should change direction to left
                Enemy1Right = false;
                Enemy1Left = true;
            }

            if (Enemy2Left && Enemy2.Location.X > this.ClientSize.Width / 2)
            {
                Enemy2.Left = Enemy2.Location.X - Enemy2Runs;
            }
            else
            { //enemy has reached the middle of the form on the x-axis
                Enemy2Left = false;
                Enemy2Right = true;

            }
            //enemy changes direction and starts moving right till it reaches the right end of the form boundary
            if (Enemy1Right && Enemy2.Location.X < this.ClientSize.Width + (Enemy2.Width + EndGame.Width - this.ClientSize.Width / 2.5))
            {
                Enemy2.Left = Enemy2.Location.X + Enemy2Runs;
            }
            else
            { //enemy has reached the end of the form, and should change direction to left
                Enemy2Right = false;
                Enemy2Left = true;
            }




            //Code for jumping logic
            if (isJumping)
            {
                player.Top -= jumpHeight; //move the player up
                jumpHeight -= gravity;//bringing the player downwards slowly under gravity

                //check if the player has landed
                if (player.Top >= groundHeight)
                {//check against ground height
                    player.Top = groundHeight;//reset the player to the ground
                    isJumping = false;//reset the jumping flag
                    jumpHeight = 16;//reset the jump height for the next jump on the press of Space key again
                }

            }
            else
            {
                if (player.Top < groundHeight)
                {
                    player.Top += gravity + 4;
                }
            }

            //code for right movement logic
            if (isGoingRight)
            {
                player.Left += 7;
            }

            //code for left movement logic
            if (isGoingLeft)
            {
                player.Left -= 7;
            }

            //Code when the player intersect with platform 2 then jump gets reset to false and Jump height gets reset to 16
            if (player.Bounds.IntersectsWith(Platform1.Bounds))
            {
                player.Top = Platform1.Top - player.Height;

                isJumping = false;
                jumpHeight = 16;
            }


            if (player.Bounds.IntersectsWith(Platform2.Bounds))
            {
                player.Top = Platform2.Top - player.Height;
                isJumping = false;
                jumpHeight = 16;
            }

            //Code for checking of tha player when intersect
            if (player.Top == Platform1.Top - player.Height && (player.Left < Platform1.Left || player.Right > Platform1.Right) || player.Top == Platform2.Top - player.Height && (player.Left < Platform2.Left || player.Right > Platform2.Right))
            {
                isJumping = false;
            }

            LabelForTime.Text = "Time Elapsed: " + elapsedTime.Seconds + " seconds";

            LabelForScore.Text = "RunningScore: " + PlayerScore;

            //Code for collecting coin 1 and makes coin 1 invisible
            if (!isCoin1Captured && Coin1.Bounds.IntersectsWith(player.Bounds))
            {
                isCoin1Captured = true;
                Coin1.Visible = false;
                PlayerScore += 10;

            }

            //Code for collecting coin 2 and makes coin 2 invisible
            if (!isCoin2Captured && Coin2.Bounds.IntersectsWith(player.Bounds))
            {
                isCoin2Captured = true;
                Coin2.Visible = false;
                PlayerScore += 10;


            }

            //Code for collecting coin 3 and makes coin 3 invisible
            if (!isCoin3Captured && Coin3.Bounds.IntersectsWith(player.Bounds))
            {
                isCoin3Captured = true;
                Coin3.Visible = false;
                PlayerScore += 10;


            }

            //Code for collecting coin 4 and makes coin 4 invisible
            if (!isCoin4Captured && Coin4.Bounds.IntersectsWith(player.Bounds))
            {
                isCoin4Captured = true;
                Coin4.Visible = false;
                PlayerScore += 10;

            }

            if(player.Bounds.IntersectsWith(Obstacle.Bounds))
            {
                PlayerScore -= 5;
            }

            //When player hits the boundary of enemy 1 
            if (player.Bounds.IntersectsWith(Enemy1.Bounds))
            {
                gameOver(elapsedTime.Seconds);
                MessageBox.Show("Uff!! You hit the enemy");
            }

            //When player hits the boundary of enemy 2
            if (player.Bounds.IntersectsWith(Enemy2.Bounds))
            {
                gameOver(elapsedTime.Seconds);
                MessageBox.Show("Uff!! You hit the enemy");
            }

           // When player hits the boundary Obstacle
            if (player.Bounds.IntersectsWith(Obstacle.Bounds))
            {
                gameOver(elapsedTime.Seconds);
                MessageBox.Show("Uff!! You hit the obstacle");
            }

            //When all the coins are captured and player intersects with the endgame boundary
            if (isCoin1Captured == true && isCoin2Captured == true && isCoin3Captured == true && isCoin4Captured == true && EndGame.Bounds.IntersectsWith(player.Bounds))
            {
                gameOver(elapsedTime.Seconds);
                MessageBox.Show($"You won the Game. Time Taken: {timer.Seconds} Seconds");
                MessageBox.Show($"Your Score: {PlayerScore}");
            }

            if (elapsedTime.TotalSeconds > 59)
            { 
                LabelForTime.Text = "Time Elapsed: " + elapsedTime.Minutes + elapsedTime.Seconds + " seconds";
            }



        }

        //Code for game over and makes everything disable
        private void gameOver(int timeItTook)
        {
            timer1.Stop();
            player.Visible = false;
            Coin1.Visible = false;
            Coin2.Visible = false;
            Coin3.Visible = false;
            Coin4.Visible = false;
            Platform1.Visible = false;
            Platform2.Visible = false;
            Enemy2.Visible = false;
            Enemy1.Visible = false;
            EndGame.Visible = false;
            Obstacle.Visible = false;
            isJumping = false;
            isGoingLeft = false;
            isGoingRight = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
