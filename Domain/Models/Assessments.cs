using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Assessments:BaseModel
    {
        //public long id { get; set; }
        public string? title { get; set; }
        public string? short_description { get; set; }
        public string? description { get; set; }
        public string? slug { get; set; }
        public string? created_by { get; set; }
        public string? updated_by { get; set; }
        public DateTime? duration { get; set; }
        public long? category_id { get; set; }
        public string? thumbnail { get; set; }
        public int? published { get; set; }

        public virtual List<assessment_answers> assessment_answers { get; set; }
        public virtual List<assessment_sections> assessment_sections { get; set; }
        public virtual List<assessment_data> assessment_data { get; set; }
        public virtual List<assessment_department> assessment_department { get; set; }
        public virtual List<assessment_enrols> assessment_enrols { get; set; }
        public virtual List<assessment_meta> assessment_meta { get; set; }
        public virtual List<assessment_questions_relation> assessment_questions_relation { get; set; }


    }
}
