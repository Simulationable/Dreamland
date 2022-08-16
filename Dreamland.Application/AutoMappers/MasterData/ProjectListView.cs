using AutoMapper;
using Dreamland.Application.Helper.Cryptography;
using Dreamland.Domain.Models.MasterData;
using Dreamland.Domain.ViewModels.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.AutoMappers.MasterData
{
    public class ProjectListView : Profile
    {
        public ProjectListView ()
        {
            CreateMap<ProjectList, ProjectListViewModel>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => AES.Encrypt(src.Id.ToString())));

            CreateMap<ProjectListViewModel, ProjectList>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => new Guid(AES.DecryptToString(src.Id))));
        }
    }
}
