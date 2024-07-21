

using BethanysPieShopHRM;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "betany12@outlook.com", new DateTime(1979, 1, 16), 25);

bethany.DisplayEmployeeDetails();

bethany.PerformWork(3);
bethany.PerformWork(6);
bethany.PerformWork(5);
bethany.PerformWork(7);

double receievedWageBethany = bethany.ReceiveWage(true);

Console.WriteLine($"Wage paid (message from program): {receievedWageBethany}");

Console.WriteLine("\n");
Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee maria = new ("Maria", "Jones", "mariaJones@hotmail.com", new DateTime(1970, 12, 12), 30);

maria.DisplayEmployeeDetails();

maria.PerformWork(4);
maria.PerformWork(3);
maria.PerformWork(4);
maria.PerformWork(10);

var receivedWageMaria = maria.ReceiveWage(true);

Console.WriteLine($"Wage paid (message from program) {receivedWageMaria}");


Console.WriteLine("\n");
Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee george = new Employee("George", "Washington", "gwashington@mail.ru", new DateTime(1975, 9, 30), 28);

george.DisplayEmployeeDetails();

george.PerformWork(10);
george.PerformWork(5);
george.PerformWork(2);
george.PerformWork();

var receivedWageGeorge = george.ReceiveWage(true);

Console.WriteLine($"Wage paid (message from program): {receivedWageGeorge}");
//


