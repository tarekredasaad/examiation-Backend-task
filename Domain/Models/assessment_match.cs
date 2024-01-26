using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class assessment_match: BaseModel
    {
        //public long id { get; set; }
        public string? answer_id_key { get; set; }
        public string? question_id_key { get; set; }
        public string? option { get; set; }
        public string? answer { get; set; }
        [ForeignKey("assessment_questions")]
        public long question_id { get; set; }
        public int? order { get; set; }

        public virtual assessment_questions assessment_questions { get; set; }

    }
}
