using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Domain.Models;

namespace Infrastructure.Answers.Query
{
    public class AnswerByIdQuery : IRequest<assessment_answers>
    {
        public int Id { get; set; }
    }
}
