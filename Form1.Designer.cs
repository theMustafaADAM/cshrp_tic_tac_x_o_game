
namespace xo_tic_tac
{
    partial class tictacXO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblwinner = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rubik Mono One", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(435, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 91);
            this.label1.TabIndex = 9;
            this.label1.Text = "X O : Tic Tac Toe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(50, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 60);
            this.label2.TabIndex = 13;
            this.label2.Text = "TURN :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(50, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 60);
            this.label3.TabIndex = 14;
            this.label3.Text = "WINNER :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblwinner
            // 
            this.lblwinner.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblwinner.ForeColor = System.Drawing.Color.Lime;
            this.lblwinner.Location = new System.Drawing.Point(200, 289);
            this.lblwinner.Name = "lblwinner";
            this.lblwinner.Size = new System.Drawing.Size(190, 60);
            this.lblwinner.TabIndex = 16;
            this.lblwinner.Text = "In Progress";
            this.lblwinner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTurn
            // 
            this.lblTurn.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblTurn.ForeColor = System.Drawing.Color.LightGray;
            this.lblTurn.Location = new System.Drawing.Point(200, 212);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(170, 60);
            this.lblTurn.TabIndex = 15;
            this.lblTurn.Text = "1st Player";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(89, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 72);
            this.button1.TabIndex = 12;
            this.button1.Text = "RESTART XO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(89, 488);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn9
            // 
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Location = new System.Drawing.Point(869, 485);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(150, 115);
            this.btn9.TabIndex = 8;
            this.btn9.Tag = "?";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Location = new System.Drawing.Point(869, 323);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(150, 115);
            this.btn6.TabIndex = 5;
            this.btn6.Tag = "?";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Location = new System.Drawing.Point(869, 160);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 115);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "?";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn8
            // 
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Location = new System.Drawing.Point(653, 485);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(150, 115);
            this.btn8.TabIndex = 7;
            this.btn8.Tag = "?";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Location = new System.Drawing.Point(653, 323);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(150, 115);
            this.btn5.TabIndex = 4;
            this.btn5.Tag = "?";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Location = new System.Drawing.Point(653, 160);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 115);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "?";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Location = new System.Drawing.Point(435, 485);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(150, 115);
            this.btn7.TabIndex = 2;
            this.btn7.Tag = "?";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Location = new System.Drawing.Point(435, 323);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(150, 115);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "?";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Location = new System.Drawing.Point(435, 160);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 115);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "?";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tictacXO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblwinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("Tahoma", 28F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "tictacXO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tic tac XO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.tictacXO_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblwinner;
        private System.Windows.Forms.Label lblTurn;
    }
}

