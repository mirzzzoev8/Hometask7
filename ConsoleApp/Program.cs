using Domain.Models.Course;
using Domain.Models.Post;
using Domain.Models.Student;
using Domain.Models.Teacher;
using Infrastructure.Services;

// Postservises
var post1 = new Post();
post1.Id = 1;
post1.Title = "Salom";
post1.Description = "Hamakasa";
post1.VoteAmount = 10;
post1.CreatedAt = DateTime.Now;
var postServises = new PostServices();
postServises.AddPost(post1);
var post2 = new Post();
post2.Id = 2;
post2.Title = "Salom";
post2.Description = "Hamakasa";
post2.VoteAmount = 15;
post2.CreatedAt = DateTime.Now;
postServises.UpdatePost(post2);
foreach (var item in postServises.GetPost())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Title);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.VoteAmount);
    System.Console.WriteLine(item.CreatedAt);
}
postServises.DeletePost(2);

// CourseServises
var course1 = new Course();
course1.Id = 1;
course1.Title = "Salom";
course1.Description = "Hamakasa";
course1.Fee = 10;
course1.HasDiscount = true;
var courseServises = new CourseServices();
courseServises.AddCourse(course1);
var course2 = new Course();
course2.Id = 2;
course2.Title = "Salom";
course2.Description = "Hamakasa";
course2.Fee = 15;
course2.HasDiscount = false;
courseServises.UpdateCourse(course2);
foreach (var item in courseServises.GetCourse())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Title);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.Fee);
    System.Console.WriteLine(item.HasDiscount);
}
courseServises.DeleteCourse(2);

// StudentServise
var st1 = new Student();
st1.Id = 1;
st1.LastName = "Salom";
st1.FirstName = "Hamakasa";
st1.Address = "bhdcbdhb";
st1.BirthDate = DateTime.Now;
var stServises = new StudentServices();
stServises.AddStudent(st1);
var st2 = new Student();
st2.Id = 2;
st2.LastName = "Salom";
st2.FirstName = "Hamakasa";
st2.BirthDate = DateTime.Now;
st2.Address = "bhbh";
stServises.UpdateStudent(st2);
foreach (var item in stServises.GetStudent())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Address);
    System.Console.WriteLine(item.BirthDate);
}
stServises.DeleteStudent(2);

// TeacherServises
var tt1 = new Teacher();
tt1.Id = 1;
tt1.LastName = "Salom";
tt1.FirstName = "Hamakasa";
tt1.Position = "bhdcbdhb";
tt1.ExperienceAmount = 235;
var ttServises = new TeacherServices();
ttServises.AddTeacher(tt1);
var tt2 = new Teacher();
tt2.Id = 2;
tt2.LastName = "Salom";
tt2.FirstName = "Hamakasa";
tt2.Position = "bjbhb";
tt2.ExperienceAmount = 523;
ttServises.UpdateTeacher(tt2);
foreach (var item in ttServises.GetTeacher())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Position);
    System.Console.WriteLine(item.ExperienceAmount);
}
ttServises.DeleteTeacher(2);



