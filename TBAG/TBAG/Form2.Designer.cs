﻿namespace TBAG
{
    partial class GameScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.storyText = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit To Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // storyText
            // 
            this.storyText.Location = new System.Drawing.Point(36, 209);
            this.storyText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.storyText.Multiline = true;
            this.storyText.Name = "storyText";
            this.storyText.ReadOnly = true;
            this.storyText.Size = new System.Drawing.Size(404, 201);
            this.storyText.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(36, 462);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(301, 22);
            this.inputBox.TabIndex = 2;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 462);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.userInputted);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 567);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.storyText);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameScreen";
            this.Text = "The Quest for the Random Undecided Shiny Object";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox storyText;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}
