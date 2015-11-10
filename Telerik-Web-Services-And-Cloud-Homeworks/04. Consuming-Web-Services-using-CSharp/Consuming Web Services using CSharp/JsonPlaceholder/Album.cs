namespace JsonPlaceholder
{
    using Newtonsoft.Json;

    public class Album
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}\nUserId: {1}\nTitle: {2}\n", this.Id, this.UserId,  this.Title);
        }
    }
}
