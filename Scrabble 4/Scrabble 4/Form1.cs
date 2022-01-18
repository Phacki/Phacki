using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrabble_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button8.Visible = false;
            button7.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            lblplayer2.Visible = false;
            lblplayer1.Visible = false;
            btnEnter.Visible = false;
            btnQuit.Visible = false;
            btnClear.Visible = false;
            btnEnter2.Visible = false;
            btnQuit2.Visible = false;
            btnClear2.Visible = false;
            lblScore.Visible = false;
            lblScore2.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;




            string text = System.IO.File.ReadAllText(@"R:\A-level Comp Science\sc\Scrabble\Scrabble\bin\Debug\Words.txt");
            System.Console.WriteLine("Words.txt = {0}", text);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Word1.Text = " ";
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear2_Click(object sender, EventArgs e)
        {
            Word2.Text = " ";
        }

        private void BtnQuit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            lblplayer1.Text = tb.Text;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            lblplayer2.Text = tb.Text;
        }

        private void EnterName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the world of Dutt!");
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button8.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = true;
            button4.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            lblplayer2.Visible = true;
            lblplayer1.Visible = true;
            btnEnter.Visible = true;
            btnQuit.Visible = true;
            btnClear.Visible = true;
            btnEnter2.Visible = true;
            btnQuit2.Visible = true;
            btnClear2.Visible = true;
            lblScore.Visible = true;
            lblScore2.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            EnterName.Visible = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
