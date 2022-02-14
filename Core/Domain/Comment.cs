namespace DynamicLoadingApp.Core.Domain
{
    public class Comment
    {
        public long Id { get; set; }
        public string Author { get; set; }
        public string Approved { get; set; }
        public DateTime DateGmt { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
    }
}