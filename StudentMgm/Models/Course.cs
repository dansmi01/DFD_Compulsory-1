namespace StudentMgm.Models;
public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public string? Grade { get; set; }             // traditionel 7 step grade
    public DateTime? CourseStart { get; set; }       // default date

}