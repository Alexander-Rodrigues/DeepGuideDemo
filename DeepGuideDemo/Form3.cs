﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepGuideDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox3.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "Generating...";
            float distance;
            float radius;
            axis a = axis.DU;
            string path;

            try {
                distance = float.Parse(textBox1.Text);
                radius = float.Parse(textBox2.Text);
                if (radioButton1.Checked) a = axis.LR;
                if (radioButton2.Checked) a = axis.DU;
                if (radioButton3.Checked) a = axis.FB;

                path = Path.Combine(textBox3.Text, textBox4.Text) + "\\";

                bool exists = System.IO.Directory.Exists(path);
                if (!exists) System.IO.Directory.CreateDirectory(path);
                Generator2.create(distance, radius, a, path);
                label8.Text = "Done!";

            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
                //System.IO.Directory.Delete(path);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axis a = axis.DU;
            if (radioButton1.Checked) a = axis.LR;
            if (radioButton2.Checked) a = axis.DU;
            if (radioButton3.Checked) a = axis.FB;
            textBox4.Text = string.Format("{0}_{1}_{2}", textBox1.Text, textBox2.Text, a.ToString());
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0) Clipboard.SetText(textBox4.Text);

        }
    }
}