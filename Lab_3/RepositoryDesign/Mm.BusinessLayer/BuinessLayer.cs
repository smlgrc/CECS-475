using DomainModel;
using Mm.DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Mm.BusinessLayer
{
    public class BuinessLayer : IBusinessLayer
    {
        private readonly IStandardRepository _standardRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly ICourseRepository _courseRepository;

        public BuinessLayer()
        {
            _standardRepository = new StandardRepository();
            _studentRepository = new StudentRepository();
            _teacherRepository = new TeacherRepository();
            _courseRepository = new CourseRepository();
        }

        //public BuinessLayer(ITeacherRepository teacherRepository, ICourseRepository courseRepository)
        //{
        //    _teacherRepository = teacherRepository;
        //    _courseRepository = courseRepository;
        //}


        #region Standard
        public IEnumerable<Standard> GetAllStandards()
        {
            return _standardRepository.GetAll();
        }
        public Standard GetStandardByID(int id)
        {
            return _standardRepository.GetById(id);
        }
        public Standard GetStandardByName(string name)
        {
            return _standardRepository.GetSingle(
                s => s.StandardName.Equals(name),
                s => s.Students);
        }
        public void AddStandard(Standard standard)
        {
            _standardRepository.Insert(standard);
        }

        public void UpdateStandard(Standard standard)
        {
            _standardRepository.Update(standard);
        }

        public void RemoveStandard(Standard standard)
        {
            _standardRepository.Delete(standard);
        }
        #endregion


        #region Student
        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }
        public Student GetStudentByID(int id)
        {
            return _studentRepository.GetById(id);
        }
        public Student GetStudentByName(string name)
        {
            return _studentRepository.GetSingle(
                s => s.StudentName.Equals(name),
                s => s.Standard);
        }
        public void AddStudent(Student student)
        {
            _studentRepository.Insert(student);
        }
        public void UpdateStudent(Student student)
        {
            _studentRepository.Update(student);
        }
        public void RemoveStudent(Student student)
        {
            _studentRepository.Delete(student);
        }
        #endregion


        #region Teacher
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAll();
        }
        public Teacher GetTeacherByID(int id)
        {
            return _teacherRepository.GetById(id);
        }
        public Teacher GetTeacherByName(string name)
        {
            return _teacherRepository.GetSingle(
                s => s.TeacherName.Equals(name),
                s => s.Standard);
        }
        public void AddTeacher(Teacher teacher)
        {
            _teacherRepository.Insert(teacher);
        }
        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepository.Update(teacher);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            _teacherRepository.Delete(teacher);
        }
        public IEnumerable<Course> GetCourseByTeacherID(int id)
        {
            return _courseRepository.GetAll().Where(x => x.TeacherId == id);
        }
        #endregion


        #region Course
        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();
        }
        public Course GetCourseByID(int id)
        {
            return _courseRepository.GetById(id);
        }
        public Course GetCourseByName(string name)
        {
            return _courseRepository.GetSingle(
                s => s.CourseName.Equals(name),
                s => s.CourseId);
        }
        public void AddCourse(Course course)
        {
            _courseRepository.Insert(course);
        }
        public void UpdateCourse(Course course)
        {
            _courseRepository.Update(course);
        }
        public void RemoveCourse(Course course)
        {
            _courseRepository.Delete(course);
        }
        #endregion


        //CRUD for teachers
        //public IList<Teacher> GetAllTeachers()
        //{
        //    return _teacherRepository.GetAll();
        //}

        //public Teacher GetTeacherByName(string teacherName)
        //{
        //    return _teacherRepository.GetSingle(
        //        d => d.TeacherName.Equals(teacherName),
        //        d => d.Courses); //include related Courses
        //}

        //public Teacher GetTeacherById(int teacherID)
        //{
        //    return _teacherRepository.GetSingle(
        //        d => d.TeacherId.Equals(teacherID),
        //        d => d.Courses); //include related Courses
        //}

        //public void AddTeacher(params Teacher[] teachers)
        //{
        //    _teacherRepository.Add(teachers);
        //}

        //public void UpdateTeacher(params Teacher[] teachers)
        //{
        //    _teacherRepository.Update(teachers);
        //}

        //public void RemoveTeacher(params Teacher[] teachers)
        //{
        //    _teacherRepository.Remove(teachers);
        //}

        //public IList<Course> GetCoursesByTeacherId(int teacherId)
        //{
        //    return _courseRepository.GetList(c => c.Teacher.TeacherId.Equals(teacherId));
        //}

        ////CRUD for courses
        //public IList<Course> GetAllCourses()
        //{
        //    return _courseRepository.GetAll();
        //}

        //public Course GetCourseByName(string courseName)
        //{
        //    return _courseRepository.GetSingle(
        //        d => d.CourseName.Equals(courseName),
        //        d => d.Teacher); //include related teacher
        //}

        //public Course GetCourseById(int courseId)
        //{
        //    return _courseRepository.GetSingle(
        //        d => d.CourseId.Equals(courseId),
        //        d => d.Teacher); //include related teacher
        //}

        //public void AddCourse(params Course[] courses)
        //{
        //    _courseRepository.Add(courses);
        //}

        //public void UpdateCourse(params Course[] courses)
        //{
        //    _courseRepository.Update(courses);
        //}

        //public void RemoveCourse(params Course[] courses)
        //{
        //    _courseRepository.Remove(courses);
        //}
    }
}