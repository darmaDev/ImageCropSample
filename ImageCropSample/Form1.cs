using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;

namespace ImageCropSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crop1Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var stream = dialog.OpenFile();
                    using var croppedBmp = Crop1(new Bitmap(stream), new Rectangle(0, 0, 1170, 140));

                    croppedBmp.Save("crop1.png", ImageFormat.Png);
                }
            }
        }

        private void crop2Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var stream = dialog.OpenFile();
                    using var croppedBmp = Crop2(new Bitmap(stream), new Rectangle(0, 0, 1170, 140));

                    croppedBmp.Save("crop2.png", ImageFormat.Png);
                }
            }
        }

        private void embeddedButton_Click(object sender, EventArgs e)
        {
            var path = "ImageCropSample.Resources.base.png";
            var assm = Assembly.GetExecutingAssembly();
            using var stream = assm.GetManifestResourceStream(path);

            using var croppedBmp = Crop1(new Bitmap(stream), new Rectangle(0, 0, 1170, 140));

            croppedBmp.Save("embedded.png", ImageFormat.Png);
        }

        private static Bitmap Crop1(Bitmap src, Rectangle roi)
        {
            //srcとroiの重なった領域を取得
            var imgRect = new Rectangle(0, 0, src.Width, src.Height);
            var roiTrim = Rectangle.Intersect(imgRect, roi);
            // 画像の外の領域を指定した場合
            if (roiTrim.IsEmpty) return null;

            // 画像の切り出し
            var dest = new Bitmap(roiTrim.Width, roiTrim.Height, src.PixelFormat);
            var g = Graphics.FromImage(dest);
            var destRect = new Rectangle(0, 0, roiTrim.Width, roiTrim.Height);
            g.DrawImage(src, destRect, roiTrim, GraphicsUnit.Pixel);
            g.Dispose();

            return dest;
        }

        private static Bitmap Crop2(Bitmap src, Rectangle roi)
        {
            return src.Clone(roi, src.PixelFormat);
        }
    }
}
