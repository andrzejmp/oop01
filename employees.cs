using System;
using System.Collections.Generic;

namespace OOP_in_Csharp{
    
    public class Employee{
        
        //attributes
        private string name;
        private string position;
        private double salary;
        
        //constructor
        public Employee(string nm, string ps, double sal){
            
            this.Name = nm;
            this.Position = ps;
            this.Salary = sal;
            
        }
        //get and set
        public string Name{
            
            get { return this.name; }
            set { this.name = value; }
        }
        
 
        public string Position{
            
            get { return this.position; }
            set { this.position = value; }
        }
        
        public double Salary{
            
            get { return this.salary; }
            set { this.salary = value; }
        }
        
        //with a position and salary the fuctions return the name of position
        // public string getWork(string position, double salary){
        //     if(position == Position && salary == Salary)
        //        return Name;

        // }    
        //public fireOut(){}
           
        public void promote(double rise){
            Salary=Salary*(1+rise/100);
        }     

    } // Employee

    public class Boss : Employee 
    {
        
        public Boss(string nm, string ps, double sal, string field ) : base(nm,  ps, sal)
        {
            this.Field = field;
        }
        protected string field;
        public string Field
		{
			get { return field;  }
			set { field = value; }
		}
        
    }

    class Program {
    static void Main() {

    Employee p1 = new Employee("Bob", "technician", 1200);
    Console.WriteLine("{0} - {1}", p1.Name, p1.Salary);
    p1.promote(10);
    Console.WriteLine("{0} - {1}", p1.Name, p1.Salary);
    
    Boss b1 = new Boss("Adam", "IT Manager",4000, "IT");
    Console.WriteLine("{0} - {1}", b1.Name, b1.Salary);

  }
 }

}
