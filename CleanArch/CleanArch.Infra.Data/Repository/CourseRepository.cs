using CleanArch.Domain;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _universityDbContext;

        public CourseRepository(UniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }

        public void Add(Course course)
        {
            _universityDbContext.Add(course);
            _universityDbContext.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _universityDbContext.Courses;
        }
    }
}
