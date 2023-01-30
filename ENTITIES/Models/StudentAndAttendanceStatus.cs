using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class StudentAndAttendanceStatus:BaseEntity
    {
        public StudentAndAttendanceStatus()
        {

        }
        public int StudentID { get; set; }
        public int AttendanceStatusID { get; set; }

        //Relational Properties

    }
}
