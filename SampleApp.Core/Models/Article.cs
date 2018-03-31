using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public int CategoryId { get; set; }
        public string PictureUrl { get; set; }
        public int Author { get; set; }
    }
}
