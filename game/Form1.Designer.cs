namespace game
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
            this.label1 = new System.Windows.Forms.Label();
            this.myname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 50F);
            this.label1.Location = new System.Drawing.Point(30, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // myname
            // 
            this.myname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myname.Location = new System.Drawing.Point(274, 582);
            this.myname.Name = "myname";
            this.myname.Size = new System.Drawing.Size(406, 60);
            this.myname.TabIndex = 1;
            this.myname.Text = "Made By: Lucas Metz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::game.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(85, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1296, 527);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1401, 651);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.myname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label myname;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

