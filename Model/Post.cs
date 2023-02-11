using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiSaTo.Model
{
    public class Post
    {
        public string Title { get; set; }

        public List<string>? Tags   { get; set; }
        public DateTime Create_Time { get; set; } 

    }
}
