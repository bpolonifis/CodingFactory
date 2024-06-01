using System;


namespace ClassesApp.Model
{
    /*internal sealed class Teacher //sealed den mporei na ginei subclass san final ths java
       // immutable me init i private setters
    {
        //Auto impelmented properties, syntomeusi to prop tab tab!
        public int Id { get; init; }
        public string? Firstname { get; init; }
        public string? Lastname { get; init; }

    }*/
    internal  class Teacher
    { 
            
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Teacher teacher && //is einai san to equals ths java
                   Id == teacher.Id &&
                   Firstname == teacher.Firstname &&
                   Lastname == teacher.Lastname;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Firstname, Lastname);
        }

        public override string ToString() => $"{Id} {Firstname} {Lastname}";
        


    }
}
