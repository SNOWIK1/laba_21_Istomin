using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_21
{
    public class Faculty
    {

        private int id;
        private string faculty;
        private int course;
        private int groupsQuantity;

        public Faculty(int id, string faculty, int course, int groupsQuantity)
        {
            this.id = id;
            this.faculty = faculty;
            this.course = course;
            this.groupsQuantity = groupsQuantity;
        }

        public int ID { get { return id; } }
        public string FacultyName { get { return faculty; } }
        public int Course { get { return course; } }
        public int QuantityOfGroups { get { return groupsQuantity; } }


    }
}
