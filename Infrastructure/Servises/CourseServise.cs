﻿

using Domain.Models.Course;


namespace Infrastructure.Services;

public class CourseServices
{
    List<Course> course = new List<Course>();
    public List<Course> GetCourse()
    {
        return course;
    }
    public void AddCourse(Course Course)
    {
        course.Add(Course);
    } 
    public void UpdateCourse(Course Course)
    {
        foreach (var item in course)
        {
            if(item.id == Course.id)
            {
                item.id = Course.id;
                item.Title = Course.Title;
                item.Description = Course.Description;
                item.Fee = Course.Fee;
                item.HasDiscount = Course.HasDiscount;
                
            }
        }
            
    }
    public void DeleteCourse(int id)
    {
        foreach (var item in course)
        {
            course.Remove(item);
            
        }
      
    }
}