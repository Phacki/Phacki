namespace Scrabble_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblplayer1 = new System.Windows.Forms.Label();
            this.btnQuit2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnEnter2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblplayer2 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Word2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Word1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuit.Location = new System.Drawing.Point(725, 95);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(126, 23);
            this.btnQuit.TabIndex = 30;
            this.btnQuit.Text = "Give Up";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(595, 95);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AlphabetSoup Tilt BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(271, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "Space Letters";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Olive;
            this.btnEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnter.Location = new System.Drawing.Point(465, 95);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 23);
            this.btnEnter.TabIndex = 18;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblScore.Location = new System.Drawing.Point(711, 17);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(94, 21);
            this.lblScore.TabIndex = 31;
            this.lblScore.Text = "Score :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.Word1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.lblplayer1);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 100);
            this.panel1.TabIndex = 32;
            // 
            // lblplayer1
            // 
            this.lblplayer1.AutoSize = true;
            this.lblplayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer1.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblplayer1.Location = new System.Drawing.Point(6, 17);
            this.lblplayer1.Name = "lblplayer1";
            this.lblplayer1.Size = new System.Drawing.Size(130, 21);
            this.lblplayer1.TabIndex = 32;
            this.lblplayer1.Text = "Player One";
            // 
            // btnQuit2
            // 
            this.btnQuit2.BackColor = System.Drawing.Color.Red;
            this.btnQuit2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuit2.Location = new System.Drawing.Point(725, 343);
            this.btnQuit2.Name = "btnQuit2";
            this.btnQuit2.Size = new System.Drawing.Size(126, 23);
            this.btnQuit2.TabIndex = 44;
            this.btnQuit2.Text = "Give Up";
            this.btnQuit2.UseVisualStyleBackColor = false;
            this.btnQuit2.Click += new System.EventHandler(this.BtnQuit2_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear2.Location = new System.Drawing.Point(594, 343);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(126, 23);
            this.btnClear2.TabIndex = 43;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.BtnClear2_Click);
            // 
            // btnEnter2
            // 
            this.btnEnter2.BackColor = System.Drawing.Color.Olive;
            this.btnEnter2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnter2.Location = new System.Drawing.Point(465, 343);
            this.btnEnter2.Name = "btnEnter2";
            this.btnEnter2.Size = new System.Drawing.Size(125, 23);
            this.btnEnter2.TabIndex = 33;
            this.btnEnter2.Text = "Enter";
            this.btnEnter2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Word2);
            this.panel2.Controls.Add(this.lblplayer2);
            this.panel2.Controls.Add(this.lblScore2);
            this.panel2.Location = new System.Drawing.Point(12, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 100);
            this.panel2.TabIndex = 45;
            // 
            // lblplayer2
            // 
            this.lblplayer2.AutoSize = true;
            this.lblplayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer2.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblplayer2.Location = new System.Drawing.Point(6, 17);
            this.lblplayer2.Name = "lblplayer2";
            this.lblplayer2.Size = new System.Drawing.Size(130, 21);
            this.lblplayer2.TabIndex = 32;
            this.lblplayer2.Text = "Player Two";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblScore2.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore2.Location = new System.Drawing.Point(711, 17);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(94, 21);
            this.lblScore2.TabIndex = 31;
            this.lblScore2.Text = "Score :";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.EnterName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 461);
            this.panel3.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OldLace;
            this.label3.Location = new System.Drawing.Point(5, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 38);
            this.label3.TabIndex = 50;
            this.label3.Text = "Player One Name:";
            // 
            // EnterName
            // 
            this.EnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnterName.Image = ((System.Drawing.Image)(resources.GetObject("EnterName.Image")));
            this.EnterName.Location = new System.Drawing.Point(11, 226);
            this.EnterName.Name = "EnterName";
            this.EnterName.Size = new System.Drawing.Size(842, 71);
            this.EnterName.TabIndex = 46;
            this.EnterName.Text = "Done";
            this.EnterName.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(426, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 38);
            this.label2.TabIndex = 49;
            this.label2.Text = "Player Two Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 20);
            this.textBox1.TabIndex = 47;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(433, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(419, 20);
            this.textBox2.TabIndex = 48;
            // 
            // Word2
            // 
            this.Word2.AutoSize = true;
            this.Word2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word2.Location = new System.Drawing.Point(602, 66);
            this.Word2.Name = "Word2";
            this.Word2.Size = new System.Drawing.Size(85, 24);
            this.Word2.TabIndex = 34;
            this.Word2.Text = "Crocpots";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 34);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Word1
            // 
            this.Word1.AutoSize = true;
            this.Word1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word1.Location = new System.Drawing.Point(602, 66);
            this.Word1.Name = "Word1";
            this.Word1.Size = new System.Drawing.Size(85, 24);
            this.Word1.TabIndex = 36;
            this.Word1.Text = "Crocpots";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 34);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 34);
            this.button3.TabIndex = 37;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 34);
            this.button4.TabIndex = 38;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(176, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 34);
            this.button5.TabIndex = 39;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(218, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 34);
            this.button6.TabIndex = 40;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(260, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 34);
            this.button7.TabIndex = 41;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(302, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 34);
            this.button8.TabIndex = 42;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(302, 41);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 34);
            this.button9.TabIndex = 50;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(260, 41);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 34);
            this.button10.TabIndex = 49;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(218, 41);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 34);
            this.button11.TabIndex = 48;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(176, 41);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 34);
            this.button12.TabIndex = 47;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(134, 41);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(36, 34);
            this.button13.TabIndex = 46;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(92, 41);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 45;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(50, 41);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(36, 34);
            this.button15.TabIndex = 44;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(8, 41);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(36, 34);
            this.button16.TabIndex = 43;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 461);
            this.Controls.Add(this.btnQuit2);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnEnter2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblplayer1;
        private System.Windows.Forms.Button btnQuit2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnEnter2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblplayer2;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EnterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Word2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label Word1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

