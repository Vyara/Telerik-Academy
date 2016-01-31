namespace HandlerTextToPng.Utils
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Text;

    public class TextToBitmap
    {
        public static Bitmap CreateBitmapImage(string sImageText)
        {
            Bitmap objBmpImage = new Bitmap(1024, 512);

            int intWidth = 0;
            int intHeight = 0;

            Font objFont = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            intWidth = (int)objGraphics.MeasureString(sImageText, objFont).Width;
            intHeight = (int)objGraphics.MeasureString(sImageText, objFont).Height;
            objBmpImage = new Bitmap(objBmpImage, new Size(intWidth, intHeight));
            objGraphics = Graphics.FromImage(objBmpImage);
            objGraphics.Clear(Color.White);
            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            objGraphics.DrawString(sImageText, objFont, new SolidBrush(Color.FromArgb(102, 102, 102)), 0, 0);
            objGraphics.Flush();
            return (objBmpImage);
        }
    }
}