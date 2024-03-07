using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class CourseDal : ICourseDal
	{

		List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>();
        }
        public void Add(Course course)
		{
			_courses.Add(course);
		}

		public void Delete(Course course)
		{
			_courses.Remove(course);
		}

		public List<Course> GetAll()
		{
			return _courses;
		}

		public void Update(Course course)
		{
			Course existCourse = _courses.Find(x=>x.Id == course.Id);
			if (existCourse is null)
				return;
			existCourse.CoursePrice = course.CoursePrice;
			existCourse.CourseName =course.CourseName;
			existCourse.CourseImage = course.CourseImage;
			existCourse.ProgressBar = course.ProgressBar;
			existCourse.Description= course.Description;
			existCourse.CategoryId = course.CategoryId;
			existCourse.InstructorId= course.InstructorId;
		}
	}
}
