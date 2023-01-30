using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class ParentAndStudent:BaseEntity
    {
        public int StudentID { get; set; }
        public int ParentID { get; set; }

    }
}
