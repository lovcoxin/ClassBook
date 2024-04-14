using CBTool.Properties;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using MetadataExtractor;
using Directory = System.IO.Directory;
using MetadataExtractor.Formats.Exif;

namespace CBTool
{
    public partial class PicNumbering : Form
    {
        private bool StepCode;
        public static PicNumbering instance;

        public PicNumbering()
        {
            InitializeComponent();
            instance = this;
        }

        private void PicNumbering_DragEnter(object sender, DragEventArgs e)
        {

        }

        public static bool canPares(string s)
        {
            try
            {
                int.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void PicNumbering_DragDrop(object sender, DragEventArgs e)
        {
            //if (comboBox3.SelectedItem == null || comboBox2.SelectedItem == null || comboBox1.SelectedItem == null)
            //{
            //    MessageBox.Show("缺少选择", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (textBox1.Text.Equals(string.Empty) || !canPares(textBox1.Text))
            //{
            //    MessageBox.Show("数据不合法1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (e.Data == null || e.Data.GetData(DataFormats.FileDrop, false) == null)
            //{
            //    MessageBox.Show("数据不合法2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //string[] sources = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //string path = sources[0];
            //string code = textBox1.Text +
            //    "." + ((Item)comboBox3.SelectedItem).ID +
            //    "." + ((Item)comboBox2.SelectedItem).ID +
            //    "." + ((Item)comboBox1.SelectedItem).ID;
            //File.Move(path, Path.GetDirectoryName(path) + "\\" + code + Path.GetExtension(path));
            //if (StepCode)
            //    textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void PicNumbering_Load(object sender, EventArgs e)
        {
            DataInfo.LoadFile();
            comboBox3.Items.Clear();
            foreach (var item in DataInfo.scene_numbering.Keys)
            {
                string id = item;
                string name = DataInfo.scene_numbering[item];
                Item item1 = new Item(id, name);
                comboBox3.Items.Add(item1);
            }
            comboBox2.Items.Clear();
            foreach (var item in DataInfo.category_numbering.Keys)
            {
                string id = item;
                string name = DataInfo.category_numbering[item];
                Item item1 = new Item(id, name);
                comboBox2.Items.Add(item1);
            }
        }

        internal class Item
        {
            public string ID { get; set; }
            public string Name { get; set; }

            public Item(string iD, string name)
            {
                ID = iD;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }

            public override bool Equals(object? obj)
            {
                if (obj == null) return false;
                if (obj == this) return true;
                if (obj is not Item) return false;
                Item item = (Item)obj;
                return item.ID.Equals(ID) && item.Name.Equals(Name);
            }

            public override int GetHashCode()
            {
                int hash = 1;
                hash = 31 * hash + ID.GetHashCode();
                hash = 31 * hash + Name.GetHashCode();
                return hash;
            }
        }

        private void PicNumbering_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void PicNumbering_FormClosing(object sender, FormClosingEventArgs e)
        {
            CBToolCS.instance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void LoadFile()
        {
            listBox1.Items.Clear();
            if (!Directory.Exists("images"))
            {
                Directory.CreateDirectory("images");
            }
            try
            {
                foreach (var filePath in Directory.EnumerateFiles("images", "*", SearchOption.TopDirectoryOnly))
                {
                    Console.WriteLine($"File: {filePath}");
                    // 在这里处理或访问文件信息
                    FileInfo fileInfo = new FileInfo(filePath);
                    ListItem listItem = new ListItem(filePath, fileInfo.Name);
                    listBox1.Items.Add(listItem);
                }
                var sortedItems = listBox1.Items.Cast<ListItem>()
                               .OrderBy(o => o.ID)
                               .ToList();

                listBox1.BeginUpdate();
                listBox1.Items.Clear();
                foreach (var item in sortedItems)
                {
                    listBox1.Items.Add(item);
                }
                listBox1.EndUpdate();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("发生错误\n" + exception.Message + "\n" + exception.StackTrace);
            }
            button2.Enabled = true;
        }

        private class ListItem : IComparable
        {
            public string Path { get; set; }
            public string Name { get; set; }
            public int ID { 
                get 
                {
                    string name = System.IO.Path.GetFileNameWithoutExtension(Path);
                    if (canPares(name))
                    {
                        int i = int.Parse(name);
                        return i;
                    }
                    return -1;
                }
            }

            public ListItem(string path, string name)
            {
                Path = path;
                Name = name;
            }

            public override string ToString() { return Name; }

            public int CompareTo(object? obj)
            {
                if (obj is not ListItem)
                    return 0;
                string name = System.IO.Path.GetFileNameWithoutExtension(Path);
                if (canPares(name))
                {
                    int i = int.Parse(name);
                    ListItem listItem = (ListItem)obj;
                    string name2 = System.IO.Path.GetFileNameWithoutExtension(listItem.Path);
                    if (canPares(name2))
                    {
                        int i2 = int.Parse(name2);
                        return i.CompareTo(i2);
                    }
                }
                return Name.CompareTo(obj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 0;
            List<int> nums = new List<int>();
            foreach (var filePath in Directory.EnumerateFiles("images", "*", SearchOption.TopDirectoryOnly))
            {
                string name = Path.GetFileNameWithoutExtension(filePath);
                if (canPares(name))
                {
                    int i = int.Parse(name);
                    nums.Add(i);
                }
            }
            nums.Sort((a, b) => b.CompareTo(a));
            if (nums.Count > 0)
            {
                num = nums[0] + 1;
            }
            foreach (var filePath in Directory.EnumerateFiles("images", "*", SearchOption.TopDirectoryOnly))
            {
                string name = Path.GetFileNameWithoutExtension(filePath);
                if (canPares(name))
                    continue;
                FileInfo fileInfo = new FileInfo(filePath);
                fileInfo.MoveTo(Path.GetDirectoryName(filePath) + "\\" + num + Path.GetExtension(filePath));
                num++;
            }
            LoadFile();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectWindow selectWindow = new SelectWindow();
            selectWindow.ShowDialog(this);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("没有选择类别！");
                return;
            }
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("没有选择场景！");
                return;
            }
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("没有选择人物！");
                return;
            }
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("没有选择图片！");
                return;
            }
            string filePath = @"file.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                IndexAndTag indexAndTag = JsonConvert.DeserializeObject<IndexAndTag>(jsonString);
                List<string> strings = new List<string>();
                foreach (Item item in listBox2.Items)
                {
                    strings.Add(item.ID);
                }
                IndexAndTag.Tag tag = new IndexAndTag.Tag(((Item)comboBox3.SelectedItem).ID, ((Item)comboBox2.SelectedItem).ID, strings);
                IndexAndTag.Element element = new IndexAndTag.Element(((ListItem)listBox1.SelectedItem).Name, tag);
                if (!indexAndTag.elements.Contains(element))
                {
                    indexAndTag.elements.Add(element);
                }
                else
                {
                    indexAndTag.elements.Remove(element);
                    indexAndTag.elements.Add(element);
                }
                string updatedJson = Newtonsoft.Json.JsonConvert.SerializeObject(indexAndTag, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            else
            {
                IndexAndTag indexAndTag = new IndexAndTag();
                List<string> strings = new List<string>();
                foreach (Item item in listBox2.Items)
                {
                    strings.Add(item.ID);
                }
                IndexAndTag.Tag tag = new IndexAndTag.Tag(((Item)comboBox3.SelectedItem).ID, ((Item)comboBox2.SelectedItem).ID, strings);
                IndexAndTag.Element element = new IndexAndTag.Element(((ListItem)listBox1.SelectedItem).Name, tag);
                indexAndTag.elements.Add(element);
                string updatedJson = Newtonsoft.Json.JsonConvert.SerializeObject(indexAndTag, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            //IndexAndTag indexAndTag = new IndexAndTag();
            //List<string> strings = new List<string>();
            //foreach (Item item in listBox2.Items)
            //{
            //    strings.Add(item.ID);
            //}
            //IndexAndTag.Tag tag = new IndexAndTag.Tag(((Item)comboBox3.SelectedItem).ID, ((Item)comboBox2.SelectedItem).ID, strings);
            //IndexAndTag.Element element = new IndexAndTag.Element(((ListItem)listBox1.SelectedItem).Name, tag);
            //indexAndTag.elements.Add(element);
            //var sb = new StringBuilder();
            //using (var stringWriter = new StringWriter(sb))
            //using (var jsonWriter = new JsonTextWriter(stringWriter))
            //{
            //    jsonWriter.Formatting = Formatting.Indented; // 可选：设置缩进以便输出美观的 JSON

            //    jsonWriter.WriteStartObject(); // 开始 JSON 对象

            //    jsonWriter.WritePropertyName("elements");

            //    foreach (var item in indexAndTag.elements) 
            //    {
            //        jsonWriter.WriteStartArray();
            //        jsonWriter.WriteValue(item.tag.scene_numbering);
            //        jsonWriter.WriteValue(item.tag.category_numbering);
            //        jsonWriter.WriteValue(item.tag.member_numbering);
            //        jsonWriter.WriteEndArray();
            //    }

            //    jsonWriter.WriteEndObject(); // 结束 JSON 对象
            //    string json = stringWriter.ToString();
            //    MessageBox.Show(json);
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            listBox2.Items.Clear();
            string filePath = @"file.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                IndexAndTag indexAndTag = JsonConvert.DeserializeObject<IndexAndTag>(jsonString);
                if (indexAndTag == null)
                {
                    MessageBox.Show("发生未知错误，无法读取json", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto ulabel;
                }
                IndexAndTag.Element element = null;
                foreach (var item in indexAndTag.elements)
                {

                    if (item.name.Equals(((ListItem)(listBox1.SelectedItem)).Name))
                    {
                        element = item;
                        break;
                    }
                }
                if (element == null)
                    goto ulabel;
                foreach (var item in comboBox3.Items)
                {
                    Item item1 = (Item)(item);
                    if (item1.ID.Equals(element.tag.scene_numbering))
                    {
                        comboBox3.SelectedItem = item1;
                        break;
                    }
                }
                foreach (var item in comboBox2.Items)
                {
                    Item item1 = (Item)(item);
                    if (item1.ID.Equals(element.tag.category_numbering))
                    {
                        comboBox2.SelectedItem = item1;
                        break;
                    }
                }
                foreach (var item in element.tag.member_numbering)
                {
                    Item item1 = new Item(item, DataInfo.member_numbering[item]);
                    listBox2.Items.Add(item1);
                }
            }
        ulabel:
            {
                ListItem listItem = (ListItem)listBox1.SelectedItem;
                FileInfo fileInfo = new FileInfo(listItem.Path);
                if (fileInfo.Exists)
                {
                    label1.Text = "图片格式：" + fileInfo.Extension;
                    label5.Text = "图片大小：" + FileSizeConverter.ConvertFileSize(fileInfo.Length);
                    label6.Text = "图片ID：" + Path.GetFileNameWithoutExtension(listItem.Path);
                    if (!checkBox1.Checked)
                        pictureBox1.ImageLocation = listItem.Path;
                    try
                    {
                        var directories = ImageMetadataReader.ReadMetadata(filePath);
                        foreach (var directory in directories.OfType<ExifIfd0Directory>())
                        {
                            foreach (var tag in directory.Tags)
                            {
                                string tagName = tag.Name;
                                object tagValue = tag.Description;

                                Program.LOGGER.Info($"{tagName}: {tagValue}");
                            }
                        }
                    }
                    catch(Exception ex) 
                    {
                        Program.LOGGER.Error(ex);
                    }
                }
                else
                {
                    MessageBox.Show(String.Format("文件{0}不存在", listItem.Path));
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定清除file.json文件？", "Warn", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = @"file.json";
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            ListItem listItem = (ListItem)listBox1.SelectedItem;
            FileInfo fileInfo = new FileInfo(listItem.Path);
            if (fileInfo.Exists)
            {
                try
                {
                    PicPreview picPreview = new PicPreview(Image.FromFile(listItem.Path));
                    picPreview.pictureBox1.ImageLocation = listItem.Path;
                    picPreview.ShowDialog();
                }
                catch (OutOfMemoryException ex)
                {
                    Program.LOGGER.Error("无法打开此格式的文件"+ex.ToString());
                }   
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            ListItem listItem = (ListItem)listBox1.SelectedItem;
            if (listItem == null) return;
            Console.WriteLine(listItem.Path);
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(Path.GetFullPath(listItem.Path));

                // 可选：隐藏启动程序的窗口（如果需要静默打开）
                // startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                // 启动新进程打开图片
                Process process = Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // 处理可能出现的异常，如文件不存在、没有关联程序等
                Debug.WriteLine($"无法打开文件：{ex.Message}");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Image = null;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
