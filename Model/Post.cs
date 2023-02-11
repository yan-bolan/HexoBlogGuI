using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace ChiSaTo.Model
{
    public class Post
    {
        [DataMember(Order = 0)]
        [YamlMember(Alias = "title")]
        public string Title { get; set; }
        [DataMember(Order = 1)]
        [YamlMember(Alias = "cover")]
        public string cover = "https://api.isoyu.com/bing_images.php";//{ get; set; }

        [DataMember(Order = 2)]
        [YamlMember(Alias = "date")]
        public DateTime date { get; set; }
        [DataMember(Order = 3)]
        [YamlMember(Alias = "tags")]
        public List<string>? Tags { get; set; }


    }

    public class BlogFrontMatter
    {
        [YamlMember(Alias = "tags")]
        public string Tags { get; set; }

        [YamlMember(Alias = "title")]
        public string Title { get; set; }
        //[YamlMember(Alias = "image")]
        //public string Image { get; set; }
        //[YamlMember(Alias = "image_credit_name")]
        //public string ImageCreditName { get; set; }
        //[YamlMember(Alias = "image_credit_url")]
        //public string ImageCreditUrl { get; set; }
        //[YamlMember(Alias = "image_alt")]
        //public string ImageAlt { get; set; }

        //[YamlMember(Alias = "redirect_from")]
        //public string[] RedirectFrom { get; set; }

        [YamlIgnore]
        public IList<string> GetTags => Tags?
            .Split(",", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();
    }
}