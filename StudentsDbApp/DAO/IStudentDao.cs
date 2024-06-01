using StudentsDbApp.Models;

namespace StudentsDbApp.DAO
{
    public interface IStudentDao
    {
        Student? Insert(Student student);
        Student? Update(Student? student);
        void Delete(int id);
        Student? GetById(int id);
        IList<Student> GetAll();    

    }
}
