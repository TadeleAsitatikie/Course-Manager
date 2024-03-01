using CourseMgr.Models;
namespace CourseMgr.Services;
public static class CourseService
{
    static List<Course> Courses {get;}
    static CourseService()
    {
        Courses = [
            new() {
                Code = "IFA-101",
                Title = "Introduction to Foreign Affairs Management",
                Credit =3
            },
            new() {
                Code = "IFA-102",
                Title = "Advanced Concepts in Foreign Affairs",
                Credit =3
            }
        ];
    }
    public static List<Course> All() => Courses;
    public static Course? Get(string code) => Courses.FirstOrDefault( c => c.Code == code);

    public static Course? Add(Course course)
    {
        var courseExists = Courses.Exists( coursee => coursee.Code == course.Code);
        
            if(courseExists) return null;
            Courses.Add(course);

            return course;
        
    }

    public static void Update(Course course)
    {
        var index = Courses.FindIndex( coursee => coursee.Code == course.Code);
        if(index == -1) return ;
        Courses[index]= course;
    }

    public static void DeleteTwo (Course course)
    {
        var index = Courses.FindIndex(coursee => coursee.Code == course.Code);
        if(index == -1) return;
        Courses.RemoveAt(index);
    }

    public static void Delete(string code){
        Course? c = Courses.FirstOrDefault(c => c.Code == code);
        if(c is null) return;
        Courses.Remove(c);
    }
}
