using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBR
{
    public class ImageDraw
    {
        public void Drawing(List<Image> images)
        {
            foreach(Image img in images)
            {
                Draw();
            }
        }
        public void Draw()
        {

            Image bitmap = Bitmap.FromFile("C:\\Users\\Hp\\source\\repos\\BRONKZ\\BRONKZ\\wwwroot\\images\\a.JPG");
          //  Image image  = Bitmap.FromFile("C:\\Users\\Nuritdinov.A\\source\\repos\\Console\\Console\\image.jpg");

            Graphics graphicsImage = Graphics.FromImage(bitmap);

            StringFormat stringFormat1 = new StringFormat();

            stringFormat1.Alignment = StringAlignment.Far;

            StringFormat stringFormat2 = new StringFormat();

            stringFormat2.Alignment = StringAlignment.Center;

            Color strColor1 = ColorTranslator.FromHtml("#000");
            Color strColor2 = ColorTranslator.FromHtml("#0000ff");

            string txt1 = "HAPPY BRON";
            string txt2 = "dinning room";
          //  PointF pointF = new PointF(bitmap.Width - image.Width - 10, 10);
           // graphicsImage.DrawImage(image, pointF);
            //  graphicsImage.DrawString(txt1,new Font("Edwardian Script ITC",60,FontStyle.Regular), new SolidBrush(strColor1), new Point(400,150),stringFormat1);

            graphicsImage.DrawString(txt2, new Font("arial", 40, FontStyle.Bold), new SolidBrush(strColor2), new Point(bitmap.Width / 2, bitmap.Height - 40), stringFormat2);

            bitmap.Save("newtest.jpg");
        }
    }
}
