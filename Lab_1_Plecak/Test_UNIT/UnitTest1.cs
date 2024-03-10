using ConsoleApp1;

namespace Test_UNIT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Count_Elements_Test()
        {
           List<int> sizes = new List<int>() {10,20,30,40,50};
            foreach (int n in sizes) 
            {
                Problem problem=new Problem(n,1);
                Assert.AreEqual(n, problem.results.Count);
            }
        }
        [TestMethod]
        public void If_Any_Is_Possible() //Jeœli jest jakiœ co siê mieœci to rozwi¹zanie co najmniej 1
        {
            Problem problem = new(10, 1);
            foreach(Item m in problem.results)
            {
                if (m.weight <= 20) //Bazowo rozmiar plecaka jest na 20 
                {
                    Assert.IsTrue(problem.Solve(20).Count > 1);
                }

            }

        }
        [TestMethod]
        public void If_non_is_fine_leave_empty()
        {
            Problem problem = new(10, 1);

            Assert.IsTrue(problem.Solve(0).Count ==0);
        }

        [TestMethod]
        public void Check_if_order_is_important()
        {
            Problem problem1 = new Problem(10,1);
            Problem problem2 = new Problem(10,1);

            problem2.results.Reverse();

            Result result1 = new Result(problem1.Solve(6));
            Result result2 = new Result(problem2.Solve(6));

            for(int i = 0;i<result1.solved.Count;i++) 
            {
                Assert.AreEqual(result1.solved[i].weight, result2.solved[i].weight);
                Assert.AreEqual(result1.solved[i].value, result2.solved[i].value);
                Assert.AreEqual(result1.solved[i].index, result2.solved[i].index);

            }

            
            Assert.AreEqual(result1.total_weight, result2.total_weight);
            Assert.AreEqual(result1.total_value, result2.total_value);

        }
        [TestMethod]
        public void Check_if_solved_correctly()
        {
            Problem problem1=new Problem(5,1);
            
            Result result1=new Result(problem1.Solve(20)); //Taki rozmiar plecaka

            List<Item> result2 = new List<Item>() { new Item(2, 7, 4),new Item(4,10,3),new Item(5,8,1), new Item(7,5,2) };

            for(int i = 0; i<result1.solved.Count; i++)
            {
                Assert.AreEqual(result1.solved[i].weight, result2[i].weight);
                Assert.AreEqual(result1.solved[i].value, result2[i].value);
                Assert.AreEqual(result1.solved[i].index, result2[i].index);
            }


        }

        [TestMethod]
        public void Zero_elements_to_chose()
        {
            Problem problem=new Problem(0,1);
            Assert.IsTrue(problem.Solve(20).Count == 0);
        }

        [TestMethod]
        public void Negative_Capacity()
        {
            Problem problem =new Problem(10,1);
            Result result =new Result(problem.Solve(-2));

            Assert.IsTrue(result.total_weight == 0);
            Assert.IsTrue(result.total_value == 0);
            Assert.IsTrue(result.solved.Count == 0);
        }
    }
}