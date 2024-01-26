using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class assessment_true_false : BaseModel
    {
        //public long id { get; set; }
        [ForeignKey("assessment_questions")]
        public long question_id { get; set; }
        public bool is_true { get; set; }

        public virtual assessment_questions assessment_questions { get; set; }

    }
}
