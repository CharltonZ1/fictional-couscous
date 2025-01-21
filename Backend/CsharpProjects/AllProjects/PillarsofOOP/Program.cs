using PillarsofOOP;

Console.WriteLine("***** Fun with Encapsulation *****\n");

Employee emp = new("Marvin", 456, 30000);
emp.GiveBonus(1000);
emp.DisplayStats();

// Use the get/set methods to interact with the object's name.
//emp.SetName("Marv");
//Console.WriteLine("Employee is name: {0}", emp.GetName());

// Use the property to interact with the object's name.
emp.Name = "Marv";
Console.WriteLine("Employee is named: {0}", emp.Name);

Employee emp2 = new("Jack", 48, 123, 1200, "111-111-111", EmployeePayTypeEnum.Salaried);
Console.WriteLine("\nEmployee2 stats:");
emp2.DisplayStats();
emp2.GiveBonus(300);
Console.WriteLine("Employee2 pay after bonus: {0}", emp2.Pay);


Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();