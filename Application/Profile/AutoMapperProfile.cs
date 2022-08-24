using System;
using System.Collections.Generic;
using System.Text;
using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserVM, User>().ReverseMap();
        }
    }
}
