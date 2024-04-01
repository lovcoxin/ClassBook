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
    public partial class SelectWindow : Form
    {
        public SelectWindow()
        {
            InitializeComponent();
        }

        private void SelectWindow_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in DataInfo.member_numbering.Keys)
            {
                string id = item;
                string name = DataInfo.member_numbering[item];
                Item item1 = new Item(id, name);
                comboBox1.Items.Add(item1);
            }
        }

        private class Item
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = comboBox1.SelectedItem as Item;
            if (item == null)
            {
                return;
            }
            PicNumbering.Item item1 = new PicNumbering.Item(item.ID, item.Name);
            if(PicNumbering.instance.listBox2.Items.Contains(item1))
                return;
            PicNumbering.instance.listBox2.Items.Add(item1);
            this.Close();
        }
    }
}
