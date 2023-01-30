using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class WeeklyCourseSchedule:BaseEntity
    {
        public WeeklyCourseSchedule()
        {

        }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set;}

        //Relational Properties


    }
}
