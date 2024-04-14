using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBTool
{
    public partial class PicPreview : Form
    {
        public Image Image { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        private int _width = 0;
        private int _height = 0;
        private List<Bitmap> bitmaps = new List<Bitmap>();
        private int _rot;

        public PicPreview(Image image)
        {
            InitializeComponent();
            Image = image;
            Width = Image.Width;
            Height = Image.Height;
            _width = Width;
            _height = Height;
            panel1.MouseWheel += PictureBox1_MouseWheel;
            pictureBox1.MouseWheel += PictureBox1_MouseWheel;
        }

        private void PictureBox1_MouseWheel(object? sender, MouseEventArgs e)
        {
            const double ZoomStep = 0.1; // 缩放步长，可根据需要调整
            var pictureBox = pictureBox1;

            // 判断滚轮方向（正数表示向前滚动，负数表示向后滚动）
            double scaleFactor = e.Delta > 0 ? 1 + ZoomStep : 1 / (1 + ZoomStep);

            // 获取当前图片的原始尺寸
            Image originalImage = Image;
            if (originalImage == null) return;

            // 计算新的尺寸
            int newWidth = (int)(Width * scaleFactor);
            int newHeight = (int)(Height * scaleFactor);

            // 避免缩放后尺寸过小或超出控件边界
            newWidth = Math.Max(newWidth, _width / 10);
            newHeight = Math.Max(newHeight, _height / 10);
            newWidth = Math.Min(newWidth, _width * 10);
            newHeight = Math.Min(newHeight, _height * 10);

            if (newHeight == Height && newWidth == Width)
            {
                return;
            }

            // 使用Graphics对象进行缩放操作
            var tempBitmap = new Bitmap(newWidth, newHeight);
            using var g = Graphics.FromImage(tempBitmap);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(originalImage, new Rectangle(0, 0, newWidth, newHeight));
            Width = newWidth;
            Height = newHeight;
            for (int i = 0; i < _rot; i++) 
            {
                tempBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            pictureBox.Image = tempBitmap;
            bitmaps.Add(tempBitmap);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {

        }

        private void PicPreview_Load(object sender, EventArgs e)
        {

        }

        private void PicPreview_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var item in bitmaps)
            {
                item.Dispose();
            }
        }

        private void rainbowButton1_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = (Bitmap)pictureBox1.Image;
            originalImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            _rot++;
            pictureBox1.Image = originalImage;
        }
    }
}
