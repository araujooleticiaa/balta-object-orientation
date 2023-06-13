using System.Collections.Generic;

namespace Balta.DataContext
{
    public class Career : Content
    {
        public Career(IList<CareerItem> items, string title, string url) : base(title, url) 
        {
            Items = new List<CareerItem>();
        }

        public IList<CareerItem> Items { get; set; }

        public int TotalCourses => Items.Count;
    }
}
