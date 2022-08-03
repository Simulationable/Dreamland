using Dreamland.Domain.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Domain.ViewModels.Projects
{
    public class ProjectItemListViewModel : BaseViewModel
    {
        public string? Image { get; set; }
        public string? Caption { get; set; }
        public string? Price { get; set; }
        public bool? IsSoldOut { get; set; }
    }
}
