namespace JsonProcessingInDotNet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using POCOClasses;

    public class ProcessingHelper
    {
        public void DownloadFeed(string address, string file)
        {
            var webClient = new WebClient { Encoding = Encoding.UTF8 };
            webClient.DownloadFile(address, file);
        }

        public XmlDocument GetXml(string filePath)
        {
            var document = new XmlDocument();
            document.Load(filePath);

            return document;
        }

        public JObject ConvertXmlToJson(XmlDocument document)
        {
            string json = JsonConvert.SerializeXmlNode(document);
            var jsonObject = JObject.Parse(json);

            return jsonObject;
        }

        public void CreateHtmlFromVideoCollection(IEnumerable<Video> videos)
        {
            var document = new XDocument();
            document.AddFirst(new XDocumentType("html", null, null, null));

            var html = new XElement("html");
            var head = new XElement("head");
            var meta = new XElement("meta");

            meta.SetAttributeValue("charset", "UTF - 8");
            head.Add(meta);

            var title = new XElement("title", "Telerik Academy Video Archive");
            head.Add(title);

            var styles = new XElement("link");
            styles.SetAttributeValue("rel", "stylesheet");
            styles.SetAttributeValue("href", "styles/video-archive-styles.css");
            head.Add(styles);

            html.Add(head);

            var body = new XElement("body");
            var pageTitle = new XElement("h1", "Telerik Academy Videos");
            body.Add(pageTitle);

            foreach (var video in videos)
            {
                var div = new XElement("div", new XElement("h3", video.Title));
                div.SetAttributeValue("class", "container");

                var videoFrame = new XElement("iframe", string.Empty);
                videoFrame.SetAttributeValue("frameborder", "0");
                videoFrame.SetAttributeValue("src", "https://www.youtube.com/embed/" + video.VideoId);
                div.Add(videoFrame);

                var youtubeLink = new XElement("a", "Youtube");
                youtubeLink.SetAttributeValue("href", video.Link);

                div.Add(youtubeLink);
                body.Add(div);
            }

            html.Add(body);
            document.Add(html);
            var writerSettings = new XmlWriterSettings();
            writerSettings.OmitXmlDeclaration = true;
            writerSettings.NewLineOnAttributes = true;
            writerSettings.Indent = true;

            var writer = XmlWriter.Create("../../index.html", writerSettings);
            document.Save(writer);
            writer.Close();

            Console.WriteLine("index.html generated");
        }

        public IEnumerable<Video> GetVideos(JObject obj)
        {
            var videos = obj["feed"]["entry"].Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));

            return videos;
        }

        public IEnumerable<JToken> GetVideosTitles(JObject obj)
        {
            var titles = obj["feed"]["entry"].Select(entry => entry["title"]);

            return titles;
        }

        public void PrintVideosTitles(IEnumerable<JToken> titles)
        {
            Console.OutputEncoding = Encoding.Unicode; // change it ti UTF-8 in case it doesn't render properly

            Console.WriteLine("Titles: ");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Console.WriteLine(string.Join(Environment.NewLine, titles));
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
        }
    }
}
