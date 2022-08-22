using Dreamland.Domain.Models.Gallery;
using Dreamland.Domain.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Domain.ViewModels.Posts
{
    public class PostItemViewModel : BaseViewModel
    {
        public string? Category { get; set; }
        public string? Date { get; set; }
        public string? TitleImage { get; set; }
        public string? Content { get; set; }
        public bool? ShowGallery { get; set; }
        public string? VideoLink { get; set; }
        public List<PostItemListViewModel>? RelatePosts { get; set; }
        public List<GalleryItem>? GalleryItems { get; set; }
    }
}
