using System.Security.Permissions;
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

}