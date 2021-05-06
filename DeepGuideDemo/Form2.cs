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
    public partial class Settings : Form
    {
        Globals globals;
        public Settings(Globals g)
        {
            InitializeComponent();
            globals = g;
            textBoxInput.Text = globals.input;
            textBoxOutput.Text = globals.output;
            textBoxHrtf.Text = globals.hrtf;
        }

        

        private void labelInput_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            globals.input = textBoxInput.Text;
            globals.output = textBoxOutput.Text;
            globals.hrtf = textBoxHrtf.Text;
            globals.Save();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            globals = new Globals();
            textBoxInput.Text = globals.input;
            textBoxOutput.Text = globals.output;
            textBoxHrtf.Text = globals.hrtf;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
