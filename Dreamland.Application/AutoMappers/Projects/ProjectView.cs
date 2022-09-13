using AutoMapper;
using Dreamland.Application.Helper.Cryptography;
using Dreamland.Domain.Models.MasterData;
using Dreamland.Domain.ViewModels.MasterData;
using Dreamland.Domain.ViewModels.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.AutoMappers.MasterData
{
    public class ProjectView : Profile
    {
        public ProjectView ()
        {
            CreateMap<ProjectList, ProjectItemListViewModel>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => AES.Encrypt(src.Id.ToString())))
                .ForMember(dest => dest.Price, options => options.MapFrom(src => src.IsSoldOut ? "Sold Out" : "ราคาเริ่มต้น " + src.Price + " ล้านบาท"));
        }
    }
}
