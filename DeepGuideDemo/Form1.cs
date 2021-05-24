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

    public partial class Form1 : Form
    {
        Globals g;
        Generator gn;
        Generator gn2;
        Generator gn3;
        Generator gn4;
        public Form1()
        {
            InitializeComponent();
            g = Globals.load();
            groupBoxDebug.Visible = debugToolStripMenuItem.Checked;
            gn = new ContinuousGenerator(-90f, 90f, -60f, 60f, 5f);
            gn2 = new DiscreteGenerator(-90f, 90f, -60f, 60f, 5f);
            gn3 = new DiscreteGeneratorX(4f, 4f);
            gn4 = new ContinuousGeneratorX(4.5f, 4.5f);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var st = new Settings(g);
            st.ShowDialog();
            g = Globals.load();
        }


        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = new Test();
            t.ShowDialog();
            g = Globals.load();
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxDebug.Visible = debugToolStripMenuItem.Checked;
        }
        private void buttonSimple_Click(object sender, EventArgs e)
        {
            try
            {
                int rounds = int.Parse(textBox1.Text);
                var game = new Game(gn3, rounds, debugToolStripMenuItem.Checked);
                game.ShowDialog();
            }
            catch (Exception)
            {
                textBox1.Text = "Not Valid";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int rounds = int.Parse(textBox1.Text);
                var game = new Game(gn4, rounds, debugToolStripMenuItem.Checked);
                game.ShowDialog();
            }
            catch (Exception)
            {
                textBox1.Text = "Not Valid";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = new Tutorial();
            t.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxDebug.Items.Insert(0, gn4.Generate());
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a demo for testing how well binaural audio can be pinpointed. This will assist in the development of an AI powered sound-navigation app." , "About");
        }

        private void generatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
