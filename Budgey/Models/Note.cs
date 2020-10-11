using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Budgey.Models
{
    public class Note
    {
        [DisplayName("Identity")]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //First 50 signs of Content
        [DisplayName("Shortened Content")]
        public string ShortContent { get; set; }
    }
}
