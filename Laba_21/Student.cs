using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_21
{
    public class Student
    {
        private int id;
        private string fullName;
        private string address;
        private string phone;
        private int groupID;

        public Student(int id, string fullName, string address, string phone, int groupID)
        {
            this.id = id;
            this.fullName = fullName;
            this.address = address;
            this.phone = phone;
            this.groupID = groupID;
        }

        public int ID { get { return id; } }
        public string Name { get { return fullName; } }
        public string Address { get { return address; } }
        public string Phone { get { return phone; } }
        public int GroupID { get { return groupID; } }

    }
}
