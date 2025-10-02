namespace StudentMgm.Models;
// acts as a juntion table
public class Enrollment
{
    //PK
    public long EnrollmentId { get; set; }
    //FK
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    //
   
}