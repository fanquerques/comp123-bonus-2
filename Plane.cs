using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace comp123_bonus2_fan_yang
{
    // Fan Yang (301295721)
    internal class Plane
    {
        public string Manufactory 
        {
            get;
            set;
        }
        public string Model 
        {
            get;
            set;
        }
        public int Capacity
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public string SerialNumber
        {
            get;
            set;
        }

        public Plane(){
            this.Manufactory = "unknown";
            this.Model = "unknown";
            this.Capacity = 0;
            this.Type = "unassigned";
            this.SerialNumber = "00000";   
        }

        public Plane(string manufactory, string model, int capacity, string type, string serialNumber)
        {
            Manufactory = manufactory;
            Model = model;
            Capacity = capacity;
            Type = type;
            SerialNumber = serialNumber;
        }

        public bool HasCapacity(int numOfPeople){

            return numOfPeople <= Capacity;
        }

        public override string ToString()
        {
            return $"Manufactory: {Manufactory}, Model: {Model}," +
                $" Capacity: {Capacity}, Type: {Type}, Serial Number: {SerialNumber}";
        }
    }
}
