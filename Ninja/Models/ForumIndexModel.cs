using System.Collections.Generic;

namespace Ninja.Models
{
    public class ForumIndexModel
    {
        public int NumberOfForums { get; set; }
        public IEnumerable<ForumListingModel> ForumList { get; set; }
    }
}
