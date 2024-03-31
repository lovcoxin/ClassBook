using CBTool.Properties;

namespace CBTool
{
    public partial class CBToolCS : Form
    {
        public CBToolCS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "----------------------------------------------------------\r\n" +
                "CBToolCS\r\n" +
                "版本:v1.1\r\n" +
                "主仓库:https://github.com/lovcoxin/classbook\r\n" +
                "联系我(lovcoxin):lovcoxin@126.com\r\n" +
                "联系我(lxxgd):啊？居然要写这个(\r\n" +
                "仓库:https://github.com/lovcoxin/ClassBook/tree/CBToolCS\r\n" +
                "原版仓库:https://github.com/lovcoxin/ClassBook/tree/CBtool\r\n" +
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CBToolCS_Load(object sender, EventArgs e)
        {

        }
    }
}
