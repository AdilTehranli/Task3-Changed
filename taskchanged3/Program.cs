using taskchanged3.models;

Group p137 = new("p137", 18);
Student s1 = new("Ferman", "Resullu");
Student s2 = new("Arif", "Muradli");
Student s3 = new("Logman", "Kerimli");
Student s4 = new("Feyzulla", "Resullu");
Student s5 = new("Agakerim", "memmedov");
p137.AddStudent(s1);
p137.AddStudent(s2);
p137.AddStudent(s3);
p137.AddStudent(s4);
p137.AddStudent(s5);

p137.Getstudents();