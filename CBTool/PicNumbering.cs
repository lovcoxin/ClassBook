using CBTool.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBTool
{
    public partial class PicNumbering : Form
    {
        private bool StepCode;

        public PicNumbering()
        {
            InitializeComponent();
        }

        private void PicNumbering_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
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
            if (comboBox3.SelectedItem == null || comboBox2.SelectedItem == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("缺少选择", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox1.Text.Equals(string.Empty) || !canPares(textBox1.Text))
            {
                MessageBox.Show("数据不合法1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (e.Data == null || e.Data.GetData(DataFormats.FileDrop, false) == null)
            {
                MessageBox.Show("数据不合法2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] sources = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string path = sources[0];
            string code = textBox1.Text +
                "." + ((Item)comboBox3.SelectedItem).ID +
                "." + ((Item)comboBox2.SelectedItem).ID +
                "." + ((Item)comboBox1.SelectedItem).ID;
            File.Move(path, Path.GetDirectoryName(path) + "\\" + code + Path.GetExtension(path));
            if(StepCode)  
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void PicNumbering_Load(object sender, EventArgs e)
        {
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
            comboBox1.Items.Clear();
            foreach (var item in DataInfo.member_numbering.Keys)
            {
                string id = item;
                string name = DataInfo.member_numbering[item];
                Item item1 = new Item(id, name);
                comboBox1.Items.Add(item1);
            }
        }

        class Item
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            StepCode = checkBox1.Checked;
        }

        private void PicNumbering_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void PicNumbering_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
