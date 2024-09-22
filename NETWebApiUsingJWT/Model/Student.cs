namespace NETWebApiUsingJWT.Model
{
    public class Student
    {
        public int StudentID { get; set; }         // Unique identifier for the student
        public string FirstName { get; set; }       // Student's first name
        public string LastName { get; set; }        // Student's last name
        public int Age { get; set; }                 // Student's age
        public string Class { get; set; }            // Major or course of study
        public string StudentClass { get; set; }     // Specific class or section
        public bool IsEnrolled { get; set; }         // Enrollment status
    }
}
