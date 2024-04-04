namespace CBTool
{
    partial class CBToolCS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CBToolCS));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            rainbowLabel1 = new RainbowLabel();
            rainbowButton1 = new RainbowButton();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // rainbowLabel1
            // 
            resources.ApplyResources(rainbowLabel1, "rainbowLabel1");
            rainbowLabel1.BackColor = SystemColors.Control;
            rainbowLabel1.Float = true;
            rainbowLabel1.Name = "rainbowLabel1";
            // 
            // rainbowButton1
            // 
            rainbowButton1.Float = true;
            resources.ApplyResources(rainbowButton1, "rainbowButton1");
            rainbowButton1.Name = "rainbowButton1";
            rainbowButton1.RealText = "test";
            rainbowButton1.UseVisualStyleBackColor = true;
            // 
            // CBToolCS
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rainbowButton1);
            Controls.Add(rainbowLabel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "CBToolCS";
            Load += CBToolCS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private RainbowLabel rainbowLabel1;
        private RainbowButton rainbowButton1;
    }
}
