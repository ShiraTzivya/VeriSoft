// See https://aka.ms/new-console-template for more information
using VeriSoft;

Console.WriteLine("Hello, University");
//Creating students
Student s1 = new("Dan", 2000, "Hzait 1");
Student s2 = new("Gad", 2001, "Hzait 2");
Student s3 = new("Avi", 2002, "Hzait 3");
Student s4 = new("Ron", 2003, "Hzait 4");
Student s5 = new("Tom", 2004, "Hzait 5");
Student s6 = new("Ben", 2005, "Hzait 6");
Student s7 = new("Nan", 2006, "Hzait 7");
Student s8 = new("Eli", 2007, "Hzait 8");

//Creating professors
Professor p1 = new("Neta", 1980, "Hrimon 1", "Mathematics");
Professor p2 = new("Shir", 1981, "Hrimon 2", "Biology");
Professor p3 = new("Lea", 1982, "Hrimon 3", "Psychology");
Professor p4 = new("Pini", 1983, "Hrimon 4", "History");

//Creating UndergraduateCourse
UndergraduateCourse uc1 = new("Mathematics");
UndergraduateCourse uc2 = new("Biology");
UndergraduateCourse uc3 = new("Psychology");
UndergraduateCourse uc4 = new("History");

//Creating GraduateCourse
GraduateCourse gc1 = new("Mathematics", "Dynamical Systems");
GraduateCourse gc2 = new("Biology", "Molecular Genetics");
GraduateCourse gc3 = new("Psychology", "Health Psychology");
GraduateCourse gc4 = new("History", "History of Idea");

//Function test
Console.WriteLine(s1.getAge());
Console.WriteLine(s2.getRole());
Console.WriteLine(s3.study());
Console.WriteLine(s4.Name);
Console.WriteLine(s5.Address);
Console.WriteLine(s6.StudentId);
Console.WriteLine(p1.getAge());
Console.WriteLine(p2.getRole());
Console.WriteLine(p3.teach());
Console.WriteLine(p4.Name);
Console.WriteLine(p4.Address);
uc1.addParticipant(s1);
uc2.addParticipant(s1);
uc1.addParticipant(s2);
Console.WriteLine(s1.study());
p1.addCourseTeach(uc1.CourseName);
p1.addCourseTeach(uc2.CourseName);
Console.WriteLine(p1.teach());
Console.WriteLine(uc1.getParticipants());





