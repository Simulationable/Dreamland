using Dreamland.Domain.Enums;
using Dreamland.Domain.Models.Common;
using Dreamland.Domain.Models.Gallery;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Domain.Models.Post
{
    public class PostItem : BaseModel
    {
        public int? Pin { get; set; }
        public PostCategories PostCategories { get; set; }
        public PostSubCategories PostSubCategories { get; set; }
        public string? TitleImage { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public int? PostId { get; set; }
        public bool? ShowGallery { get; set; }
        public Guid? GalleryId { get; set; }
        public string? VideoLink { get; set; }
        public List<PostItem>? RelatePosts { get; set; }
        public List<GalleryItem>? GalleryItems { get; set; }

        public string FormatPostCategories()
        {
            string categories = string.Empty;
            switch (this.PostCategories)
            {
                case PostCategories.DLFamily:
                    categories = "DLFamily";
                    break;
                case PostCategories.Dreamland:
                    categories = "Dreamland";
                    break;
                case PostCategories.RatiromFifth:
                    categories = "Ratirom Fifth";
                    break;
                case PostCategories.DreamDeluxe:
                    categories = "Dream Deluxe";
                    break;
                case PostCategories.RatiromDeluxe:
                    categories = "Ratirom Deluxe";
                    break;
                case PostCategories.DreamPriva:
                    categories = "Dream Priva";
                    break;
            }
            return categories;
        }
        public string FormatPostSubCategories()
        {
            string categories = string.Empty;
            switch (this.PostSubCategories)
            {
                case PostSubCategories.Testimonails:
                    categories = "Testimonails";
                    break;
                case PostSubCategories.Activity:
                    categories = "Activity";
                    break;
                case PostSubCategories.Hightlight:
                    categories = "Hightight";
                    break;
            }
            return categories;
        }
    }
}
