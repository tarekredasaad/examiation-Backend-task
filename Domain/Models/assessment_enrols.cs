using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class assessment_enrols:BaseModel
    {
        //public long id { get; set; }
        [ForeignKey("assessment")]
        public long assessment_id { get; set; }
        [ForeignKey("user")]
        public long user_id { get; set; }
        public int? result { get; set; }
        public int? score { get; set; }

        public virtual Assessments assessment { get; set; }
        public virtual User user { get; set; }

    }
}
