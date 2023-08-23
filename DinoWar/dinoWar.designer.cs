
namespace DinoWar
{
    partial class dinoWar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dinoWar));
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCountHeart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPoint = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTen = new System.Windows.Forms.Label();
            this.dinoModel = new System.Windows.Forms.PictureBox();
            this.btMenu = new System.Windows.Forms.Button();
            this.btContinue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPanMe = new System.Windows.Forms.Button();
            this.btPanRes = new System.Windows.Forms.Button();
            this.loca14 = new System.Windows.Forms.PictureBox();
            this.loca13 = new System.Windows.Forms.PictureBox();
            this.loca12 = new System.Windows.Forms.PictureBox();
            this.loca11 = new System.Windows.Forms.PictureBox();
            this.loca10 = new System.Windows.Forms.PictureBox();
            this.loca9 = new System.Windows.Forms.PictureBox();
            this.loca8 = new System.Windows.Forms.PictureBox();
            this.loca7 = new System.Windows.Forms.PictureBox();
            this.loca6 = new System.Windows.Forms.PictureBox();
            this.loca5 = new System.Windows.Forms.PictureBox();
            this.loca4 = new System.Windows.Forms.PictureBox();
            this.loca3 = new System.Windows.Forms.PictureBox();
            this.loca2 = new System.Windows.Forms.PictureBox();
            this.Dino = new System.Windows.Forms.PictureBox();
            this.loca1 = new System.Windows.Forms.PictureBox();
            this.pointTime = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dinoModel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loca14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTime
            // 
            this.GameTime.Enabled = true;
            this.GameTime.Interval = 50;
            this.GameTime.Tick += new System.EventHandler(this.DinoTime_Tick_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dino1.png");
            this.imageList1.Images.SetKeyName(1, "dino2.png");
            this.imageList1.Images.SetKeyName(2, "dino3.png");
            this.imageList1.Images.SetKeyName(3, "dino4.png");
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(83, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCountHeart
            // 
            this.labelCountHeart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCountHeart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountHeart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCountHeart.Location = new System.Drawing.Point(83, 66);
            this.labelCountHeart.Name = "labelCountHeart";
            this.labelCountHeart.Size = new System.Drawing.Size(94, 25);
            this.labelCountHeart.TabIndex = 9;
            this.labelCountHeart.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hearts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Diamonds";
            // 
            // lbPoint
            // 
            this.lbPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPoint.Location = new System.Drawing.Point(83, 107);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(94, 25);
            this.lbPoint.TabIndex = 13;
            this.lbPoint.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(16, 327);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 51);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Restart";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbTen);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dinoModel);
            this.panel2.Controls.Add(this.btMenu);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.lbPoint);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelCountHeart);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btContinue);
            this.panel2.Location = new System.Drawing.Point(966, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 604);
            this.panel2.TabIndex = 21;
            // 
            // lbTen
            // 
            this.lbTen.Font = new System.Drawing.Font("Jokerman", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbTen.Location = new System.Drawing.Point(9, 143);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(161, 100);
            this.lbTen.TabIndex = 24;
            this.lbTen.Text = "Dino War";
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dinoModel
            // 
            this.dinoModel.BackColor = System.Drawing.Color.Black;
            this.dinoModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dinoModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dinoModel.Location = new System.Drawing.Point(33, 464);
            this.dinoModel.Name = "dinoModel";
            this.dinoModel.Size = new System.Drawing.Size(113, 124);
            this.dinoModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dinoModel.TabIndex = 23;
            this.dinoModel.TabStop = false;
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(16, 393);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(154, 51);
            this.btMenu.TabIndex = 14;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = false;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // btContinue
            // 
            this.btContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinue.Location = new System.Drawing.Point(16, 260);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(154, 51);
            this.btContinue.TabIndex = 1;
            this.btContinue.Text = "Continue";
            this.btContinue.UseVisualStyleBackColor = false;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "You lose. Do you wanna play again?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btPanMe);
            this.panel1.Controls.Add(this.btPanRes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(343, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 122);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // btPanMe
            // 
            this.btPanMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btPanMe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btPanMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPanMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPanMe.ForeColor = System.Drawing.Color.Black;
            this.btPanMe.Location = new System.Drawing.Point(190, 61);
            this.btPanMe.Name = "btPanMe";
            this.btPanMe.Size = new System.Drawing.Size(88, 45);
            this.btPanMe.TabIndex = 24;
            this.btPanMe.Text = "Menu";
            this.btPanMe.UseVisualStyleBackColor = false;
            this.btPanMe.Click += new System.EventHandler(this.btPanMe_Click);
            // 
            // btPanRes
            // 
            this.btPanRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btPanRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btPanRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPanRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPanRes.ForeColor = System.Drawing.Color.Black;
            this.btPanRes.Location = new System.Drawing.Point(45, 61);
            this.btPanRes.Name = "btPanRes";
            this.btPanRes.Size = new System.Drawing.Size(88, 45);
            this.btPanRes.TabIndex = 24;
            this.btPanRes.Text = "Restart";
            this.btPanRes.UseVisualStyleBackColor = false;
            this.btPanRes.Click += new System.EventHandler(this.btPanRes_Click);
            // 
            // loca14
            // 
            this.loca14.BackColor = System.Drawing.Color.Transparent;
            this.loca14.Location = new System.Drawing.Point(903, 3);
            this.loca14.Name = "loca14";
            this.loca14.Size = new System.Drawing.Size(46, 46);
            this.loca14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca14.TabIndex = 22;
            this.loca14.TabStop = false;
            // 
            // loca13
            // 
            this.loca13.BackColor = System.Drawing.Color.Transparent;
            this.loca13.Location = new System.Drawing.Point(836, 3);
            this.loca13.Name = "loca13";
            this.loca13.Size = new System.Drawing.Size(46, 46);
            this.loca13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca13.TabIndex = 20;
            this.loca13.TabStop = false;
            // 
            // loca12
            // 
            this.loca12.BackColor = System.Drawing.Color.Transparent;
            this.loca12.Location = new System.Drawing.Point(766, 3);
            this.loca12.Name = "loca12";
            this.loca12.Size = new System.Drawing.Size(46, 46);
            this.loca12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca12.TabIndex = 19;
            this.loca12.TabStop = false;
            // 
            // loca11
            // 
            this.loca11.BackColor = System.Drawing.Color.Transparent;
            this.loca11.Location = new System.Drawing.Point(701, 3);
            this.loca11.Name = "loca11";
            this.loca11.Size = new System.Drawing.Size(46, 46);
            this.loca11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca11.TabIndex = 18;
            this.loca11.TabStop = false;
            // 
            // loca10
            // 
            this.loca10.BackColor = System.Drawing.Color.Transparent;
            this.loca10.Location = new System.Drawing.Point(634, 3);
            this.loca10.Name = "loca10";
            this.loca10.Size = new System.Drawing.Size(46, 46);
            this.loca10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca10.TabIndex = 17;
            this.loca10.TabStop = false;
            // 
            // loca9
            // 
            this.loca9.BackColor = System.Drawing.Color.Transparent;
            this.loca9.Location = new System.Drawing.Point(559, 3);
            this.loca9.Name = "loca9";
            this.loca9.Size = new System.Drawing.Size(46, 46);
            this.loca9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca9.TabIndex = 16;
            this.loca9.TabStop = false;
            // 
            // loca8
            // 
            this.loca8.BackColor = System.Drawing.Color.Transparent;
            this.loca8.Location = new System.Drawing.Point(485, 3);
            this.loca8.Name = "loca8";
            this.loca8.Size = new System.Drawing.Size(46, 46);
            this.loca8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca8.TabIndex = 15;
            this.loca8.TabStop = false;
            // 
            // loca7
            // 
            this.loca7.BackColor = System.Drawing.Color.Transparent;
            this.loca7.Location = new System.Drawing.Point(414, 3);
            this.loca7.Name = "loca7";
            this.loca7.Size = new System.Drawing.Size(46, 46);
            this.loca7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca7.TabIndex = 14;
            this.loca7.TabStop = false;
            // 
            // loca6
            // 
            this.loca6.BackColor = System.Drawing.Color.Transparent;
            this.loca6.Location = new System.Drawing.Point(343, 3);
            this.loca6.Name = "loca6";
            this.loca6.Size = new System.Drawing.Size(46, 46);
            this.loca6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca6.TabIndex = 13;
            this.loca6.TabStop = false;
            // 
            // loca5
            // 
            this.loca5.BackColor = System.Drawing.Color.Transparent;
            this.loca5.Location = new System.Drawing.Point(273, 3);
            this.loca5.Name = "loca5";
            this.loca5.Size = new System.Drawing.Size(46, 46);
            this.loca5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca5.TabIndex = 12;
            this.loca5.TabStop = false;
            // 
            // loca4
            // 
            this.loca4.BackColor = System.Drawing.Color.Transparent;
            this.loca4.Location = new System.Drawing.Point(211, 3);
            this.loca4.Name = "loca4";
            this.loca4.Size = new System.Drawing.Size(46, 46);
            this.loca4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca4.TabIndex = 11;
            this.loca4.TabStop = false;
            // 
            // loca3
            // 
            this.loca3.BackColor = System.Drawing.Color.Transparent;
            this.loca3.Location = new System.Drawing.Point(141, 3);
            this.loca3.Name = "loca3";
            this.loca3.Size = new System.Drawing.Size(46, 46);
            this.loca3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca3.TabIndex = 10;
            this.loca3.TabStop = false;
            // 
            // loca2
            // 
            this.loca2.BackColor = System.Drawing.Color.Transparent;
            this.loca2.Location = new System.Drawing.Point(71, 3);
            this.loca2.Name = "loca2";
            this.loca2.Size = new System.Drawing.Size(46, 46);
            this.loca2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca2.TabIndex = 9;
            this.loca2.TabStop = false;
            // 
            // Dino
            // 
            this.Dino.BackColor = System.Drawing.Color.Black;
            this.Dino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dino.Location = new System.Drawing.Point(442, 451);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(89, 114);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dino.TabIndex = 0;
            this.Dino.TabStop = false;
            // 
            // loca1
            // 
            this.loca1.BackColor = System.Drawing.Color.Transparent;
            this.loca1.Location = new System.Drawing.Point(1, 3);
            this.loca1.Name = "loca1";
            this.loca1.Size = new System.Drawing.Size(46, 46);
            this.loca1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loca1.TabIndex = 4;
            this.loca1.TabStop = false;
            // 
            // pointTime
            // 
            this.pointTime.Enabled = true;
            this.pointTime.Interval = 50;
            this.pointTime.Tick += new System.EventHandler(this.point_Tick);
            // 
            // dinoWar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loca14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loca13);
            this.Controls.Add(this.loca12);
            this.Controls.Add(this.loca11);
            this.Controls.Add(this.loca10);
            this.Controls.Add(this.loca9);
            this.Controls.Add(this.loca8);
            this.Controls.Add(this.loca7);
            this.Controls.Add(this.loca6);
            this.Controls.Add(this.loca5);
            this.Controls.Add(this.loca4);
            this.Controls.Add(this.loca3);
            this.Controls.Add(this.loca2);
            this.Controls.Add(this.Dino);
            this.Controls.Add(this.loca1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dinoWar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DINO WAR";
            this.Load += new System.EventHandler(this.testChuyenDongKhungLong_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KhungLongmove_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dinoModel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loca14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loca1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.PictureBox loca1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox loca2;
        private System.Windows.Forms.PictureBox loca3;
        private System.Windows.Forms.PictureBox loca4;
        private System.Windows.Forms.PictureBox loca8;
        private System.Windows.Forms.PictureBox loca7;
        private System.Windows.Forms.PictureBox loca6;
        private System.Windows.Forms.PictureBox loca5;
        private System.Windows.Forms.PictureBox loca12;
        private System.Windows.Forms.PictureBox loca11;
        private System.Windows.Forms.PictureBox loca10;
        private System.Windows.Forms.PictureBox loca9;
        private System.Windows.Forms.PictureBox loca13;
        private System.Windows.Forms.PictureBox loca14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCountHeart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox dinoModel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btPanMe;
        private System.Windows.Forms.Button btPanRes;
        private System.Windows.Forms.Timer pointTime;
    }
}