namespace Pokemole
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.Score = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.moleTimer = new System.Windows.Forms.Timer(this.components);
            this.sound = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.mole5 = new System.Windows.Forms.Button();
            this.mole4 = new System.Windows.Forms.Button();
            this.mole3 = new System.Windows.Forms.Button();
            this.mole2 = new System.Windows.Forms.Button();
            this.mole1 = new System.Windows.Forms.Button();
            this.mole0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(660, 169);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(146, 55);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndButton.Location = new System.Drawing.Point(660, 287);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(146, 53);
            this.EndButton.TabIndex = 7;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(660, 230);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(146, 51);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ScoreBox
            // 
            this.ScoreBox.Location = new System.Drawing.Point(718, 132);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(81, 20);
            this.ScoreBox.TabIndex = 9;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score.Location = new System.Drawing.Point(657, 132);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(55, 20);
            this.Score.TabIndex = 20;
            this.Score.Text = "Score:";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(657, 106);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(47, 20);
            this.Time.TabIndex = 22;
            this.Time.Text = "Time:";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.Color.White;
            this.TimeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeBox.Location = new System.Drawing.Point(718, 106);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.ReadOnly = true;
            this.TimeBox.Size = new System.Drawing.Size(81, 20);
            this.TimeBox.TabIndex = 21;
            // 
            // moleTimer
            // 
            this.moleTimer.Interval = 500;
            this.moleTimer.Tick += new System.EventHandler(this.moleTimer_Tick);
            // 
            // sound
            // 
            this.sound.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_8kmssaMtApaL;
            this.sound.Location = new System.Drawing.Point(756, 3);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(50, 50);
            this.sound.TabIndex = 41;
            this.sound.UseVisualStyleBackColor = true;
            this.sound.Click += new System.EventHandler(this.sound_Click);
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button13.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button13.Location = new System.Drawing.Point(533, 373);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 100);
            this.button13.TabIndex = 40;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.moles_Click);
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button14.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button14.Location = new System.Drawing.Point(427, 373);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 100);
            this.button14.TabIndex = 39;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.moles_Click);
            // 
            // button15
            // 
            this.button15.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button15.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button15.Location = new System.Drawing.Point(332, 373);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 100);
            this.button15.TabIndex = 38;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.moles_Click);
            // 
            // button16
            // 
            this.button16.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button16.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button16.Location = new System.Drawing.Point(533, 273);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 100);
            this.button16.TabIndex = 37;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.moles_Click);
            // 
            // button17
            // 
            this.button17.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button17.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button17.Location = new System.Drawing.Point(427, 273);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 100);
            this.button17.TabIndex = 36;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.moles_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button18.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button18.Location = new System.Drawing.Point(337, 270);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(89, 106);
            this.button18.TabIndex = 35;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.moles_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button7.Location = new System.Drawing.Point(231, 373);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 34;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.moles_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button8.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button8.Location = new System.Drawing.Point(125, 373);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 33;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.moles_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button9.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button9.Location = new System.Drawing.Point(30, 373);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 32;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.moles_Click);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button10.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button10.Location = new System.Drawing.Point(231, 270);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 100);
            this.button10.TabIndex = 31;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.moles_Click);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button11.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button11.Location = new System.Drawing.Point(125, 267);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 30;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.moles_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button12.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button12.Location = new System.Drawing.Point(30, 261);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 106);
            this.button12.TabIndex = 29;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.moles_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button1.Location = new System.Drawing.Point(533, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.moles_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button2.Location = new System.Drawing.Point(427, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.moles_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button3.Location = new System.Drawing.Point(332, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.moles_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button4.Location = new System.Drawing.Point(533, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.moles_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button5.Location = new System.Drawing.Point(432, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.moles_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.button6.Location = new System.Drawing.Point(337, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 106);
            this.button6.TabIndex = 23;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.moles_Click);
            // 
            // mole5
            // 
            this.mole5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mole5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mole5.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.mole5.Location = new System.Drawing.Point(231, 161);
            this.mole5.Name = "mole5";
            this.mole5.Size = new System.Drawing.Size(100, 100);
            this.mole5.TabIndex = 15;
            this.mole5.UseVisualStyleBackColor = true;
            this.mole5.Click += new System.EventHandler(this.moles_Click);
            // 
            // mole4
            // 
            this.mole4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mole4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mole4.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.mole4.Location = new System.Drawing.Point(125, 161);
            this.mole4.Name = "mole4";
            this.mole4.Size = new System.Drawing.Size(100, 100);
            this.mole4.TabIndex = 14;
            this.mole4.UseVisualStyleBackColor = true;
            this.mole4.Click += new System.EventHandler(this.moles_Click);
            // 
            // mole3
            // 
            this.mole3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mole3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mole3.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.mole3.Location = new System.Drawing.Point(30, 161);
            this.mole3.Name = "mole3";
            this.mole3.Size = new System.Drawing.Size(100, 100);
            this.mole3.TabIndex = 13;
            this.mole3.UseVisualStyleBackColor = true;
            this.mole3.Click += new System.EventHandler(this.moles_Click);
            // 
            // mole2
            // 
            this.mole2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mole2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mole2.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.mole2.Location = new System.Drawing.Point(231, 52);
            this.mole2.Name = "mole2";
            this.mole2.Size = new System.Drawing.Size(100, 100);
            this.mole2.TabIndex = 12;
            this.mole2.UseVisualStyleBackColor = true;
            this.mole2.Click += new System.EventHandler(this.moles_Click);
            // 
            // mole1
            // 
            this.mole1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mole1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mole1.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.mole1.Location = new System.Drawing.Point(136, 52);
            this.mole1.Name = "mole1";
            this.mole1.Size = new System.Drawing.Size(100, 100);
            this.mole1.TabIndex = 11;
            this.mole1.UseVisualStyleBackColor = true;
            this.mole1.Click += new System.EventHandler(this.moles_Click);
            // 
            // mole0
            // 
            this.mole0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mole0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mole0.CausesValidation = false;
            this.mole0.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mole0.FlatAppearance.BorderSize = 0;
            this.mole0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mole0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mole0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mole0.Image = global::Pokemole.Properties.Resources.imgonline_com_ua_Resize_XDmpqS1Z4zttQZ4x_removebg_preview;
            this.mole0.Location = new System.Drawing.Point(41, 52);
            this.mole0.Name = "mole0";
            this.mole0.Size = new System.Drawing.Size(89, 106);
            this.mole0.TabIndex = 10;
            this.mole0.UseMnemonic = false;
            this.mole0.UseVisualStyleBackColor = false;
            this.mole0.Click += new System.EventHandler(this.moles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(826, 481);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.mole5);
            this.Controls.Add(this.mole4);
            this.Controls.Add(this.mole3);
            this.Controls.Add(this.mole2);
            this.Controls.Add(this.mole1);
            this.Controls.Add(this.mole0);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Pokemole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.Button mole1;
        private System.Windows.Forms.Button mole2;
        private System.Windows.Forms.Button mole3;
        private System.Windows.Forms.Button mole4;
        private System.Windows.Forms.Button mole5;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox TimeBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer moleTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button sound;
        private System.Windows.Forms.Button mole0;
    }
}

