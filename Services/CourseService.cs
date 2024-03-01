using CourseMgr.Models;

namespace CourseMgr.Services;

public static class CourseService{
    static List<Course> Courses {get;}

    static CourseService(){
        Courses=[
            new(){
                Code="IFA-101",
                Title="Introduction to foreign affairs management",
                Credit=3
            },
            new(){
                Code="IFA-102",
                Title="Advanced concepts in foreign affairs",
                Credit=3
            },
        ];
    }
}