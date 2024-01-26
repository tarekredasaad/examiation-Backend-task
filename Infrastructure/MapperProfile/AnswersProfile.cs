using AutoMapper;
using Domain.DTO;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MapperProfile
{
    public class AnswersProfile:Profile
    {
        public AnswersProfile() 
        {
            CreateMap<assessment_answers , Assessment_AnswersDTO>();
            CreateMap<Assessment_AnswersDTO, assessment_answers>();
            //CreateMap<assessment_answers, Assessment_AnswersDTO>();
        }

    }
}
