

using Domain.Models.Teacher;


namespace Infrastructure.Services;

public class TeacherServices
{
    List<Teacher> teacher = new List<Teacher>();
    public List<Teacher> GetTeacher()
    {
        return teacher;
    }
    public void AddTeacher(Teacher Teacher)
    {
        teacher.Add(Teacher);
    } 
    public void UpdateTeacher(Teacher Teacher)
    {
        foreach (var item in teacher)
        {
            if(item.Id == Teacher.Id)
            {
                item.Id = Teacher.Id;
                item.FirstName = Teacher.FirstName;
                item.LastName = Teacher.LastName;
                item.ExperienceAmount = Teacher.ExperienceAmount;
                item.Position = Teacher.Position;
                
            }
        }
            
    }
    public void DeleteTeacher(int id)
    {
        foreach (var item in teacher)
        {
            if(item.Id == id)
            teacher.Remove(item);
            
        }
      
    }
}