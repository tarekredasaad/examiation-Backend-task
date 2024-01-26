using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class assessment_questions:BaseModel
    {
        //public long id { get; set; }
        public string question { get; set; }
        public long ?category_id { get; set; }
        public int? level { get; set; }
        public int? order { get; set; }
        public string type { get; set; }

        public virtual List<assessment_answers> assessment_answers { get; set; }
        public virtual List<assessment_match> assessment_match { get; set; }
        public virtual List<assessment_options> assessment_options { get; set; }
        public virtual List<assessment_questions_relation> assessment_questions_relation { get; set; }
        public virtual List<assessment_text> assessment_text { get; set; }
        public virtual List<assessment_true_false> assessment_true_false { get; set; }

    }
}
