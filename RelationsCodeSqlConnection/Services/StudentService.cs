using RelationsCodeSqlConnection.Models;
using System.Data.SqlClient;


namespace RelationsCodeSqlConnection.Services
{
    internal class StudentService
    {
        public const string ConnectionStr= "Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=PB202;Trusted_Connection=true;";
        public  void Create(Student student)
        {
            using var connection = CreateConnection();
            string query = "INSERT INTO Students VALUES (@name,@age)";
            SqlCommand sqlCommand = new(query, connection);
            sqlCommand.Parameters.AddWithValue("@name", student.Name);
            sqlCommand.Parameters.AddWithValue("@age", student.Age);
            if (sqlCommand.ExecuteNonQuery() > 0)
                Console.WriteLine("added");
            else Console.WriteLine("problem...");


        }
        public void Update(int id,Student student)
        {
            using var connection = CreateConnection();
            string query = "UPDATE Students SET Name=@name,Age=@age WHERE Id=@id";
            SqlCommand sqlCommand = new(query, connection);
            sqlCommand.Parameters.AddWithValue("@name", student.Name);
            sqlCommand.Parameters.AddWithValue("@age", student.Age);
            sqlCommand.Parameters.AddWithValue("@id", id);
            if (sqlCommand.ExecuteNonQuery() > 0)
                Console.WriteLine("updated");
            else Console.WriteLine("problem...");
        }
        public void Delete(int id)
        {
            using var connection = CreateConnection();
            string query = "DELETE FROM Students WHERE Id=@id";
            SqlCommand sqlCommand = new(query, connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            if (sqlCommand.ExecuteNonQuery() > 0)
                Console.WriteLine("deleted");
            else Console.WriteLine("problem...");
        }
        public Student GetById(int id)
        {
            Student student = null;
            using var connection = CreateConnection();
            string query = "SELECT * FROM Students WHERE Id=@id";
            SqlCommand sqlCommand = new(query, connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader reader= sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) //1,"",23
                {
                    student = new Student();
                    student.Id = (int)reader["Id"];
                    student.Name = (string)reader["Name"];
                    student.Age = (int)reader["Age"];
                }
                return student;
            }
            else
                return student;

        }
        public List<Student> GetAll()
        {
            List<Student>students = null;
            using var connection = CreateConnection();
            string query = "SELECT * FROM Students";
            SqlCommand sqlCommand = new(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                students = new List<Student>();
                while (reader.Read()) //1,"",23
                {
                    var student = new Student();
                    student.Id = (int)reader["Id"];
                    student.Name = (string)reader["Name"];
                    student.Age = (int)reader["Age"];
                    students.Add(student);
                }
                return students;
            }
            else
                return students;

        }
        public int GetStudentsAgeAvg()
        {
            using var connection = CreateConnection();
            string query = "SELECT AVG(Age) FROM Students";
            SqlCommand sqlCommand = new(query, connection);

            return (int)sqlCommand.ExecuteScalar();
            
        }
        public int GetStudentsCount()
        {
            using var connection = CreateConnection();
            string query = "SELECT dbo.StudentsCount()";
            SqlCommand sqlCommand = new(query, connection);

            return (int)sqlCommand.ExecuteScalar();

        }
        public void GetStudentsByAge()
        {
            using var connection = CreateConnection();
            string query = "GetStudentsByAge";
            SqlCommand sqlCommand = new(query, connection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@age", 20);
            var result=sqlCommand.ExecuteReader();
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection sqlConnection = new(ConnectionStr);
            sqlConnection.Open();
            return sqlConnection;
        }
       
    }
}
