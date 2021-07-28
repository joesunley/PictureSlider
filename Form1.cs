using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PictureSlider.Properties;

namespace PictureSlider
{
     
    public partial class Form1 : Form
    {
        bool[,] grid = new bool[3, 3];
        List<PictureBox> pBoxes = new List<PictureBox>(9);
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            InitPBoxes();
            InitImg(Resources.InitialImage);
        }

        void InitPBoxes()
        {
            for (int i = 0; i < 9; i++)
            {
                foreach (PictureBox p in panel1.Controls)
                {
                    if (Convert.ToInt32(p.Tag) == i)
                        pBoxes.Add(p);
                }
            }
        }

        void InitImg(string fileLoc)
        {
            Image[] imgArr = new Image[9];
            Image img = ResizeImage(Image.FromFile(fileLoc), 300, 300);
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int index = i * 3 + j;
                    imgArr[index] = new Bitmap(100, 100);
                    Graphics g = Graphics.FromImage(imgArr[index]);
                    g.DrawImage(img, new Rectangle(0, 0, 100, 100), new Rectangle(i * 100, j * 100, 100, 100), GraphicsUnit.Pixel);
                    g.Dispose();
                }
            }

            List<Image> images = imgArr.ToList();
            for (int i = 0; i < 9; i++)
            {
                int r = rnd.Next(0, images.Count);
                pBoxes[i].Image = images[r];
                images.RemoveAt(r);
            }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grid[i, j] = true;

            int n = rnd.Next(0, 8);
            int[] loc = FromIndex(n);

            pBoxes[n].Image = null;
            pBoxes[n].BackColor = Color.White;
            grid[loc[0], loc[1]] = false;

        }

        void InitImg(Image image)
        {
            Image[] imgArr = new Image[9];
            Image img = ResizeImage(image, 300, 300);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int index = i * 3 + j;
                    imgArr[index] = new Bitmap(100, 100);
                    Graphics g = Graphics.FromImage(imgArr[index]);
                    g.DrawImage(img, new Rectangle(0, 0, 100, 100), new Rectangle(i * 100, j * 100, 100, 100), GraphicsUnit.Pixel);
                    g.Dispose();
                }
            }

            List<Image> images = imgArr.ToList();
            for (int i = 0; i < 9; i++)
            {
                int r = rnd.Next(0, images.Count);
                pBoxes[i].Image = images[r];
                images.RemoveAt(r);
            }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grid[i, j] = true;

            int n = rnd.Next(0, 8);
            int[] loc = FromIndex(n);

            pBoxes[n].Image = null;
            pBoxes[n].BackColor = Color.White;
            grid[loc[0], loc[1]] = false;
        }

        Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        int[] FromIndex(int i)
        {
            if (i == 0)
                return new int[] { 0, 0 };

            int rem;
            int div = Math.DivRem(i, 3, out rem);
            return new int[] { rem, div };
        }
        int AsIndex(int[] i)
        {
            int div = i[1],
                rem = i[0];

            return Convert.ToInt32(3f * (div + ((float)rem / 3)));
        }

        int CheckSwap(int i)
        {
            int[] loc = FromIndex(i);
            int x = loc[0],
                y = loc[1];

            try
            {
                if (x + 1 < 3)
                    if (grid[x + 1, y] == false)
                        return AsIndex(new int[] { x + 1, y });
                if (x - 1 > -1)
                    if (grid[x - 1, y] == false)
                        return AsIndex(new int[] { x - 1, y });
                if (y + 1 < 3)
                    if (grid[x, y + 1] == false)
                        return AsIndex(new int[] { x, y + 1 });
                if (y - 1 > -1)
                    if (grid[x, y - 1] == false)
                        return AsIndex(new int[] { x, y - 1 });
                return -1;
            }
            catch { return -1; }
        }

        void DoSwap(int a, int b)
        {
            PictureBox first = new PictureBox(),
                second = new PictureBox();
            foreach (PictureBox p in panel1.Controls)
            {
                if (Convert.ToInt32(p.Tag) == a)
                    first = p;
                if (Convert.ToInt32(p.Tag) == b)
                    second = p;
            }

            Image tmpImg = first.Image;
            first.Image = second.Image;
            second.Image = tmpImg;

            int[] a2 = FromIndex(a);
            int[] b2 = FromIndex(b);

            grid[a2[0], a2[1]] = false;
            grid[b2[0], b2[1]] = true;
        }

        void Tile_Clicked(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int a = Convert.ToInt32(p.Tag);
            int b = CheckSwap(a);

            if (b != -1)
                DoSwap(a, b);
        }

        void Open_Clicked(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|Bitmaps|*.bmp|PNG files|*.png|JPEG files|*.jpg|GIF files|*.gif|TIFF files|*.tif|All files|*.*";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.ShowDialog();

            string fileLoc = openFileDialog1.FileName;

            if (File.Exists(fileLoc))
                InitImg(fileLoc);
        }
    }
}
