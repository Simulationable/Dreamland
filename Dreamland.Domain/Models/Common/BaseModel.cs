using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Domain.Models.Common
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? DeleteAt { get; set; }
        public string? DeleteBy { get; set; }
        public bool? IsShow { get; set; }
        public bool? IsActive { get; set; }

        public string GetFullDate()
        {
            return CreatedAt.Value.ToString("d MMMM, yyyy");
        }
    }
}
