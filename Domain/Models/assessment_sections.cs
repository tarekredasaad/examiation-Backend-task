using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class assessment_sections : BaseModel
    {
        //public long id { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        [ForeignKey("assessment")]
        public long assessment_id { get; set; }
        public int ?order { get; set; }

        public virtual Assessments assessment { get; set; }

    }
}
