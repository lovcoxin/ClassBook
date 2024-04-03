﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CBTool
{
    internal class RainbowButton : Button
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int DiscoStyle;
        private int DiscoG;
        private int DiscoB;
        private int DiscoR;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("是否启用浮动效果")]
        public bool Float { get; set; }
        [Browsable(true)]
        [Category("Appearance")]
        [Description("真实文本")]
        public string RealText { get; set; }

        public RainbowButton() : base()
        {
            timer.Interval = 16;
            timer.Start();
            timer.Tick += Timer_Tick;
            RealText = "";
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            this.Refresh();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                timer.Dispose();
            base.Dispose(disposing);
        }

        float num3 = 0;

        public static double Lerp(double value1, double value2, double amount)
        {
            return value1 + (value2 - value1) * amount;
        }

        public static Rectangle DeflateRect(Rectangle rect, Padding padding)
        {
            rect.X += padding.Left;
            rect.Y += padding.Top;
            rect.Width -= padding.Horizontal;
            rect.Height -= padding.Vertical;
            return rect;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            Text = "";
            base.OnPaint(pevent);
            //Pen pen = new Pen(BackColor);
            //graphics.FillRectangle(new SolidBrush(BackColor), new RectangleF(new PointF(0,0),new SizeF(Size*0.8f)));
            int num = 7;
            if (this.DiscoStyle == 0)
            {
                DiscoG += num;
                if (DiscoG >= 255)
                {
                    DiscoG = 255;
                    this.DiscoStyle++;
                }
            }
            if (this.DiscoStyle == 1)
            {
                DiscoR -= num;
                if (DiscoR <= 0)
                {
                    DiscoR = 0;
                    this.DiscoStyle++;
                }
            }
            if (this.DiscoStyle == 2)
            {
                DiscoB += num;
                if (DiscoB >= 255)
                {
                    DiscoB = 255;
                    this.DiscoStyle++;
                }
            }
            if (this.DiscoStyle == 3)
            {
                DiscoG -= num;
                if (DiscoG <= 0)
                {
                    DiscoG = 0;
                    this.DiscoStyle++;
                }
            }
            if (this.DiscoStyle == 4)
            {
                DiscoR += num;
                if (DiscoR >= 255)
                {
                    DiscoR = 255;
                    this.DiscoStyle++;
                }
            }
            if (this.DiscoStyle == 5)
            {
                DiscoB -= num;
                if (DiscoB <= 0)
                {
                    DiscoB = 0;
                    this.DiscoStyle = 0;
                }
            }
            num += 1;
            if (num > 180.0F)
            {
                num = 0;
            }           
            string text = RealText;
            System.Drawing.Font font = new System.Drawing.Font(this.Font.FontFamily, 10f);
            Rectangle rectangle = DeflateRect(this.ClientRectangle, this.Padding);
            float x = (rectangle.X + rectangle.Width/2 - graphics.MeasureString(text, font, int.MaxValue, StringFormat.GenericTypographic).Width/2);
            float y = rectangle.Y;
            double huehuehue = (DateTime.Now.Ticks) % 1;
            double s = 0;
            double l = 0;
            ColorHelper.RGBToHSL(Color.FromArgb(DiscoR, DiscoG, DiscoB), ref huehuehue, ref s, ref l);
            num3 += 1;
            if (num3 > 512)
            {
                num3 = 0;
            }
            huehuehue /= 360;
            float huehuehueStep = (float)Math.PI / 60f/*(float)rangeRemap(Math.Sin((double)((float)DateTime.Now.Ticksnum2 / 500)) % 6.28318, -1.5, 1.5, 0.01, 0.15)*/;
            Color color = Color.White;
            float posX = x;
            for (int i = 0; i < text.Length; i++)
            {
                float yOffset = (float)Math.Sin(i + num3 / 6);
                //huehuehue /= i;
                huehuehue += huehuehueStep;
                huehuehue %= 1.0F;    
                //posX +=TextRenderer.MeasureText(text[i].ToString(), font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.Default).Width*0.6f;
                Brush brush = new SolidBrush(ColorHelper.HslToRgb(huehuehue * 360, 1 * 255, 0.5f * 255));
                if (Float)
                    graphics.DrawString(text[i].ToString(), font, brush, posX, y + yOffset * 3);
                else
                    graphics.DrawString(text[i].ToString(), font, brush, posX, y);
                posX += graphics.MeasureString(text[i].ToString(), font, int.MaxValue, StringFormat.GenericTypographic).Width;
            }
        }
    }
}
