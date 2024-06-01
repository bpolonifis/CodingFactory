namespace StudentsDbApp.Models
{

  //POCO plain old CLR Objects
    public class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
    }
}
