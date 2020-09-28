using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Models;

namespace Blog.DTO
{
    public class AutoMapping : Profile
    {

        public AutoMapping()
        {
            CreateMap<PostMaster, PostMasterDTO>();
        }

    }
}
