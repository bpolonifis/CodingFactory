using AutoMapper;
using StudentsDbApp.DAO;
using StudentsDbApp.DTO;
using StudentsDbApp.Models;
using System.Transactions;

namespace StudentsDbApp.Services
{
    public class StudentServiceImpl : IStudentService
    {
        private readonly IStudentDao _studentDao;
        private readonly IMapper _mapper;
        private readonly ILogger<StudentServiceImpl> _logger;

        public StudentServiceImpl(IStudentDao studentDAO, IMapper mapper, ILogger<StudentServiceImpl> logger)
        {
            _studentDao = studentDAO;
            _mapper = mapper;
            _logger = logger;
        }

       

        public IList<Student> GetAllStudents()
        {
            try
            {
                IList<Student> students = _studentDao.GetAll();
                return students;
            } catch (Exception ex)
            {
                _logger.LogError("An error occured while fetching all students: {ErrorMessage}", ex.Message); // h positional {0} , (miden thesi)
                throw;
            }
        }

        public Student? GetStudent(int id)
        {
            try
            {
                return _studentDao.GetById(id);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occured while fetching a student: {ErrorMessage}", ex.Message); // h positional {0} , (miden thesi)
                throw;
            }
        }

        public Student? InsertStudent(StudentInsertDTO dto)
        {
            if (dto is null) return null; 
            var student = _mapper.Map<Student>(dto);

            try
            {
                using TransactionScope scope = new();
                Student? insertedStudent = _studentDao.Insert(student);
                scope.Complete();
                return insertedStudent;

            } catch (Exception ex)
            {
                _logger.LogError("An error occured while inserting a student: {ErrorMessage}", ex.Message); // h positional {0} , (miden thesi)
                throw;
            }

        }

        public Student? UpdateStudent(StudentUpdateDTO dto)
        {
            if (dto is null) return null;
            Student? student = _mapper.Map<Student>(dto);
            Student? updatedStudent = null;
            try
            {
                using TransactionScope scope = new();
                updatedStudent = _studentDao.GetById(student.Id);
                if (updatedStudent is null) return null;
                updatedStudent = _studentDao.Update(student);
                scope.Complete();
            } catch (Exception ex)
            {
                _logger.LogError("An error occured while updating a student: {ErrorMessage}", ex.Message); // h positional {0} , (miden thesi)
                throw;
            }
            return updatedStudent;
        }

        public Student? DeleteStudent(int id)
        {
            Student? student = null;
            try
            {
                using TransactionScope scope = new();
                student = _studentDao.GetById(id);
                if (student is null) return null;
                _studentDao.Delete(id);
                scope.Complete();
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occured while updating a student: {ErrorMessage}", ex.Message); // h positional {0} , (miden thesi)
                throw;
            }
            return student;
        }
    }
}
