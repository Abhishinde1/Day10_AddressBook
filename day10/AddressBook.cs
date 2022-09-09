using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class ContactList
    {
        private LinkedList<ContactList> contactDetails = new LinkedList<ContactList>();


        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }


    }
}

