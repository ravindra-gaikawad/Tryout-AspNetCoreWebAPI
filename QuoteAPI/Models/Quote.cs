using System;
using System.Collections.Generic;

namespace QuoteAPI.Models
{
    public partial class Quote
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
    }
}
