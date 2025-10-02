using System.ComponentModel.DataAnnotations;

namespace StudentMgm.Models;

public class Student
{
    [Key]
    public int StudentID { get; set; }
    public string StudentName { get; set; } = "";
    public int StudentAge { get; set; }
}