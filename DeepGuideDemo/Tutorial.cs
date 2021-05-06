using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepGuideDemo
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
            Globals g = Globals.load();
            steamAudio.settings(g.input, g.output, g.hrtf);
            steamAudio.init();
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void press(float leftRight, float downUp, float frontBack)
        {
            //steamAudio.create(yaw, pitch, distance);
            steamAudio.ogCreate(leftRight, downUp, frontBack);
            steamAudio.play();

        }

        private void UpLeft_Click(object sender, EventArgs e)
        {
            press(-4, 4, -2);
        }

        private void UpMiddle_Click(object sender, EventArgs e)
        {
            press(0, 5, -2);
        }

        private void UpRight_Click(object sender, EventArgs e)
        {
            press(4, 4, -2);
        }

        private void MiddleLeft_Click(object sender, EventArgs e)
        {
            press(-4, 0, -2);
        }

        private void MiddleMiddle_Click(object sender, EventArgs e)
        {
            press(0, 0, -2);
        }

        private void MiddleRight_Click(object sender, EventArgs e)
        {
            press(4, 0, -2);
        }

        private void DownLeft_Click(object sender, EventArgs e)
        {
            press(-4, -4, -2);
        }

        private void DownMiddle_Click(object sender, EventArgs e)
        {
            press(0, -4, -2);
        }

        private void DownRight_Click(object sender, EventArgs e)
        {
            press(4, -4, -2);
        }

        private void Tutorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            steamAudio.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            steamAudio.stop();
        }
    }
}
