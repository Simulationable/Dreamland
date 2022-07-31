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
        public ProjectType ProjectType { get; set; }
        public bool? IsShow { get; set; }
        public bool? IsActive { get; set; }

        public string EncodeID()
        {
            var data = System.Text.Encoding.UTF8.GetBytes(this.Id.ToString());
            return System.Convert.ToBase64String(data); ;
        }
    }
}
