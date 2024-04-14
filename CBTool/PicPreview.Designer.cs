namespace CBTool
{
    partial class PicPreview
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            rainbowButton1 = new RainbowButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(132, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 480);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(704, 480);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Resize += pictureBox1_Resize;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rainbowButton1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(126, 480);
            panel2.TabIndex = 1;
            // 
            // rainbowButton1
            // 
            rainbowButton1.Float = false;
            rainbowButton1.Location = new Point(26, 12);
            rainbowButton1.Name = "rainbowButton1";
            rainbowButton1.RealText = "旋转90°";
            rainbowButton1.Size = new Size(75, 23);
            rainbowButton1.TabIndex = 0;
            rainbowButton1.UseVisualStyleBackColor = true;
            rainbowButton1.Click += rainbowButton1_Click;
            // 
            // PicPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 480);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PicPreview";
            Text = "PicPreview";
            FormClosed += PicPreview_FormClosed;
            Load += PicPreview_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public PictureBox pictureBox1;
        private Panel panel2;
        private RainbowButton rainbowButton1;
    }
}