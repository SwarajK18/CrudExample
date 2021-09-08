using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMVCEx.Data.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int RollNo { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
