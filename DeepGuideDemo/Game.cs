using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepGuideDemo
{
    public partial class Game : Form
    {
        Generator gen;
        Globals g;
        int round = 0;
        int rounds;
        Vector3 loc;
        bool debug;

        int correctLR = 0;
        int correctDU = 0;
        int correct;

        //string report = "Mode,Button Pressed,Button Yaw Max,Button Yaw Min,Button Pitch Max,Button Pitch Min,Sound Yaw,Sound Pitch,CorrectYaw,CorrectPitch,Correct\r\n";
        string report = "Mode,Button Pressed,Button minLR,Button maxLR,Button minDU,Button maxDU,Sound LR,Sound DU,Correct LR,Correct DU,Correct,Debug\r\n";

        public Game(Generator gen, int rounds, bool debug)
        {
            if (rounds < 1)
            {
                Close();
            }
            InitializeComponent();
            this.gen = gen;
            g = Globals.load();
            this.rounds = rounds;
            this.debug = debug;
            loc = gen.Generate();
            groupBox2.Visible = debug;
            if (debug) richTextBox1.Text = String.Format("nLeftRight:{0} DownUp:{1}", loc.X, loc.Y);

            steamAudio.settings(g.input, g.output, g.hrtf);
            steamAudio.init();
            steamAudio.ogCreate(loc.X, loc.Y, loc.Z);
            steamAudio.play();


        }

        public void buttonPress(string buttonName, float minLR, float maxLR, float minDU, float maxDU)
        {
            if (round < rounds)
            {
                bool lr = (minLR <= loc.X && loc.X <= maxLR);
                bool du = (minDU <= loc.Y && loc.Y <= maxDU);

                if (lr) correctLR++;
                if (du) correctDU++;
                if (lr && du) correct++;

                round++;
                groupBox1.Text = "Round " + (round + 1);

                //if (debug) richTextBox1.Text = String.Format("y:{0} p:{1}\nYaw:{2} Pitch:{3}", y, p, loc.X, loc.Y);
                loc = gen.Generate();
                if (debug) richTextBox1.Text = String.Format("lr:{0} ud:{1}\n{2}", lr, du, loc);
                report += String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}\r\n", gen.name, buttonName, minLR, maxLR, minDU, maxDU, loc.X, loc.Y, lr, du, lr && du, debug);
                //report += String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}\r\n", buttonName, maxY, minY, maxP, minP, loc.X, loc.Y, y, p, y && p);


                steamAudio.ogCreate(loc.X, loc.Y, loc.Z);
                steamAudio.play();

                if (round >= rounds)
                {
                    groupBox1.Text = "Game Over";
                    groupBox2.Visible = true;

                    richTextBox1.Text = String.Format("You got {0} out of {1} rounds right{2}\n", correct, rounds, (correct == rounds) ? "!" : ".");
                    richTextBox1.Text += String.Format("Your Up/Down accuracy was {0}%\n", correctDU*100 / rounds);
                    richTextBox1.Text += String.Format("Your Left/Right accuracy was {0}%\n", correctLR*100 / rounds);
                    steamAudio.stop();
                    string date = DateTime.Now.ToString("yyyyMMdd-HHmmss");
                    string hash = GetSha256Hash(SHA256.Create(), Environment.UserName);
                    System.IO.File.WriteAllText("logs\\" + hash + "_" + date + ".csv", report);
                }
            }
            
            
            
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
        private void upLeftButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            buttonPress(b.Name, -4.5f, -1.5f, 1.5f, 4.5f);
        }

        private void UpMiddleButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            buttonPress(b.Name, -1.5f, 1.5f, 1.5f, 4.5f);
        }

        private void UpRightButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            buttonPress(b.Name, 1.5f, 4.5f, 1.5f, 4.5f);
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            buttonPress(b.Name, -4.5f, -1.5f, -1.5f, 1.5f);
        }

        private void Middle_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            buttonPress(b.Name, -1.5f, 1.5f, -1.5f, 1.5f);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            buttonPress(b.Name, 1.5f, 4.5f, -1.5f, 1.5f);
        }

        private void DownLeftButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            buttonPress(b.Name, -4.5f, -1.5f, -4.5f, -1.5f);
        }

        private void DownMiddleButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            buttonPress(b.Name, -1.5f, 1.5f, -4.5f, -1.5f);
        }

        private void DownRightButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            buttonPress(b.Name, 1.5f, 4.5f, -4.5f, -1.5f);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            steamAudio.stop();
        }

        static string GetSha256Hash(SHA256 shaHash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = shaHash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            groupBox2.Visible = debug;
            round = 0;

            loc = gen.Generate();
            if (debug) richTextBox1.Text = String.Format("nLeftRight:{0} DownUp:{1}", loc.X, loc.Y);

            correctLR = 0;
            correctDU = 0;
            correct = 0;

            groupBox1.Text = "Round " + (round + 1);

            steamAudio.ogCreate(loc.X, loc.Y, loc.Z);
            steamAudio.play();

        }
    }
}
