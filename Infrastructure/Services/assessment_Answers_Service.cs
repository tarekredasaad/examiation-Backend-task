using AutoMapper;
using Domain.DTO;
using Domain.Interfaces.UnitOfWork;
using Domain.Models;
using Infrastructure.Answers.AnswerMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class assessment_Answers_Service
    {
        private readonly IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public assessment_Answers_Service(IUnitOfWork unitOfWork,IMapper mapper) 
        { 
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        //Assessment_AnswersDTO answersDTO
        public async Task<ResultDTO> AddAnswer(Assessment_AnswersDTO assessment)
        {
            if(assessment != null)
            {
                assessment_answers answers = new assessment_answers();
                assessment_questions question = _unitOfWork.assessment_QuestionsRepo.Get(x => x.id == assessment.question_id);
                bool logic;
                answers = _mapper.Map<assessment_answers>(assessment);
                if (question != null)
                {
                    switch (question.type)
                    {
                        case "fill":
                        case "short":
                        case "long":
                            assessment_text text = _unitOfWork.assessment_textRepo.Get(x => x.question_id == question.id);
                            answers.score = (text != null && text.answer == assessment.answer ) ? 1 : 0;
                            break;

                        case "match":
                            assessment_match match = _unitOfWork.assessment_matchRepo.Get(x => x.question_id == question.id && x.answer == "1");
                            answers.score = (match != null && match.option == assessment.answer ) ? 1 : 0;
                            break;

                        case "true_false":
                            assessment_true_false assessment_True_False = _unitOfWork.assessment_true_falseRepo.Get(x => x.question_id == question.id);
                            _unitOfWork.commit();
                            answers.score = (assessment_True_False != null && assessment_True_False.is_true == bool.TryParse(assessment.answer, out logic)) ? 1 : 0;
                            break;

                        default:
                            assessment_options options = _unitOfWork.assessment_optionsRepo.Get(x => x.question_id == question.id && x.correct == 1);
                            _unitOfWork.commit();
                            answers.score = (options != null && options.option == assessment.answer ) ? 1 : 0;
                            break;
                    }
                }
                // _mapper.ConfigurationProvider//_mapper.Map<Assessment_AnswersDTO>(assessment) ; //AnswerMapper.Mapper.Map<Assessment_AnswersDTO>(assessment);  
                
                
                var Answer = _unitOfWork.assessment_AnswersRepo.Create(answers);
                _unitOfWork.commit();

                return new ResultDTO() { StatusCode = 200, Data = Answer, Message = "You added the answer successfully" };


            }
            else
            {
                return new ResultDTO() { StatusCode = 400, Data = "Invalid operation" };

            }
        }
        public async Task<ResultDTO> GetAnswers(int id)
        {
            string user = "user";
            string assessment = "assessment";
            string assessment_questions = "assessment_questions";
            assessment_answers assessment_Answers =
                
                _unitOfWork.assessment_AnswersRepo.GetByID(id, user, assessment, assessment_questions);
            if(assessment_Answers == null )
            {
                return new ResultDTO() { StatusCode = 400, Data = "Invalid operation" };

            }
            else
            {
                return new ResultDTO() { StatusCode = 200, Data = assessment_Answers ,
                Message = "you get object successfuly"};

            }

        }


    }
}
