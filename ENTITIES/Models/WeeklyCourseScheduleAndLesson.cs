using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class WeeklyCourseScheduleAndLesson : BaseEntity
    {
        public int LessonID { get; set; }
        public int WeeklyCourseScheduleID { get; set; }
        public string Period { get; set; }
        public string Year { get; set; }

    }
}
