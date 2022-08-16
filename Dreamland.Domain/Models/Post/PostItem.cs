using Dreamland.Domain.Enums;
using Dreamland.Domain.Models.Common;
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
        public PostCategories PostCategories { get; set; }
        public PostSubCategories PostSubCategories { get; set; }
        public string? TitleImage { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public int? PostId { get; set; }
        public bool? HaveGallery { get; set; }
        public List<PostItem> RelatePosts { get; set; }

        public string FormatPostCategories()
        {
            string categories = string.Empty;
            switch (this.PostCategories)
            {
                case PostCategories.DLFamily:
                    categories = "DLFamily";
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
            }
            return categories;
        }
    }
}
