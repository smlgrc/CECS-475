using DomainModel;
using System.Collections.Generic;

namespace Mm.BusinessLayer
{
    public interface IBusinessLayer
    {
        #region Standard
        //IList<Teacher> GetAllTeachers();
        IEnumerable<Standard> GetAllStandards();

        //Teacher GetTeacherByName(string teacherName);
        Standard GetStandardByID(int id);

        //Teacher GetTeacherById(int teacherID);
        Standard GetStandardByName(string name);

        //void AddTeacher(params Teacher[] teachers);
        void AddStandard(Standard standard);

        //void UpdateTeacher(params Teacher[] teachers);
        void UpdateStandard(Standard standard);

        //void RemoveTeacher(params Teacher[] teachers);
        void RemoveStandard(Standard standard);
        #endregion

        #region Student
        IEnumerable<Student> GetAllStudents();
        Student GetStudentByID(int id);
        Student GetStudentByName(string name);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void RemoveStudent(Student student);
        #endregion

        #region Teacher
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacherByID(int id);
        Teacher GetTeacherByName(string name);
        void AddTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void RemoveTeacher(Teacher teacher);
        IEnumerable<Course> GetCourseByTeacherID(int id);
        #endregion

        //IList<Course> GetCoursesByTeacherId(int teacherId);

        #region Course
        IEnumerable<Course> GetAllCourses();
        Course GetCourseByID(int id);
        Course GetCourseByName(string name);
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void RemoveCourse(Course course);
        #endregion


        //IList<Course> GetAllCourses();
        //Course GetCourseByName(string courseName);
        //Course GetCourseById(int courseId);
        //void AddCourse(params Course[] courses);
        //void UpdateCourse(params Course[] courses);
        //void RemoveCourse(params Course[] courses);
    }
}