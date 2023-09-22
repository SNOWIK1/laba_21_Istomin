using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_21
{
    public class Group
    {

        private int id;
        private string name;
        private string headmanSurname;
        private int quantity;
        private int facultyId;

        public Group(int id, string name, string headmanSurname, int quantity, int facultyId)
        {
            this.id = id;
            this.name = name;
            this.headmanSurname = headmanSurname;
            this.quantity = quantity;
            this.facultyId = facultyId;
        }

        public int ID { get { return id; } }
        public string Name { get { return name; } }
        public string Headman { get { return headmanSurname; } }
        public int Quantity { get { return quantity; } }
        public int FacultyID { get { return facultyId; } }
    }
}
