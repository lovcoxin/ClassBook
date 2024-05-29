using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CBTool
{
    public partial class RemoveWin : Form
    {
        public RemoveWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"file.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                IndexAndTag indexAndTag = JsonConvert.DeserializeObject<IndexAndTag>(jsonString);
                if (indexAndTag == null)
                {
                    MessageBox.Show("发生未知错误，无法读取json", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Directory.Exists("remove"))
                {
                    Directory.CreateDirectory("remove");
                }
                List<string> fileName = new List<string>();
                foreach (IndexAndTag.Element element in indexAndTag.elements)
                {
                    fileName.Add(element.name);
                }
                try
                {
                    foreach (var filePath2 in Directory.EnumerateFiles("images", "*", SearchOption.TopDirectoryOnly))
                    {
                        Console.WriteLine($"File: {filePath2}");
                        // 在这里处理或访问文件信息
                        FileInfo fileInfo = new FileInfo(filePath2);
                        if (!fileName.Contains(fileInfo.Name))
                            fileInfo.MoveTo("remove\\" + fileInfo.Name);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    MessageBox.Show("发生错误\n" + exception.Message + "\n" + exception.StackTrace);
                }
            }
        }

        private void RemoveWin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void RemoveWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            CBToolCS.instance.Show();
        }
    }
}
