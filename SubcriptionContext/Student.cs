using Balta.Shared;
using System.Collections.Generic;
using System.Linq;

namespace Balta.SubcriptionContext
{
    public class Student : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User Username { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremiun => Subscriptions.Any(x => !x.IsInactive);
    }
}
