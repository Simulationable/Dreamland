using Dreamland.Domain.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Domain.ViewModels.Posts
{
    public class PostItemListViewModel : BaseViewModel
    {
        public int? Pin { get; set; }
        public string? PostCategories { get; set; }
        public string? PostSubCategories { get; set; }
        public string? TitleImage { get; set; }
        public string? Description { get; set; }
    }
}
