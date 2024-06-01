

namespace ShallowDeepCopyApp.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public Address? StuAddress { get; set; }

        public override string? ToString()
        {
            return $"{Id},{Firstname},{Lastname},{StuAddress} ";
        }
        public Student GetCopyByReference()
        {
            return this;
        }

        public Student GetShallowCopy()
        {
            return (Student) MemberwiseClone() ;
        }
        public Student GetDeepCopy()
        {
            Student? student = MemberwiseClone() as Student;
            student!.StuAddress = new Address()
            {
                Street = StuAddress?.Street,
                Number = StuAddress?.Number,
                Zip = StuAddress?.Zip,
            };
            return student;
            
        }

        //Copy Constructor 
        public Student (Student student)
        {
            Id = student.Id ;
            Firstname = student.Firstname ;
            Lastname = student.Lastname ;
            StuAddress = new Address
            {
                Street = student?.StuAddress?.Street,
                Number = student?.StuAddress?.Number,
                Zip = student?.StuAddress?.Zip,
            };
        }


    }
}
