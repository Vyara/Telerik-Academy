namespace WebImageCounter
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Web.UI;

    public partial class ImageForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["visits"] == null)
            {
                Session.Add("visits", 1);
            }
            else
            {
                var num = (int)Session["visits"];
                this.Session["visits"] = ++num;
            }

            Bitmap generatedImage = new Bitmap(110, 110);
            using (generatedImage)
            {
                Graphics gr = Graphics.FromImage(generatedImage);
                using (gr)
                {
                    gr.FillRectangle(Brushes.MediumSeaGreen, 0, 0, 200, 200);

                    gr.DrawString(
                        ((int)Session["visits"]).ToString(),
                        new Font("Segoe UI", 25),
                        new SolidBrush(Color.BlanchedAlmond),
                         new PointF(35, 30));
                    
                    Response.ContentType = "image/jpeg";

                    generatedImage.Save(Response.OutputStream, ImageFormat.Jpeg);
                }
            }
        }
        }
    }