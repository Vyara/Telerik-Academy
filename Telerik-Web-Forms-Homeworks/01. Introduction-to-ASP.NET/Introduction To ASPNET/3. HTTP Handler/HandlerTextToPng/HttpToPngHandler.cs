namespace HandlerTextToPng
{
    using System.Drawing.Imaging;
    using System.Web;
    using Utils;

    public class HttpToPngHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/png";

            var text = context.Request.Params["text"];
            if (text == null)
            {
                text = string.Empty;
            }

            var image = TextToBitmap.CreateBitmapImage(text);

            image.Save(context.Response.OutputStream, ImageFormat.Png);
        }

    }
}