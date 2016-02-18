namespace SimplePhotoAlbum
{
    using System;

    public partial class Index : System.Web.UI.Page
    {
        [System.Web.Services.WebMethod]
        public static AjaxControlToolkit.Slide[] GetSlides()
        {
            AjaxControlToolkit.Slide[] imgSlide = new AjaxControlToolkit.Slide[4];

            imgSlide[1] = new AjaxControlToolkit.Slide("images/cat1.jpg", "first cat", "Pretty cat");
            imgSlide[2] = new AjaxControlToolkit.Slide("images/cat2.jpg", "second cat", "Another pretty cat");
            imgSlide[0] = new AjaxControlToolkit.Slide("images/cat3.jpg", "third cat", "Some cats");
            imgSlide[3] = new AjaxControlToolkit.Slide("images/cat4.jpg", "fourth cat", "Yet another pretty cat");

            return imgSlide;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}