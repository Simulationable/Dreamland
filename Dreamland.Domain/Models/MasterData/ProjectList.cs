using Dreamland.Domain.Enums;
using Dreamland.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Domain.Models.MasterData
{
    public class ProjectList : BaseModel
    {
        public ProjectTypes ProjectType { get; set; }
        public string? Image { get; set; }
        public string? Caption { get; set; }
        public string? Price { get; set; }
        public bool IsSoldOut { get; set; }
    }
}
