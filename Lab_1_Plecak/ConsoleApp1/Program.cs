
using ConsoleApp1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

[assembly: InternalsVisibleTo("Test_UNIT")]
int Backpack_size=20;
Problem problem = new Problem(5, 1);
Console.WriteLine(problem);
Result solved_problem = new(problem.Solve(Backpack_size));

Console.WriteLine(problem);

Console.WriteLine(solved_problem);

 




