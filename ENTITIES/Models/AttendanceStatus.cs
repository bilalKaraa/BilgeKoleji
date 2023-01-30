using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class AttendanceStatus:BaseEntity
    {
        public AttendanceStatus()
        {

        }
        public string FirstSemester { get; set; }
        public string SecondSemester { get; set; }

        //Relational Properties


        

    }
}
