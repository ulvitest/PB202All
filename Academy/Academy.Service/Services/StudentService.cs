

using Academy.Core.Entities;
using Academy.Data;
using Academy.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Academy.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly AcademyDbContext _context;
        public StudentService()
        {
            _context = new AcademyDbContext();
        }
        public Student GetStudentById(int? id)
        {
            if (id is null)
                throw new Exception("id is null");

            var existStudent = _context.Students
                .Include(s => s.Group)
                .SingleOrDefault(s => s.Id == id);

            if (existStudent is null)
                throw new Exception("student not found");
            return existStudent;

        }
        public async Task<Student> GetStudentByIdAsync(int? id)
        {
            if (id is null)
                throw new Exception("id is null");

            var existStudent =await _context.Students
                .Include(s => s.Group)
                .SingleOrDefaultAsync(s => s.Id == id);

            if (existStudent is null)
                throw new Exception("student not found");
            return existStudent;

        }
        public void DeleteStudentById(int? id)
        {
            var existStudent = GetStudentById(id);
            _context.Students.Remove(existStudent);
            _context.SaveChanges();

        }
        public async Task DeleteStudentByIdAsync(int? id)
        {
            var existStudent = await GetStudentByIdAsync(id);
            _context.Students.Remove(existStudent);
           await _context.SaveChangesAsync();

        }
        public List<Student> GetStudents() => _context.Students.Include(s => s.Group).ToList();
        public async Task<List<Student>> GetStudentsAsync() =>await _context.Students.Include(s => s.Group).ToListAsync();
        public List<Student> GetStudents(string value)
            =>
            _context.Students
            .Include(s => s.Group)
            .Where(s => s.Name.Contains(value))
            .ToList();
        public async Task<List<Student>> GetStudentsAsync(string value)
          =>
         await _context.Students
          .Include(s => s.Group)
          .Where(s => s.Name.Contains(value))
          .ToListAsync();
        public List<Student> GetStudentsByGroupId(int groupId)
           =>
           _context.Students
           .Include(s => s.Group)
           .Where(s => s.GroupId==groupId)
           .ToList();
        public async Task<List<Student>> GetStudentsByGroupIdAsync(int groupId)
         =>
         await _context.Students
         .Include(s => s.Group)
         .Where(s => s.GroupId == groupId)
         .ToListAsync();
        public void CreateStudent(Student student, int groupId)
        {
            var existGroup = _context.Groups
                .Include(g => g.Students)
                .SingleOrDefault(g => g.Id == groupId);
            if (existGroup is null)
                throw new Exception("group not found");
            if (existGroup.Students.Count >= existGroup.Limit)
                throw new Exception("group is full");
            student.GroupId= groupId;
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public async Task CreateStudentAsync(Student student, int groupId)
        {
            var existGroup =await _context.Groups
                .Include(g => g.Students)
                .SingleOrDefaultAsync(g => g.Id == groupId);
            if (existGroup is null)
                throw new Exception("group not found");
            if (existGroup.Students.Count >= existGroup.Limit)
                throw new Exception("group is full");
            student.GroupId = groupId;
           await _context.Students.AddAsync(student);
          await  _context.SaveChangesAsync();
        }
        public void UpdateStudent(int id, Student student, int groupId)
        {
            var existStudent = GetStudentById(id);

            var existGroup = _context.Groups
                     .Include(g => g.Students)
                     .SingleOrDefault(g => g.Id == groupId);

            if (existGroup is null)
                throw new Exception("group not found");

            if (existStudent.GroupId != groupId)
            {
                if (existGroup.Students.Count >= existGroup.Limit)
                    throw new Exception("group is full");
            }
            existStudent.Name = student.Name;
            existStudent.Age = student.Age;
            existStudent.GroupId = groupId;
            _context.SaveChanges();


        }
        public async Task UpdateStudentAsync(int id, Student student, int groupId)
        {
            var existStudent =await GetStudentByIdAsync(id);

            var existGroup = await _context.Groups
                     .Include(g => g.Students)
                     .SingleOrDefaultAsync(g => g.Id == groupId);

            if (existGroup is null)
                throw new Exception("group not found");

            if (existStudent.GroupId != groupId)
            {
                if (existGroup.Students.Count >= existGroup.Limit)
                    throw new Exception("group is full");
            }
            existStudent.Name = student.Name;
            existStudent.Age = student.Age;
            existStudent.GroupId = groupId;
           await _context.SaveChangesAsync();


        }
        public bool IsExist(string name) => _context.Students.Any(s => s.Name == name);
        public async Task<bool> IsExistAsync(string name) => await _context.Students.AnyAsync(s => s.Name == name);

    }
}
