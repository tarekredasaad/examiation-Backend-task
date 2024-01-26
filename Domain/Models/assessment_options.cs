﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class assessment_options:BaseModel
    {
        //public long id { get; set; }
        public string? option { get; set; }
        [ForeignKey("assessment_questions")]
        public long question_id { get; set; }
        public int correct { get; set; }
        public int ?order { get; set; }

        public virtual assessment_questions assessment_questions { get; set; }

    }
}
