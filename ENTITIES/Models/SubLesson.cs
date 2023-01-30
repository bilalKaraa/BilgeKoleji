using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class SubLesson:BaseEntity
    {
        public string SubLessonName { get; set; }

        //Relational Properties
        public virtual Lesson Lesson { get; set; }
    }
}
