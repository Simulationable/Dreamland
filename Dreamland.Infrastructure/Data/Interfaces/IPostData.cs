using Dreamland.Domain.Enums;
using Dreamland.Domain.Models.MasterData;
using Dreamland.Domain.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Infrastructure.Data.Interfaces
{
    public interface IPostData
    {
        public Task<List<PostItem>> GetPostItemsAsync(PostSubCategories postSubCategories);
    }
}
