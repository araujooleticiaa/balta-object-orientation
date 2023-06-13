using Balta.DataContext.Enums;
using System.Collections.Generic;

namespace Balta.DataContext
{
    public class Course : Content
    {
        public Course(string title, string url) : base(title, url)
        {
            Modules = new List<Module>();
        }
        public IList<Module> Modules { get; set; }
        public string Tag { get; set; }
        public EContentLevel Level { get; set; }
    }
}
