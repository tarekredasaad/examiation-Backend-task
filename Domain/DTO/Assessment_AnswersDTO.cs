using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class Assessment_AnswersDTO
    {

        public long assessment_id { get; set; }
        public long question_id { get; set; }
        public string? answer { get; set; }
        public long user_id { get; set; }
        //public int? score { get; set; }

        
    }
}
