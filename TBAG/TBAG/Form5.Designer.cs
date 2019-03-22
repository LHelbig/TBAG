namespace TBAG
{
    partial class LoadGame
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
            this.saveSlot1 = new System.Windows.Forms.Button();
            this.saveSlot2 = new System.Windows.Forms.Button();
            this.saveSlot3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveSlot1
            // 
            this.saveSlot1.AutoSize = true;
            this.saveSlot1.Location = new System.Drawing.Point(112, 75);
            this.saveSlot1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveSlot1.Name = "saveSlot1";
            this.saveSlot1.Size = new System.Drawing.Size(145, 28);
            this.saveSlot1.TabIndex = 0;
            this.saveSlot1.Text = "Saved Adventure 1";
            this.saveSlot1.UseVisualStyleBackColor = true;
            // 
            // saveSlot2
            // 
            this.saveSlot2.AutoSize = true;
            this.saveSlot2.Location = new System.Drawing.Point(112, 154);
            this.saveSlot2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveSlot2.Name = "saveSlot2";
            this.saveSlot2.Size = new System.Drawing.Size(145, 28);
            this.saveSlot2.TabIndex = 1;
            this.saveSlot2.Text = "Saved Adventure 2";
            this.saveSlot2.UseVisualStyleBackColor = true;
            // 
            // saveSlot3
            // 
            this.saveSlot3.AutoSize = true;
            this.saveSlot3.Location = new System.Drawing.Point(112, 242);
            this.saveSlot3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveSlot3.Name = "saveSlot3";
            this.saveSlot3.Size = new System.Drawing.Size(149, 28);
            this.saveSlot3.TabIndex = 2;
            this.saveSlot3.Text = "Saved Adventure 3 ";
            this.saveSlot3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveSlot3);
            this.Controls.Add(this.saveSlot2);
            this.Controls.Add(this.saveSlot1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoadGame";
            this.Text = "The Quest for the Random Undecided Shiny Object";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveSlot1;
        private System.Windows.Forms.Button saveSlot2;
        private System.Windows.Forms.Button saveSlot3;
        private System.Windows.Forms.Button button1;
    }
}