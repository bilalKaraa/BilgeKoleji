using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Parent:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Mail { get; set; }
        public string TelNo { get; set; }
        public string Address { get; set; }

        //Relational Properties
    }
}
