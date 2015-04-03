using System;
using System.Drawing;

namespace Tose2125.PaperCutter
{
    public struct PaperSize
    {
        public PaperSize(decimal width = 0, decimal height = 0)
        {
            if (width > 0) { _width = width; } else { _width = 0; }
            if (height > 0) { _height = height; } else { _height = 0; }
        }

        private decimal _width;
        private decimal _height;
        public decimal Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0) { throw new ArgumentOutOfRangeException(); }
                _width = value;
            }
        }
        public decimal Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value <= 0) { throw new ArgumentOutOfRangeException(); }
                _height = value;
            }
        }
        public decimal Area
        {
            get
            {
                return _width * _height;
            }
        }
    }
    public enum Anchor
    {
        //X方向(左+1,中央+0,右+2) & Y方向(上+3,中央+0,下+6)
        中央 = 0, 左上 = 4, 中央上 = 3, 右上 = 5, 右中央 = 2, 右下 = 8, 中央下 = 6, 左下 = 7, 左中央 = 1
    }

    public class ImageTrimming
    {
        public static Boolean Crop(ref Bitmap originalImage, String originalPath, PaperSize originalSize, PaperSize trimmingSize, Anchor trimmingAnchor)
        {
            //ミリメートルからピクセルへの変換
            decimal x = (originalSize.Width - trimmingSize.Width) * (originalImage.Width / originalSize.Width);//(mm-mm)*(px/mm)=px
            decimal y = (originalSize.Height - trimmingSize.Height) * (originalImage.Height / originalSize.Height);//余る長さをミリメートルからピクセルに変換します
            if (x < 0 || trimmingAnchor.GetHashCode() % 3 == 1) { x = 0; }//左詰め(1,4,7)
            if (y < 0 || Math.Floor((Double)trimmingAnchor.GetHashCode() / 3) == 1) { y = 0; }//上詰め(3,4,5)
            if (trimmingAnchor.GetHashCode() % 3 == 0) { x = x / 2; }//左右中央揃え(0,3,6)
            if (Math.Floor((Double)trimmingAnchor.GetHashCode() / 3) == 0) { y = y / 2; }//上下中央揃え(0,1,2)
            decimal w = trimmingSize.Width * originalImage.Width / originalSize.Width;//mm*px/mm=px
            decimal h = trimmingSize.Height * originalImage.Height / originalSize.Height;//残す長さをミリメートルからピクセルに変換します
            //画像切り取り範囲の確定
            Rectangle trimmingRectangular = new Rectangle();
            trimmingRectangular.X = (int)Math.Floor(x);
            trimmingRectangular.Y = (int)Math.Floor(y);
            trimmingRectangular.Width = (int)Math.Ceiling(w);
            trimmingRectangular.Height = (int)Math.Ceiling(h);
            //保存先
            String trimmingPath = originalPath.Insert(originalPath.LastIndexOf("."), "." + trimmingRectangular.Width.ToString() + "x" + trimmingRectangular.Height.ToString());
            //保存
            try
            {
                originalImage.Clone(trimmingRectangular, originalImage.PixelFormat).Save(trimmingPath);
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (System.IO.IOException)
            {
                return false;
            }
            return true;
        }
    }

}