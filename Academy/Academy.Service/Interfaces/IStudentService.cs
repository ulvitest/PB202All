using Academy.Core.Entities;

namespace Academy.Service.Interfaces
{
    public interface IStudentService
    {
        void CreateStudent(Student student, int groupId);
        void DeleteStudentById(int? id);
        Student GetStudentById(int? id);
        List<Student> GetStudents();
        List<Student> GetStudents(string value);
        List<Student> GetStudentsByGroupId(int groupId);
        bool IsExist(string name);
        void UpdateStudent(int id, Student student, int groupId);
    }
}