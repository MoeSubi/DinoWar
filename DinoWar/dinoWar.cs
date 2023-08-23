using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 
using WMPLib;
using System.IO;
namespace DinoWar
{
    public partial class dinoWar : Form
    {
        public dinoWar()
        {
            InitializeComponent();


        }
        bool hoverDino;
        int fireballCount;
        string path = "";
        int checkDino = 1;
        bool dinoDirection = true; // ben phai
        bool dinoDodge = false; // dino dung
        int speed; // speed dino
        bool checkEnd = false;
        bool checkMusic = false;
        bool checkSpawnBird = false;
        bool checkSpawnHeart = true;
        bool birdDirection = true; // ben phai
        bool heartDirection;
        int chooseLevel; // lv cua game
        int sound = 0; //doi anh bat tat nhac
        int heartPoint = 0;
        int limit = 644; // chieu dai man hinh
        int checkBtn = 0; // 0 stop moving


        int speedEnemy;
        int checkLoadFireball = 1; // load firebal lan dau`
        int checkLabel;
        int speedBird;

        int fireBallLimit;
        int coinLimit = 2;


        int pointGame = 0;
        int pointCoins = 0;

        Random random = new Random();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        List<PictureBox> boxes = new List<PictureBox>();
        List<PictureBox> fireBall = new List<PictureBox>();
        List<PictureBox> viTri = new List<PictureBox>();
        PictureBox bird = new PictureBox() ;
        PictureBox heart = new PictureBox();
     
        List<PictureBox> Coins = new List<PictureBox>();


        
        int[] SaveViTri = new int[21];


        private void testChuyenDongKhungLong_Load(object sender, EventArgs e)
        {
            hoverDino = true;
            chooseLevel = 1;
            MusicOn(chooseLevel);
            setLv(chooseLevel);
            SetLoca();
            fireballCount = fireBall.Count;
        }

        private void setLv(int n)
        {
            if ( n == 1)
            {
                speed = 20;
                speedEnemy = 20;
                speedBird = 30;
                fireBallLimit = 3;

            }
            else if  ( n == 2)
            {
                speed = 28;
                speedEnemy = 26;
                speedBird = 35;
                fireBallLimit = 4;
            }
            else if ( n == 3)
            { 
                speed = 34;
                speedEnemy = 32;
                speedBird = 40;
                fireBallLimit = 5;
            }
            
        }

      
        private void SetLoca()
        {
            fireBall.Add(loca1);
            fireBall.Add(loca2);
            fireBall.Add(loca3);
            fireBall.Add(loca4);
            fireBall.Add(loca5);
            fireBall.Add(loca6);
            fireBall.Add(loca7);
            fireBall.Add(loca8);
            fireBall.Add(loca9);
            fireBall.Add(loca10);
            fireBall.Add(loca11);
            fireBall.Add(loca12);
            fireBall.Add(loca13);
            fireBall.Add(loca14);
        }

        int birdCount = 0;
        private void SpawnBird( int time)
        {
            int a = random.Next(0, 100 - time);
            int b = random.Next(0, 2);
            if (b == 0)
                birdDirection = true;
            else
                birdDirection = false;
             bird = new PictureBox();
            if (  a == 80 || a == 60 || a == 40 || a == 10 || a == 20) 
               
            {

                bird.Width =80;
                bird.Height = 60;
                bird.SizeMode = PictureBoxSizeMode.StretchImage;
 
                if ( birdDirection == false)
                {
                    bird.Location = new Point(10, 400);
                    bird.Image = Image.FromFile(Application.StartupPath + @"\Resources\bird.png");
                    this.Controls.Add(bird);
                }
                else
                {
                    bird.Location = new Point(933, 400);
                    bird.Image = Image.FromFile(Application.StartupPath + @"\Resources\bird2.png");
                     this.Controls.Add(bird);

                }
                bird.BackColor = Color.Transparent;
                bird.BringToFront();
                birdCount++;
            }
           
                return;

        }


        private void SpawnHeart()
        {
             int a = random.Next(0, 30);
          
            int b = random.Next(0, 2);
            if (b == 0)
                heartDirection = true;
            else
                heartDirection = false;


             heart = new PictureBox();
            if (a == 3 || a == 4)
            {

                heart.Width = 80;
                heart.Height = 70;
                heart.SizeMode = PictureBoxSizeMode.StretchImage;

                if (heartDirection == false)
                {
                    heart.Left = 10;
                    heart.Top = 390;
                    heart.Image = Image.FromFile(Application.StartupPath + @"\Resources\heart10.png");
           
                }
                else
                {
                    heart.Left = 933;
                    heart.Top = 390;
                    heart.Image = Image.FromFile(Application.StartupPath + @"\Resources\heart10.png");

                }
        
                this.Controls.Add(heart);
            
                heart.BackColor = Color.Transparent;
            }

        }
        private void SpawnCoin()
        {

            if (Coins.Count < coinLimit)
            {
                int a = random.Next(0, 13);


                while (CheckViTri(a) == 0)
                {
                    a = random.Next(0, 13);
                }

                PictureBox pb = new PictureBox();
                pb.Image =  Image.FromFile(Application.StartupPath + @"\Resources\coin10.png");
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Width = 20;
                pb.Height = 50;
                pb.Top = fireBall[a].Top;
                pb.Left = fireBall[a].Left;
                Coins.Add(pb);
                this.Controls.Add(pb);
                pb.BringToFront();
                pb.BackColor = Color.Transparent;

            }
        }
        private void SpawnFireBall()
            {
                if (boxes.Count < fireBallLimit)
                {
                    int a = random.Next(0, fireballCount);

                    while (CheckViTri(a) == 0)
                    {
                        a = random.Next(0, fireballCount);
                    }

                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile(Application.StartupPath + @"\Resources\meteorite10.png");
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Width = 20;
                    pb.Height = 50;
                    pb.Top = fireBall[a].Top;
                    pb.Left = fireBall[a].Left;
                    boxes.Add(pb);
                    this.Controls.Add(pb);
                    pb.BringToFront();
                    pb.BackColor = Color.Transparent;

                }
            }
        private int CheckViTri(int a) // 0 la co, 1 la khong co
        {
            for (int i = 0; i < fireBallLimit + 3; i++)   // 3 la so coin + so HP
            {
                if (a == SaveViTri[i])
                {
                    return 0;
                }
               
            }

            for (int i = 20; i >= 1; i--)
            {
                SaveViTri[i] = SaveViTri[i - 1];
            }
            SaveViTri[0] = a;
            return 1;
        }
        private void Move()
        {
      
            for (int i = 0; i < boxes.Count; i++)
            {
                boxes[i].Top += speedEnemy;
                if (boxes[i].Top > limit)
                {
                    this.Controls.Remove(boxes[i]);
                    boxes.Remove(boxes[i]);
                }
                boxes[i].BringToFront();
            }


            for (int i = 0; i < Coins.Count; i++)
            {
                Coins[i].Top += speedEnemy;
                Coins[i].BringToFront();
                if (Coins[i].Top > limit)
                {
                    this.Controls.Remove(Coins[i]);
                    Coins.Remove(Coins[i]);
                }
            
            }
            if ( birdDirection == false)
            {
                birdCount++;
                bird.Left += speedBird;
                if (bird.Left > 966)
                {

                    this.Controls.Remove(bird);
                    checkSpawnBird = true;
                }
            }
            else
            {
                birdCount++;

                bird.Left -= speedBird;
                if (bird.Left < 5)
                {

                    this.Controls.Remove(bird);
                    checkSpawnBird = true;
                }
            }

            if (heartDirection == false)
            {

                heart.Left += speedBird;
                if (heart.Left > 966)
                {

                    this.Controls.Remove(heart);
                  
                    checkSpawnHeart = true;

                }
            }
            else
            {
                heart.Left -= speedBird;
                if (heart.Left < 5)
                {

                    this.Controls.Remove(heart);
                   
                    checkSpawnHeart = true;
                }
            }

        }
        private void VaCham()
        {
            
            int lengthFireBall = boxes.Count;
            int lengthCoin = Coins.Count;
           for ( int i = 0; i < boxes.Count; i++)
            {
                if (boxes[i].Bounds.IntersectsWith(Dino.Bounds) )
                {
                    if ( heartPoint != 0)
                    {
                        boxes[i].Image = Image.FromFile(Application.StartupPath + @"\Resources\explosion10.png");
                        heartPoint--;
                        this.Controls.Remove(boxes[i]);
                        boxes.Remove(boxes[i]);
                    }
                    else
                    {
                        boxes[i].Image = Image.FromFile(Application.StartupPath + @"\Resources\explosion10.png");
                        GameTime.Enabled = false;
                                     
                        checkEnd = true;

                        this.panel1.Visible = true;
                        panel1.BringToFront();
                        player.Stop();
                        loca9.BringToFront();
                    }
                  
                }
            }
            

           for ( int i = 0; i < Coins.Count; i++)
            {
                if (Coins[i].Bounds.IntersectsWith(Dino.Bounds)){
                 
                 
                    Coins[i].Top -= 20;
                    this.Controls.Remove(Coins[i]);
                    Coins.Remove(Coins[i]);
                    pointCoins++;
                    lbPoint.Text = pointCoins.ToString();
                 
                }
            }


           if ( bird.Bounds.IntersectsWith(Dino.Bounds ))
            {
                if (heartPoint != 0) {
                    this.Controls.Remove(bird);
                    heartPoint--;
                }
                else
                {
                    GameTime.Enabled = false;

                    this.panel1.Visible = true;
                    panel1.BringToFront();

                    checkEnd = true;
                    labelCountHeart.Text = "lose";
                    this.Controls.Remove(bird);
                    player.Stop();
                }
                checkSpawnBird = true;

            }
            if (heart.Bounds.IntersectsWith(Dino.Bounds))
            {
                this.Controls.Remove(heart);
                heartPoint++;

                checkSpawnHeart = true;
               
             }
      
        }


        int nextLV = 1;
   
        private void PointGame()
        {
            switch (nextLV)
            {
                case 1:
                    pointGame += 2;
                    break;
                case 2:
                    pointGame += 5;
                    break;
                case 3:
                    pointGame += 10;
                    break;

            }     
            if (pointGame == 500|| pointGame == 1500)
            {

                nextLV++;

                setLv(nextLV);

                MusicOn(nextLV);

               
            }
          
        }
        private void autoChange()
        {

            if (dinoDodge == false)
            {
                if (dinoDirection == true)
                {

                    if (checkDino == 1)
                    {

                        Dino.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino1.png");
                        dinoModel.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino1.png"); ;
                        checkDino = 0;
                        Dino.BringToFront();
                    }
                    else
                    {
                        Dino.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino2.png");
                        dinoModel.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino2.png"); ;
                        checkDino = 1;
                        Dino.BringToFront();
                    }
                }
                else
                {
                    if (checkDino == 1)
                    {

                        Dino.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino3.png");
                        dinoModel.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino3.png"); ;
                        checkDino = 0;
                        Dino.BringToFront();
                    }
                    else
                    {
                        Dino.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino4.png");
                        dinoModel.Image = Image.FromFile(Application.StartupPath + @"\Resources\dino4.png"); ;
                        checkDino = 1;
                        Dino.BringToFront();
                    }
                }

            }
            else
            {
                if (dinoDirection == true)
                {

                    if (checkDino == 1)
                    {

                        dinoModel.Image =  Dino.Image = Image.FromFile(Application.StartupPath + @"\Resources\dinoDodge1.png");
                      
                        checkDino = 0;
                        Dino.BringToFront();
                    }
                    else
                    {
                        dinoModel.Image =  Dino.Image = Image.FromFile(Application.StartupPath + @"\Resources\dinoDodge2.png");
                        checkDino = 1;
                        Dino.BringToFront();
                    }
                }
                else
                {
                    if (checkDino == 1)
                    {

                        dinoModel.Image =  Dino.Image = Image.FromFile(Application.StartupPath + @"\Resources\dinoDodge3.png");
                        checkDino = 0;
                        Dino.BringToFront();
                    }
                    else
                    {
                        dinoModel.Image = Dino.Image = Image.FromFile(Application.StartupPath + @"\Resources\dinoDodge4.png");
                        checkDino = 1;
                        Dino.BringToFront();
                    }
                }

            }


        }
        private void dinoMove()
        {

            if (Dino.Left < 844 && dinoDirection == true)
            {
                Dino.Left += speed;
            }
            if (Dino.Left > 0 && dinoDirection == false)
            {
                Dino.Left -= speed;
            }

        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
           

                 switch(keyData)
                {
                    case Keys.Space:
                        restart();
                        this.panel1.Visible = false;
                        luuDiem(label2.Text);
                        luuTG();
                        return true;
                    case Keys.P:
                    
                        if (checkBtn == 1)
                        {
                            GameTime.Enabled = true;
                            pointTime.Enabled = true; 
                            checkBtn = 0;
                            btContinue.Hide();
                            button1.Show();
                        player.Play();
                        
                        }
                        else
                        {
                        player.Stop();
                            GameTime.Enabled = false;
                            pointTime.Enabled = false;
                            checkBtn = 1;
                            button1.Hide();
                            btContinue.Show();
                        }                  
                        return true;
                }    
                if (keyData == Keys.Right)
                {
                    dinoDirection = true;
           
 
                    Dino.BringToFront();

                }
                if (keyData == Keys.Left)
                {
                    dinoDirection = false;

                  
                    Dino.BringToFront();

                }
      

            return base.ProcessDialogKey(keyData);
        }
        private void KhungLongmove_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                if (dinoDodge == true)
                {
                    Dino.Height -= -20;
                    Dino.Top -= 20;
                    dinoDodge = false;
                    Dino.BringToFront();

                }

            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            if (checkEnd == false)
            {

                    if (keyData == Keys.Down)
                    {
               
                        if (dinoDodge == false)
                        {

                            Dino.Height += -20;
                            Dino.Top += 20;
                           

                            Dino.BringToFront();
                            dinoDodge = true;

                        }
                        return true;
                    }
            }
                
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            if (checkBtn == 1)
            {
                GameTime.Enabled = true;
                pointTime.Enabled = true;
                checkBtn = 0;
                btContinue.Hide();
                button1.Show();
                player.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            if (checkBtn == 0)
            {
                GameTime.Enabled = false;
                pointTime.Enabled = false;
                checkBtn = 1;

                button1.Hide();
                btContinue.Show();
                player.Stop();
            }
            
        }


        private void MusicOn(int number)
        {
        
            player.SoundLocation = Application.StartupPath + @"\Resources\" + number + ".wav";
            player.Play();
        }

        private void DinoTime_Tick_1(object sender, EventArgs e)
        {
            if (hoverDino)
            {
                lbTen.ForeColor = System.Drawing.Color.DeepPink;
                //lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)))
                //    , System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                lbTen.ForeColor = System.Drawing.Color.Aquamarine;
                //lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            hoverDino = !hoverDino;
            SpawnFireBall();
            SpawnCoin();
            if (checkSpawnHeart == true)
            {
                SpawnHeart();
                checkSpawnHeart = false;
            }

            if (checkSpawnBird == true)
            {
                switch (chooseLevel)
                {
                    case 1:
                        SpawnBird(20);
                        break;
                    case 2:
                        SpawnBird(40);
                        break;
                    case 3:
                        SpawnBird(60);
                        break;


                }
                checkSpawnBird = false;
            }
            if (checkEnd == false)
            {
                dinoMove();
                autoChange();
                Move();
               
                VaCham();
             }

            labelCountHeart.Text = heartPoint.ToString();
            lbPoint.Text = pointCoins.ToString();
            
        }

        public void restart()
        {
            for ( int i =0; i < Coins.Count; i++)
            {
                this.Controls.Remove(Coins[i]);
                Coins.Remove(Coins[i]);
                i--;
            }
            for ( int i = 0; i< boxes.Count; i++)
            {
                this.Controls.Remove(boxes[i]);
                boxes.Remove(boxes[i]);
                i--;
            }
            this.Controls.Remove(bird);
            this.Controls.Remove(heart);

            checkEnd = false;
            GameTime.Enabled = true;
            chooseLevel = 1;
            MusicOn(chooseLevel);
            setLv(chooseLevel);
            SetLoca();
            Dino.Left = 100;
            pointGame = 0;
            heartPoint = 0;
            pointCoins = 0;
            nextLV = 1;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            luuTG();
            luuDiem(label2.Text);
            restart();
        }


     

        private void btMenu_Click(object sender, EventArgs e)
        {
            luuTG();
            luuDiem(label2.Text);
            this.Close();         
        }
       
        private void btPanRes_Click(object sender, EventArgs e)
        {
            restart();
            luuTG();
            luuDiem(label2.Text);
            this.panel1.Visible = false;
        }

        private void btPanMe_Click(object sender, EventArgs e)
        {
            luuTG();
            luuDiem(label2.Text);
            this.Close();
                    
            //this.panel1.Visible = false;
        }


        private void point_Tick(object sender, EventArgs e)
        {
            if (checkEnd == false)
            {
                PointGame();
                label2.Text = pointGame.ToString();
            }
        }
        private void luuDiem(string text)
        {
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog;
            string fileName = "";
            fileName = @"D:\FileDiem.txt";
            streamWriter = File.AppendText(fileName);
            streamWriter.WriteLine(text);
            streamWriter.Close();
        }
        private void luuTG()
        {
            StreamWriter streamWriter;
            DateTime time = DateTime.Now;
            string fileName = "";
            fileName = @"D:\FileTg.txt";
            streamWriter = File.AppendText(fileName);
            streamWriter.WriteLine(time);
            streamWriter.Close();
        }
    }
}
