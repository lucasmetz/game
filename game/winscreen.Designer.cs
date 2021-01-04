namespace game
{
    partial class winscreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::game.Properties.Resources.winscreen;
            this.pictureBox1.Location = new System.Drawing.Point(-386, -258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1306, 954);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.score.Location = new System.Drawing.Point(812, 390);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(51, 23);
            this.score.TabIndex = 1;
            this.score.Text = "score";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // winscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 689);
            this.Controls.Add(this.score);
            this.Controls.Add(this.pictureBox1);
            this.Name = "winscreen";
            this.Text = "winscreen";
            this.Load += new System.EventHandler(this.winscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label score;
    }
}