namespace CBTool
{
    partial class PicNumbering
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
            components = new System.ComponentModel.Container();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            listBox2 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            删除ToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            toolTip1 = new ToolTip(components);
            label7 = new Label();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(108, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "a" });
            comboBox3.Location = new Point(108, 16);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 25);
            comboBox3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 201);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "图片属性";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 103);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 12;
            label6.Text = "图片ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 69);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 11;
            label5.Text = "图片大小";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 10;
            label1.Text = "图片格式";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(listBox2);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(182, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 173);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "标签";
            // 
            // button3
            // 
            button3.Location = new Point(6, 133);
            button3.Name = "button3";
            button3.Size = new Size(97, 34);
            button3.TabIndex = 10;
            button3.Text = "保存";
            toolTip1.SetToolTip(button3, "将设置的标签保存到file.json");
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.ContextMenuStrip = contextMenuStrip1;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(109, 81);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 89);
            listBox2.TabIndex = 7;
            toolTip1.SetToolTip(listBox2, "双击填加项，右键打开菜单删除项");
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            listBox2.MouseDoubleClick += listBox2_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 删除ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            删除ToolStripMenuItem.Size = new Size(100, 22);
            删除ToolStripMenuItem.Text = "删除";
            删除ToolStripMenuItem.Click += 删除ToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 81);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 6;
            label4.Text = "人物";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 19);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 4;
            label2.Text = "场景";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 50);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 5;
            label3.Text = "类别";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(3, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(417, 224);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 8;
            button1.Text = "加载文件";
            toolTip1.SetToolTip(button1, "把images的文件加载到文件列表中");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(93, 34);
            button2.Name = "button2";
            button2.Size = new Size(75, 39);
            button2.TabIndex = 9;
            button2.Text = "自动编号";
            toolTip1.SetToolTip(button2, "将图片名重命名为数字形式");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.Red;
            button4.Location = new Point(174, 34);
            button4.Name = "button4";
            button4.Size = new Size(164, 39);
            button4.TabIndex = 10;
            button4.Text = "清除file.json标签数据文件";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDoubleClick += pictureBox1_MouseDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel1);
            groupBox3.Location = new Point(441, 79);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(528, 453);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "图片预览（简易）";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 431);
            panel1.TabIndex = 12;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBox1);
            groupBox4.Location = new Point(12, 286);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(423, 246);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "文件列表";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(444, 22);
            label7.Name = "label7";
            label7.Size = new Size(140, 17);
            label7.TabIndex = 14;
            label7.Text = "双击人物列表来添加人物";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(447, 44);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(327, 21);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "不预览图片（防止潜在的异常发生，例如文件无法打开）";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // PicNumbering
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 544);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PicNumbering";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "图片编号";
            FormClosing += PicNumbering_FormClosing;
            FormClosed += PicNumbering_FormClosed;
            Load += PicNumbering_Load;
            DragDrop += PicNumbering_DragDrop;
            DragEnter += PicNumbering_DragEnter;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        internal ListBox listBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label1;
        private Button button4;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Panel panel1;
        private GroupBox groupBox4;
        private ToolTip toolTip1;
        private Label label7;
        private CheckBox checkBox1;
    }
}