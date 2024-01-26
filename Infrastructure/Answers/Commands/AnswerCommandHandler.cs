using AutoMapper;
using Domain.DTO;
using Domain.Models;
using Infrastructure.Answers.Query;
using Infrastructure.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Answers.Commands
{
    public class AnswerCommandHandler : IRequestHandler<AnswerAddCommand, Assessment_AnswersDTO>
    {
        private readonly assessment_Answers_Service assessment_Answers_Service;
        private readonly IMapper mapper;
        public AnswerCommandHandler(assessment_Answers_Service assessment_Answers_Service
            ,IMapper mapper)
        {
            this.mapper = mapper;
            this.assessment_Answers_Service = assessment_Answers_Service;
        }

        public async Task<Assessment_AnswersDTO> Handle(AnswerAddCommand request, CancellationToken cancellationToken)
        {
            Assessment_AnswersDTO answersDTO = new Assessment_AnswersDTO();
             answersDTO = mapper.Map<Assessment_AnswersDTO>(request);
            var answer = await assessment_Answers_Service.AddAnswer(answersDTO);
            return answer.Data;
        }
    }
}
