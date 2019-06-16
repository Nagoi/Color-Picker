using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setTB();
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void CopyToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText( ToHex(panel1.BackColor));
        }

        private void ColorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.Color = panel1.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private static string ToRGB(Color c)
        {
            return $"{c.R.ToString()},{c.G.ToString()},{c.B.ToString()}";
        }
        private static string ToHex(Color c)
        {
            return $"#{c.R.ToString("X2")}{c.G.ToString("X2")}{c.B.ToString("X2")}";
        }

        private void CopyToRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ToRGB(panel1.BackColor));
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            setTB();
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void setTB()
        {
            textBox1.Text = trackBar1.Value.ToString();
            textBox2.Text = trackBar2.Value.ToString();
            textBox3.Text = trackBar3.Value.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Value = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {

            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar2.Value = int.Parse(textBox2.Text);
            }
            catch (Exception)
            {

            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar3.Value = int.Parse(textBox3.Text);
            }
            catch (Exception)
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
