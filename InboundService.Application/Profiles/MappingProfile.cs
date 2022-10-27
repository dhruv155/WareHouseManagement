using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using InboundService.Application.DTOs;
using InboundService.Domain;


namespace InboundService.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderDto>().ReverseMap();
        }
    }
}
