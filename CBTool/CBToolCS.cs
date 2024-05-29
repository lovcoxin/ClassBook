using CBTool.Properties;
using System.Reflection;
using System.Text;

namespace CBTool
{
    public partial class CBToolCS : Form
    {
        public static CBToolCS instance;

        public CBToolCS()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "----------------------------------------------------------\r\n" +
                "CBToolCS\r\n" +
                $"版本:v{Assembly.GetExecutingAssembly().GetName().Version}\r\n" +
                "主仓库:https://github.com/lovcoxin/classbook\r\n" +
                "联系我(lovcoxin):lovcoxin@126.com\r\n" +
                "联系我(lxxgd):什么？居然还要写这个(\r\n" +
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
            picNumbering.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CBToolCS_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveWin picNumbering = new RemoveWin();
            picNumbering.Show();
            this.Hide();
        }
    }
}
