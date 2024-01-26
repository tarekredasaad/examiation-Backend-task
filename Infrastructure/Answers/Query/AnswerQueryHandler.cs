using Domain.Models;
using Infrastructure.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Answers.Query
{
    public class AnswerQueryHandler : IRequestHandler<AnswerByIdQuery, assessment_answers>
    {
       private readonly assessment_Answers_Service assessment_Answers_Service;
        public AnswerQueryHandler(assessment_Answers_Service assessment_Answers_Service)
        {
            this.assessment_Answers_Service = assessment_Answers_Service;
        }

        public async Task< assessment_answers> Handle(AnswerByIdQuery request, CancellationToken cancellationToken)
        {
            var answer = await assessment_Answers_Service.GetAnswers(request.Id);
            return answer.Data;
        }
    }
}
