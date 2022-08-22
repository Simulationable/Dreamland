using Dreamland.Domain.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Domain.ViewModels.Gallery
{
    public class GalleryItemViewModel : BaseViewModel
    {
        public string? Image { get; set; }
        public string? Thumbnail { get; set; }
    }
}
