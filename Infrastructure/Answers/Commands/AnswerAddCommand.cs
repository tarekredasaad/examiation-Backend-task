using Domain.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Answers.Commands
{
    public class AnswerAddCommand : IRequest<Assessment_AnswersDTO>
    {
        public long assessment_id { get; set; }
        public long question_id { get; set; }
        public string? answer { get; set; }
        public long user_id { get; set; }
    }
}
