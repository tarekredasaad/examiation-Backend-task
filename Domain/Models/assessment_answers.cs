using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class assessment_answers:BaseModel
    {
        [ForeignKey("assessment")]

        public long assessment_id { get; set; }
        [ForeignKey("assessment_questions")]
        public long question_id { get; set; }
        public string? answer { get; set; }
        [ForeignKey("user")]

        public long user_id { get; set; }
        public int? score { get; set; }

        public virtual assessment_questions assessment_questions { get; set; }
        public virtual Assessments assessment { get; set; }
        public virtual User user { get; set; }
    }
}
