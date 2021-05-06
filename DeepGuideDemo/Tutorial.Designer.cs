
namespace DeepGuideDemo
{
    partial class Tutorial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UpLeft = new System.Windows.Forms.Button();
            this.MiddleMiddle = new System.Windows.Forms.Button();
            this.UpMiddle = new System.Windows.Forms.Button();
            this.MiddleLeft = new System.Windows.Forms.Button();
            this.UpRight = new System.Windows.Forms.Button();
            this.MiddleRight = new System.Windows.Forms.Button();
            this.DownMiddle = new System.Windows.Forms.Button();
            this.DownLeft = new System.Windows.Forms.Button();
            this.DownRight = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Modes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(277, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "After setting the number of rounds, you can either start a Fixed or Random point " +
    "game.                                                                      ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fixed";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 81);
            this.label2.TabIndex = 1;
            this.label2.Text = "In Fixed, you have to identify the direction of 9 different sounds, one for each " +
    "button.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(141, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Random";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 81);
            this.label3.TabIndex = 2;
            this.label3.Text = "In Random, the sound can come from anywhere, click the button closest to the soun" +
    "d source.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(13, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 119);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "The Game";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 100);
            this.label4.TabIndex = 3;
            this.label4.Text = "Say you hear the sound being play from the left and on top of your head, that\'d b" +
    "e the 🡼 button. If it sounds like it\'s coming from straight ahead then the ● on" +
    "e.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Controls.Add(this.UpLeft, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MiddleMiddle, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.UpMiddle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MiddleLeft, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.UpRight, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.MiddleRight, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.DownMiddle, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.DownLeft, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.DownRight, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(201, 198);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // UpLeft
            // 
            this.UpLeft.Location = new System.Drawing.Point(3, 3);
            this.UpLeft.Name = "UpLeft";
            this.UpLeft.Size = new System.Drawing.Size(60, 60);
            this.UpLeft.TabIndex = 0;
            this.UpLeft.Text = "🡼";
            this.UpLeft.UseVisualStyleBackColor = true;
            this.UpLeft.Click += new System.EventHandler(this.UpLeft_Click);
            // 
            // MiddleMiddle
            // 
            this.MiddleMiddle.Location = new System.Drawing.Point(69, 69);
            this.MiddleMiddle.Name = "MiddleMiddle";
            this.MiddleMiddle.Size = new System.Drawing.Size(60, 60);
            this.MiddleMiddle.TabIndex = 4;
            this.MiddleMiddle.Text = "●";
            this.MiddleMiddle.UseVisualStyleBackColor = true;
            this.MiddleMiddle.Click += new System.EventHandler(this.MiddleMiddle_Click);
            // 
            // UpMiddle
            // 
            this.UpMiddle.Location = new System.Drawing.Point(69, 3);
            this.UpMiddle.Name = "UpMiddle";
            this.UpMiddle.Size = new System.Drawing.Size(60, 60);
            this.UpMiddle.TabIndex = 1;
            this.UpMiddle.Text = "🡹";
            this.UpMiddle.UseVisualStyleBackColor = true;
            this.UpMiddle.Click += new System.EventHandler(this.UpMiddle_Click);
            // 
            // MiddleLeft
            // 
            this.MiddleLeft.Location = new System.Drawing.Point(3, 69);
            this.MiddleLeft.Name = "MiddleLeft";
            this.MiddleLeft.Size = new System.Drawing.Size(60, 60);
            this.MiddleLeft.TabIndex = 3;
            this.MiddleLeft.Text = "🡸";
            this.MiddleLeft.UseVisualStyleBackColor = true;
            this.MiddleLeft.Click += new System.EventHandler(this.MiddleLeft_Click);
            // 
            // UpRight
            // 
            this.UpRight.Location = new System.Drawing.Point(135, 3);
            this.UpRight.Name = "UpRight";
            this.UpRight.Size = new System.Drawing.Size(60, 60);
            this.UpRight.TabIndex = 2;
            this.UpRight.Text = "🡽";
            this.UpRight.UseVisualStyleBackColor = true;
            this.UpRight.Click += new System.EventHandler(this.UpRight_Click);
            // 
            // MiddleRight
            // 
            this.MiddleRight.Location = new System.Drawing.Point(135, 69);
            this.MiddleRight.Name = "MiddleRight";
            this.MiddleRight.Size = new System.Drawing.Size(60, 60);
            this.MiddleRight.TabIndex = 5;
            this.MiddleRight.Text = "🡺";
            this.MiddleRight.UseVisualStyleBackColor = true;
            this.MiddleRight.Click += new System.EventHandler(this.MiddleRight_Click);
            // 
            // DownMiddle
            // 
            this.DownMiddle.Location = new System.Drawing.Point(69, 135);
            this.DownMiddle.Name = "DownMiddle";
            this.DownMiddle.Size = new System.Drawing.Size(60, 60);
            this.DownMiddle.TabIndex = 7;
            this.DownMiddle.Text = "🡻";
            this.DownMiddle.UseVisualStyleBackColor = true;
            this.DownMiddle.Click += new System.EventHandler(this.DownMiddle_Click);
            // 
            // DownLeft
            // 
            this.DownLeft.Location = new System.Drawing.Point(3, 135);
            this.DownLeft.Name = "DownLeft";
            this.DownLeft.Size = new System.Drawing.Size(60, 60);
            this.DownLeft.TabIndex = 6;
            this.DownLeft.Text = "🡿";
            this.DownLeft.UseVisualStyleBackColor = true;
            this.DownLeft.Click += new System.EventHandler(this.DownLeft_Click);
            // 
            // DownRight
            // 
            this.DownRight.Location = new System.Drawing.Point(135, 135);
            this.DownRight.Name = "DownRight";
            this.DownRight.Size = new System.Drawing.Size(60, 60);
            this.DownRight.TabIndex = 8;
            this.DownRight.Text = "🡾";
            this.DownRight.UseVisualStyleBackColor = true;
            this.DownRight.Click += new System.EventHandler(this.DownRight_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.tableLayoutPanel2);
            this.groupBox5.Location = new System.Drawing.Point(314, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 291);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Example";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(581, 315);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tutorial";
            this.Text = "Tutorial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tutorial_FormClosing);
            this.Load += new System.EventHandler(this.Tutorial_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button UpLeft;
        private System.Windows.Forms.Button MiddleMiddle;
        private System.Windows.Forms.Button UpMiddle;
        private System.Windows.Forms.Button MiddleLeft;
        private System.Windows.Forms.Button UpRight;
        private System.Windows.Forms.Button MiddleRight;
        private System.Windows.Forms.Button DownMiddle;
        private System.Windows.Forms.Button DownLeft;
        private System.Windows.Forms.Button DownRight;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
    }
}