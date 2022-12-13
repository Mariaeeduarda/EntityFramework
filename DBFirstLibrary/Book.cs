using System;
using System.Collections.Generic;

namespace DBFirstLibrary
{

    public partial class Books
    {
        public long Id { get; set; }

        public string Title { get; set; } = null!;

        public long PublicationYear { get; set; }

        public long AuthorId { get; set; }

        public virtual Authors Author { get; set; }
    }
}