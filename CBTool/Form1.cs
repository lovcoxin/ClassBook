using CBTool.Properties;

namespace CBTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "----------------------------------------------------------\r\n" +
                "mainHub        https://github.com/lovcoxin/classbook\r\n" +
                "contact me     lovcoxin@126.com\r\n" +
                "----------------------------------------------------------",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PicNumbering picNumbering = new PicNumbering();
            picNumbering.ShowDialog();
        }
    }
}
