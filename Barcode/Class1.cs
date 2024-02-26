using System;
using System.Drawing;


namespace ClassLibraryBar
{
    public class Barcode
    {
        public static Bitmap GenerateBarcode(string data, int barHeight, Color backgroundColor, Color barColor, Color textColor)
        {
            int digitWidth = 10;  
            int digitHeight = 20; 

            Bitmap barcodeBitmap = new Bitmap(data.Length * digitWidth, barHeight + digitHeight);

            using (Graphics g = Graphics.FromImage(barcodeBitmap))
            {
                g.Clear(backgroundColor);

                SolidBrush barBrush = new SolidBrush(barColor);
                SolidBrush textBrush = new SolidBrush(textColor);

                for (int i = 0; i < data.Length; i++)
                {
                    int x = i * digitWidth;
                    int y = 0;

                    int digit = int.Parse(data[i].ToString());

                    g.FillRectangle(barBrush, x + (digitWidth - digit), y, digit, barHeight);

                    string digitText = data[i].ToString();
                    SizeF textSize = g.MeasureString(digitText, SystemFonts.DefaultFont);
                    float textX = x + (digitWidth - textSize.Width) / 2;
                    float textY = barHeight;
                    g.DrawString(digitText, SystemFonts.DefaultFont, textBrush, textX, textY);
                }

                barBrush.Dispose();
                textBrush.Dispose();
            }

            return barcodeBitmap;
   }
        }
}
