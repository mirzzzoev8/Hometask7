

using Domain.Models.Student;


namespace Infrastructure.Services;

public class StudentServices
{
    List<Student> student = new List<Student>();
    public List<Student> GetStudent()
    {
        return student;
    }
    public void AddStudent(Student Student)
    {
        student.Add(Student);
    } 
    public void UpdateStudent(Student Student)
    {
        foreach (var item in student)
        {
            if(item.Id == Student.Id)
            {
                item.Id = Student.Id;
                item.FirstName = Student.FirstName;
                item.LastName = Student.LastName;
                item.BirthDate = Student.BirthDate;
                item.Address = Student.Address;
            
            }
        }
            
    }
    public void DeleteStudent(int id)
    {
        foreach (var item in student)
        {
            if(item.Id == id)
            student.Remove(item);
            
        }
        
    }
}