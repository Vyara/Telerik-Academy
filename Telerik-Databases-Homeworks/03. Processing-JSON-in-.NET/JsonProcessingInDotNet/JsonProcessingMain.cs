namespace JsonProcessingInDotNet
{
    public class JsonProcessingMain
    {
        private const string TelerikAcademyRssYoutubeLink = @"https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        private const string VideosXmlPath = @"../../videos.xml";

      public static void Main()
        {
            var helper = new ProcessingHelper();

            helper.DownloadFeed(TelerikAcademyRssYoutubeLink, VideosXmlPath);

            var xmlDocument = helper.GetXml(VideosXmlPath);
            var json = helper.ConvertXmlToJson(xmlDocument);
            var videoTitles = helper.GetVideosTitles(json);
            helper.PrintVideosTitles(videoTitles);

            var videos = helper.GetVideos(json);
            helper.CreateHtmlFromVideoCollection(videos);
        }
    }
}
