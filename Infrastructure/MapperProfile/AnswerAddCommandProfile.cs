using AutoMapper;
using Domain.DTO;
using Domain.Models;
using Infrastructure.Answers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MapperProfile
{
    public class AnswerAddCommandProfile:Profile
    {
        public AnswerAddCommandProfile()
        {
            CreateMap<AnswerAddCommand, Assessment_AnswersDTO>();
            CreateMap<Assessment_AnswersDTO, AnswerAddCommand>();
            
        }


    }
}
