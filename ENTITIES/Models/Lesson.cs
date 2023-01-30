using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Lesson:BaseEntity
    {
        public Lesson()
        {
        }
        public string LessonName { get; set; }

        //Relational Properties
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual  List<SubLesson> SubLessons { get; set; }

    }
}
