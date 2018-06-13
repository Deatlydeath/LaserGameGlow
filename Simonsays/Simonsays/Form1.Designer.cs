namespace Simonsays
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
            this.components = new System.ComponentModel.Container();
            this.Red = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.scorelabel = new System.Windows.Forms.Label();
            this.patternlabel = new System.Windows.Forms.Label();
            this.Purple = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(27, 28);
            this.Red.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(215, 199);
            this.Red.TabIndex = 0;
            this.Red.Text = "red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(255, 28);
            this.Blue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(215, 199);
            this.Blue.TabIndex = 1;
            this.Blue.Text = "blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(487, 28);
            this.Yellow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(215, 199);
            this.Yellow.TabIndex = 3;
            this.Yellow.Text = "yellow";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(27, 232);
            this.Green.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(215, 199);
            this.Green.TabIndex = 2;
            this.Green.Text = "green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Location = new System.Drawing.Point(25, 459);
            this.scorelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(47, 13);
            this.scorelabel.TabIndex = 4;
            this.scorelabel.Text = "Score: 0";
            // 
            // patternlabel
            // 
            this.patternlabel.AutoSize = true;
            this.patternlabel.Location = new System.Drawing.Point(253, 459);
            this.patternlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patternlabel.Name = "patternlabel";
            this.patternlabel.Size = new System.Drawing.Size(50, 13);
            this.patternlabel.TabIndex = 5;
            this.patternlabel.Text = "Reeks: 0";
            this.patternlabel.Click += new System.EventHandler(this.patternlabel_Click);
            // 
            // Purple
            // 
            this.Purple.Location = new System.Drawing.Point(255, 232);
            this.Purple.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(215, 199);
            this.Purple.TabIndex = 6;
            this.Purple.Text = "purple";
            this.Purple.UseVisualStyleBackColor = true;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // Pink
            // 
            this.Pink.Location = new System.Drawing.Point(487, 232);
            this.Pink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(215, 199);
            this.Pink.TabIndex = 7;
            this.Pink.Text = "pink";
            this.Pink.UseVisualStyleBackColor = true;
            this.Pink.Click += new System.EventHandler(this.Pink_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lied 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 454);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 9;
            this.button2.Text = "Lied 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 454);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 10;
            this.button3.Text = "Lied 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 485);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.Purple);
            this.Controls.Add(this.patternlabel);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Red);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Simon Says";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label patternlabel;
        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button Pink;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

