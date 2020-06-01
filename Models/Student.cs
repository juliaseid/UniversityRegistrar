using System;
using System.Collections.Generic;

namespace University.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Enrollment { get; set; }
    public ICollection<CourseStudent> Courses { get; }

  }
}