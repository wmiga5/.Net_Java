namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem problem= new Problem(10,5);
            Console.WriteLine(problem);
            Result solved_problem = new Result(problem.Solve(20));

            Console.WriteLine(problem);
           
            Console.WriteLine(solved_problem);
        }
    }
}
