using Domain.DTO;
using Domain.Interfaces.Services;
using Domain.Models;
using Infrastructure.Answers.Commands;
using Infrastructure.Answers.Query;
using Infrastructure.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DynamicAuthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly assessment_Answers_Service assessment_Answers_Service;
        private readonly IMediator _mediator;

        public AnswerController(assessment_Answers_Service assessment_Answers_Service
            ,IMediator mediator)
        {
            this.assessment_Answers_Service = assessment_Answers_Service;
            _mediator = mediator;
        }

        [HttpPost]
        public ActionResult<ResultDTO> Create(Assessment_AnswersDTO  answersDTO)
        {
            if (!ModelState.IsValid) { return BadRequest(new ResultDTO() { StatusCode = 400, Data = ModelState }); };
            return Ok(assessment_Answers_Service.AddAnswer(answersDTO));
        }

        [HttpGet]
        public ActionResult<ResultDTO> Get(int id)
        {
            if (!ModelState.IsValid) { return BadRequest(new ResultDTO() { StatusCode = 400, Data = ModelState }); };
            return Ok(assessment_Answers_Service.GetAnswers(id));
        }
        //public ActionResult<ResultDTO> GetAnswer()
        [HttpGet("GetAnswer")]
        public async Task<IActionResult> GetAnswer(int id)
        {
            var result = await _mediator.Send(new AnswerByIdQuery
            {
                Id = id
            });

            return Ok(result);
        }

        [HttpPost("AddAnswer")]
        public async Task<ActionResult<ResultDTO>> AddAnswerAsync(AnswerAddCommand answersDTO)
        {
            if (!ModelState.IsValid) { return BadRequest(new ResultDTO() { StatusCode = 400, Data = ModelState }); };

            var result = await _mediator.Send(answersDTO);
            

            return Ok(result);
        }
    }
}
