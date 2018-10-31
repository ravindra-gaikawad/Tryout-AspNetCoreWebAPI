namespace QuoteAPI.Models
{
    public partial class Quote : BaseEntity
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }
    }
}
