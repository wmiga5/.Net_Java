
using ConsoleApp1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

[assembly: InternalsVisibleTo("Test_UNIT")]
[assembly: InternalsVisibleTo("WinFormsApp1"), InternalsVisibleTo("GUI")]
int Backpack_size=0;
int Number=0, Seed=0;

Console.WriteLine("Wprowadź pojemność plecaka,ilosc elementow i seed:");
Backpack_size = int.Parse(Console.ReadLine());
Number = int.Parse(Console.ReadLine());
Seed = int.Parse(Console.ReadLine());
Problem problem = new Problem(Number, Seed);
Console.WriteLine(problem);
Result solved_problem = new(problem.Solve(Backpack_size));

Console.WriteLine(problem);

Console.WriteLine(solved_problem);

 




