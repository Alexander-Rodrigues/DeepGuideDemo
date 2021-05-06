
namespace DeepGuideDemo
{
    partial class Game
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
            this.UpLeft = new System.Windows.Forms.Button();
            this.MiddleMiddle = new System.Windows.Forms.Button();
            this.UpMiddle = new System.Windows.Forms.Button();
            this.MiddleLeft = new System.Windows.Forms.Button();
            this.UpRight = new System.Windows.Forms.Button();
            this.MiddleRight = new System.Windows.Forms.Button();
            this.DownMiddle = new System.Windows.Forms.Button();
            this.DownLeft = new System.Windows.Forms.Button();
            this.DownRight = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Round 1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.UpLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MiddleMiddle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UpMiddle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MiddleLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UpRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MiddleRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.DownMiddle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DownLeft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DownRight, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 198);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UpLeft
            // 
            this.UpLeft.Location = new System.Drawing.Point(3, 3);
            this.UpLeft.Name = "UpLeft";
            this.UpLeft.Size = new System.Drawing.Size(60, 60);
            this.UpLeft.TabIndex = 0;
            this.UpLeft.Text = "🡼";
            this.UpLeft.UseVisualStyleBackColor = true;
            this.UpLeft.Click += new System.EventHandler(this.upLeftButton_Click);
            // 
            // MiddleMiddle
            // 
            this.MiddleMiddle.Location = new System.Drawing.Point(69, 69);
            this.MiddleMiddle.Name = "MiddleMiddle";
            this.MiddleMiddle.Size = new System.Drawing.Size(60, 60);
            this.MiddleMiddle.TabIndex = 4;
            this.MiddleMiddle.Text = "●";
            this.MiddleMiddle.UseVisualStyleBackColor = true;
            this.MiddleMiddle.Click += new System.EventHandler(this.Middle_Click);
            // 
            // UpMiddle
            // 
            this.UpMiddle.Location = new System.Drawing.Point(69, 3);
            this.UpMiddle.Name = "UpMiddle";
            this.UpMiddle.Size = new System.Drawing.Size(60, 60);
            this.UpMiddle.TabIndex = 1;
            this.UpMiddle.Text = "🡹";
            this.UpMiddle.UseVisualStyleBackColor = true;
            this.UpMiddle.Click += new System.EventHandler(this.UpMiddleButton_Click);
            // 
            // MiddleLeft
            // 
            this.MiddleLeft.Location = new System.Drawing.Point(3, 69);
            this.MiddleLeft.Name = "MiddleLeft";
            this.MiddleLeft.Size = new System.Drawing.Size(60, 60);
            this.MiddleLeft.TabIndex = 3;
            this.MiddleLeft.Text = "🡸";
            this.MiddleLeft.UseVisualStyleBackColor = true;
            this.MiddleLeft.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // UpRight
            // 
            this.UpRight.Location = new System.Drawing.Point(135, 3);
            this.UpRight.Name = "UpRight";
            this.UpRight.Size = new System.Drawing.Size(60, 60);
            this.UpRight.TabIndex = 2;
            this.UpRight.Text = "🡽";
            this.UpRight.UseVisualStyleBackColor = true;
            this.UpRight.Click += new System.EventHandler(this.UpRightButton_Click);
            // 
            // MiddleRight
            // 
            this.MiddleRight.Location = new System.Drawing.Point(135, 69);
            this.MiddleRight.Name = "MiddleRight";
            this.MiddleRight.Size = new System.Drawing.Size(60, 60);
            this.MiddleRight.TabIndex = 5;
            this.MiddleRight.Text = "🡺";
            this.MiddleRight.UseVisualStyleBackColor = true;
            this.MiddleRight.Click += new System.EventHandler(this.Right_Click);
            // 
            // DownMiddle
            // 
            this.DownMiddle.Location = new System.Drawing.Point(69, 135);
            this.DownMiddle.Name = "DownMiddle";
            this.DownMiddle.Size = new System.Drawing.Size(60, 60);
            this.DownMiddle.TabIndex = 7;
            this.DownMiddle.Text = "🡻";
            this.DownMiddle.UseVisualStyleBackColor = true;
            this.DownMiddle.Click += new System.EventHandler(this.DownMiddleButton_Click);
            // 
            // DownLeft
            // 
            this.DownLeft.Location = new System.Drawing.Point(3, 135);
            this.DownLeft.Name = "DownLeft";
            this.DownLeft.Size = new System.Drawing.Size(60, 60);
            this.DownLeft.TabIndex = 6;
            this.DownLeft.Text = "🡿";
            this.DownLeft.UseVisualStyleBackColor = true;
            this.DownLeft.Click += new System.EventHandler(this.DownLeftButton_Click);
            // 
            // DownRight
            // 
            this.DownRight.Location = new System.Drawing.Point(135, 135);
            this.DownRight.Name = "DownRight";
            this.DownRight.Size = new System.Drawing.Size(60, 60);
            this.DownRight.TabIndex = 8;
            this.DownRight.Text = "🡾";
            this.DownRight.UseVisualStyleBackColor = true;
            this.DownRight.Click += new System.EventHandler(this.DownRightButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            this.groupBox2.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(195, 74);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button UpLeft;
        private System.Windows.Forms.Button UpMiddle;
        private System.Windows.Forms.Button MiddleMiddle;
        private System.Windows.Forms.Button UpRight;
        private System.Windows.Forms.Button MiddleLeft;
        private System.Windows.Forms.Button MiddleRight;
        private System.Windows.Forms.Button DownMiddle;
        private System.Windows.Forms.Button DownLeft;
        private System.Windows.Forms.Button DownRight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}