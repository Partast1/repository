using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestList
{
    class Guest
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;

            }
        }

        public Guest(string nameCon, int ageCon)
        {
            this.name = nameCon;
            this.age = ageCon;


        }



    }
}
