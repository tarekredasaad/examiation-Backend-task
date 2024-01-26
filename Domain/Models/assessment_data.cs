using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class assessment_data:BaseModel
    {
        //public long id { get; set; }
        [ForeignKey("assessment")]

        public long assessment_id { get; set; }
        public string? data { get; set; }

        public virtual Assessments assessment { get; set; }

    }
}
