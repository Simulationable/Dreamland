using Dreamland.Domain.Models.Gallery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Infrastructure.Data.Interfaces
{
    public interface IGalleryData
    {
        public List<GalleryItem> GetGalleryItem(Guid? id);
    }
}
