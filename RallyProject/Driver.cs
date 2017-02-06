using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RallyProject
{
    public class Driver
    {
        // Instance variables
        private int idDriver;
        private string name;
        private string nationality;

        // constructor
        public Driver(int idDriver, string name, string nationality)
        {
            this.idDriver = idDriver;
            this.name = name;
            this.nationality = nationality;
        }

        public int IdDriver
        {
            get
            {
                return idDriver;
            }

            set
            {
                idDriver = value;
            }
        }

        public string Name
        {
            get
            {
                return "Given name : " + name;
            }

            set
            {
                name = value;
            }
        }

        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }

        public override string ToString()
        {
            return "The driver with " + name +" has id " + idDriver + " and is from " + nationality;
        }
    }
}