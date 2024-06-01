using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp.Model
{
    /// <summary>
    /// POCO class (Plain Old CLR Object)
    /// </summary>
    internal class Student // default access modifier internal diaforetika public
    {
        private int id; //default access modifier private
        private string? firstname; 
        private string? lastname;

       // public Student() { } // default constructor




        // ctr + .
        /* public Student(int id, string? firstname, string? lastname)
         {
             this.id = id;
             this.firstname = firstname;
             this.lastname = lastname;
         }*/


        /*public Student(int id, string? firstname, string? lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }*/



        //pulbic Properties exoun kefalaio prwto gramma apo thn klasi
        //public int Id { get { return id; } init { id = value; } }         
        //public int Id { get { return id; } private set { id = value; } } // ena apo ta dyo mporei na einai private
        // public int Id { get { return id; }  set { id = value; } }
        public int Id { get =>id; set => id = value; } //omoio me panw
        public string? Firstname { get {  return firstname; } set {  firstname = value; } }
        public string? Lastname { get { return lastname; } set {  lastname = value; } }


    }
}
