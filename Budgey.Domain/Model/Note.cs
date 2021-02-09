using System;
using System.Collections.Generic;
using System.Text;

namespace Budgey.Domain.Model
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
