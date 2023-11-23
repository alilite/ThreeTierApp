using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTierApp
{
    public class BusinessLayer
    {
        private readonly SqlConnection connection;

        public BusinessLayer(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlDataAdapter GetStudentsSDA()
        {
            return new SqlDataAdapter("SELECT * FROM Students", connection);
        }

        public DataTable GetStudents()
        {
            SqlDataAdapter adapter = GetStudentsSDA();
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public SqlDataAdapter GetEnrollmentsSDA()
        {
            return new SqlDataAdapter(
                "SELECT E.StId, StName, E.CId, CName, FinalGrade, S.ProgId, ProgName " +
                "FROM Enrollments E " +
                "JOIN Students S ON E.StId = S.StId " +
                "JOIN Courses C ON E.CId = C.CId " +
                "JOIN Programs P ON S.ProgId = P.ProgId", connection);
        }

        public DataTable GetEnrollments()
        {
            SqlDataAdapter adapter = GetEnrollmentsSDA();
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public SqlDataAdapter GetCoursesSDA()
        {
            return new SqlDataAdapter("SELECT * FROM Courses", connection);
        }

        public DataTable GetCourses()
        {
            SqlDataAdapter adapter = GetCoursesSDA();
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public SqlDataAdapter GetProgramsSDA()
        {
            return new SqlDataAdapter("SELECT * FROM Programs", connection);
        }

        public DataTable GetPrograms()
        {
            SqlDataAdapter adapter = GetProgramsSDA();
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        // Placeholder methods for adding, modifying, and deleting data

        public void AddStudent(string stId, string stName, string progId)
        {
            // Implement the logic to add a new student to the Students table
            // Use parameters to avoid SQL injection
            // Example: INSERT INTO Students (StId, StName, ProgId) VALUES (@StId, @StName, @ProgId)
        }

        public void UpdateStudent(string stId, string newStName, string newProgId)
        {
            // Implement the logic to update an existing student in the Students table
            // Use parameters to avoid SQL injection
            // Example: UPDATE Students SET StName = @NewStName, ProgId = @NewProgId WHERE StId = @StId
        }

        public void DeleteStudent(string stId)
        {
            // Implement the logic to delete a student from the Students table
            // Use parameters to avoid SQL injection
            // Example: DELETE FROM Students WHERE StId = @StId
        }

        public void AddCourse(string cId, string cName, string progId)
        {
            // Implement the logic to add a new course to the Courses table
            // Use parameters to avoid SQL injection
            // Example: INSERT INTO Courses (CId, CName, ProgId) VALUES (@CId, @CName, @ProgId)
        }

        public void UpdateCourse(string cId, string newCName, string newProgId)
        {
            // Implement the logic to update an existing course in the Courses table
            // Use parameters to avoid SQL injection
            // Example: UPDATE Courses SET CName = @NewCName, ProgId = @NewProgId WHERE CId = @CId
        }

        public void DeleteCourse(string cId)
        {
            // Implement the logic to delete a course from the Courses table
            // Use parameters to avoid SQL injection
            // Example: DELETE FROM Courses WHERE CId = @CId
        }

        public void AddProgram(string progId, string progName)
        {
            // Implement the logic to add a new program to the Programs table
            // Use parameters to avoid SQL injection
            // Example: INSERT INTO Programs (ProgId, ProgName) VALUES (@ProgId, @ProgName)
        }

        public void UpdateProgram(string progId, string newProgName)
        {
            // Implement the logic to update an existing program in the Programs table
            // Use parameters to avoid SQL injection
            // Example: UPDATE Programs SET ProgName = @NewProgName WHERE ProgId = @ProgId
        }

        public void DeleteProgram(string progId)
        {
            // Implement the logic to delete a program from the Programs table
            // Use parameters to avoid SQL injection
            // Example: DELETE FROM Programs WHERE ProgId = @ProgId
        }

        // Add more methods as needed for your specific business logic

        public void CloseConnection()
        {
            connection.Close();
        }
    }

}

