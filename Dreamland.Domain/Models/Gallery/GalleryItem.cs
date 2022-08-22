using Dreamland.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Domain.Models.Gallery
{
    public class GalleryItem : BaseModel
    {
        public string? Image { get; set; }
        public string? Thumbnail { get; set; }
    }
}
