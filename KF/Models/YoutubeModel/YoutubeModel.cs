using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KF.Models
{
    public class YoutubeModel
    {
        public List<YoutubeVideo> Videos { get; set; } 
    }

    public class YoutubeVideo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string PreviewPicturePath { get; set; }
    }
}