using FileDirectorySerialization.Lesson.Models;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Xml.Serialization;

namespace FileDirectorySerialization.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first
            //DirectoryInfo,FileInfo,Filestream,StreamReader
            //StreamWriter,Serialization(json,xml),Reflection

            //string path = "C:\\Users\\USER\\Desktop\\PB202\\FileDirectorySerialization\\FileDirectorySerialization.Lesson\\Data\\file.txt";
            // DirectoryInfo directoryInfo = new DirectoryInfo(path);
            //Console.WriteLine(directoryInfo.Name);
            //Console.WriteLine(directoryInfo.FullName);
            //Console.WriteLine(directoryInfo.LastAccessTime);
            //Console.WriteLine(directoryInfo.Root);
            //Console.WriteLine(directoryInfo.LastWriteTime);
            //var files= directoryInfo.GetFiles();
            //var directories= directoryInfo.GetDirectories();

            //foreach (var file in directories)
            //{
            //    Console.WriteLine(file.Name);
            //}
            //FileInfo file = new FileInfo(path);
            //Console.WriteLine(file.Name);
            //Console.WriteLine(file.FullName);
            //Console.WriteLine(file.LastAccessTime);
            //Console.WriteLine(file.LastWriteTime);
            //string path = "C:\\Users\\USER\\Desktop\\PB202\\FileDirectorySerialization\\FileDirectorySerialization.Lesson\\Data\\";

            //if (!Directory.Exists(path))
            //    Directory.CreateDirectory(path);
            //if (Directory.Exists(path))
            //    Directory.Delete(path,true);
            //DirectoryInfo dir = new DirectoryInfo(path);
            //foreach (var item in dir.GetDirectories())
            //{
            //    Directory.Delete(path + @"\\" + item.Name);
            //}
            // var result= Path.Combine("salam", "sagol", "lorem","file.txt","test");

            //string path = "C:\\Users\\USER\\Desktop\\PB202\\FileDirectorySerialization\\FileDirectorySerialization.Lesson\\Data\\file.txt";
            ////FileStream fileStream = new FileStream(path, FileMode.Append);
            ////StreamWriter streamWriter=new StreamWriter(fileStream);
            ////streamWriter.WriteLine("hello");
            ////streamWriter.Close();
            ////fileStream.Close();
            //using FileStream fileStream = new FileStream(path, FileMode.Open);
            //using StreamReader streamReader = new StreamReader(fileStream);
            //var result = streamReader.ReadToEnd();
            #endregion
            #region second
            //json xml,
            //Student student = new Student();
            //student.Id = 1;
            //student.Name = "Ziya";
            //student.Age = 30;

            //Student student1 = new Student();   
            //student1.Id = 2;
            //student1.Name = "Test";
            //student1.Age = 20;

            //List<Student> students = new List<Student>() { student1, student };
            //SerializeXml(student);
            //Console.WriteLine(DeserializeXml());
            //SerializeJson(student);
            //Console.WriteLine(DeserializeJson());
            //SerializeJsonList(students);
            //foreach (var item in DeserializeJsonList())
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in ReadDataAllFromUrl())
            //{
            //    Console.WriteLine(item);

            //}
            //var result=ReadDataByIdFromUrl(10);
            // Console.WriteLine(result);
            #endregion
            //reflection
            //int num = 20;
            //Student student = new Student();
            ////Console.WriteLine(num.GetType());
            ////Console.WriteLine(student.GetType());
            //Type type = typeof(Student);
            ////Console.WriteLine(type.Name);
            ////Console.WriteLine(type.FullName);
            ////Console.WriteLine(type.IsValueType);
            ////Console.WriteLine(type.IsInterface);
            ////Console.WriteLine(type.IsAbstract);
            ////PropertyInfo[] props=type.GetProperties();
            ////foreach (var prop in props)
            ////{
            ////    Console.WriteLine(prop.Name);
            ////}
            ////FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic|BindingFlags.Instance);
            ////foreach (var field in fields)
            ////{
            ////    Console.WriteLine(field.Name);
            ////}
            ////MethodInfo[]methods=type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            ////foreach (var method in methods)
            ////{
            ////    Console.WriteLine(method.Name);
            ////}
            ////var ctors = type.GetConstructors();
            ////foreach ( var ctor in ctors )
            ////{
            ////    foreach (var item in ctor.GetParameters())
            ////    {
            ////        Console.WriteLine(item.Name);
            ////    }
            ////}
            ////var instance= Activator.CreateInstance(type);
            //// PropertyInfo prop = type.GetProperty("Id");
            //// prop.SetValue(instance, 12, null);
            //// Console.WriteLine(((Student)instance).Id);
            ////Student student2 = new Student();
            ////typeof(Student).GetField("Id", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(student2, 12);
            ////var _id = typeof(Student).GetField("Id", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(student2);
            ////Console.WriteLine(_id);
            ////var instance= Activator.CreateInstance(type);
            ////MethodInfo methodInfo = type.GetMethod("Test");
            ////object[] parametersArray = new object[] { 20 };
            ////methodInfo.Invoke(instance, parametersArray);
            ////Assembly assembly = Assembly.GetExecutingAssembly();
            ////foreach (var item in assembly.GetTypes())
            ////{
               
            ////}

        }
        static void SerializeXml(Student student)
        {
            string path = "C:\\Users\\USER\\Desktop\\PB202\\FileDirectorySerialization\\FileDirectorySerialization.Lesson\\Data\\data.xml";
            FileStream fileStream=new(path,FileMode.Append);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            xmlSerializer.Serialize(fileStream, student);

        }
        static Student DeserializeXml()
        {
            string path = "C:\\Users\\USER\\Desktop\\PB202\\FileDirectorySerialization\\FileDirectorySerialization.Lesson\\Data\\data.xml";
            using FileStream fileStream=new(path,FileMode.Open);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
           return xmlSerializer.Deserialize(fileStream) as Student;

        }

        static void SerializeJson(Student student)
        {
            string path = "C:\\Users\\USER\\Desktop\\PB202\\FileDirectorySerialization\\FileDirectorySerialization.Lesson\\Data\\data.json";
            using FileStream fileStream = new(path, FileMode.Append);
            using StreamWriter writer = new StreamWriter(fileStream);
            string result=JsonSerializer.Serialize(student);
            writer.Write(result);
        }
        static Student DeserializeJson()
        {

            string path = "C:\\Users\\USER\\Desktop\\PB202\\FileDirectorySerialization\\FileDirectorySerialization.Lesson\\Data\\data.json";
            using FileStream fileStream = new(path, FileMode.Open);
            using StreamReader reader = new StreamReader(fileStream);
            var result = reader.ReadToEnd();
            return JsonSerializer.Deserialize<Student>(result);
        }
        static void SerializeJsonList(List<Student> students)
        {
            string path = "C:\\Users\\USER\\Desktop\\PB202\\FileDirectorySerialization\\FileDirectorySerialization.Lesson\\Data\\data.json";
            using FileStream fileStream = new(path, FileMode.Append);
            using StreamWriter writer = new StreamWriter(fileStream);
            string result = JsonSerializer.Serialize(students);
            writer.Write(result);
        }
        static List<Student> DeserializeJsonList()
        {

            string path = "C:\\Users\\USER\\Desktop\\PB202\\FileDirectorySerialization\\FileDirectorySerialization.Lesson\\Data\\data.json";
            using FileStream fileStream = new(path, FileMode.Open);
            using StreamReader reader = new StreamReader(fileStream);
            var result = reader.ReadToEnd();
            return JsonSerializer.Deserialize<List<Student>>(result);
        }

        static List<User> ReadDataAllFromUrl()
        {
            string url = "https://jsonplaceholder.typicode.com/users";
            HttpClient httpClient = new HttpClient();
            var response= httpClient.GetAsync(url).GetAwaiter().GetResult();
            string result= response.Content.ReadAsStringAsync().Result;
           return JsonSerializer.Deserialize<List<User>>(result);
        }
        static User ReadDataByIdFromUrl(int id)
        {
            string url = $"https://jsonplaceholder.typicode.com/users/{id}";
            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync(url).GetAwaiter().GetResult();
            string result = response.Content.ReadAsStringAsync().Result;
            return JsonSerializer.Deserialize<User>(result);
        }

    }
}
