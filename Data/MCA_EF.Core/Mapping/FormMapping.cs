﻿using AutoMapper;
using MCA_EF.Core.Model;
using MCA_EF.Data.Entities;

namespace MCA_EF.Core.Mapping
{
    public class FormMapping : Profile
    {
        public FormMapping()
        {
            CreateMap<Form, FormViewModel>();
        }
    }
}
