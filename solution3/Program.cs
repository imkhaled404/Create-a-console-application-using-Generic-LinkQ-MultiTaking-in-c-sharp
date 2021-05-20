using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution3
{
    class Program
    {
        private static void CreateTaskUsingAction()
        {
            Console.WriteLine("This Task is created using Action.\n");
        }

        private static void CreateTaskUsingDelegate()
        {
            Console.WriteLine("This Task is created using Delegate.\n");
        }

        private static void CreateTaskUsingLambdaAndNamedMethod()
        {
            Console.WriteLine("This Task is created using Lambda and Named Method.\n");
        }

        private static void CreateTaskUsingLambdaAndAnonymousMethod()
        {
            Console.WriteLine("This Task is created using Lambda and Anonymous Method.\n");
        }

        private static void CreateTaskUsingAsyncAwait()
        {
            Console.WriteLine("This Task is created using Async and Await.\n");
        }

        private static async void CreateAsyncTask()
        {
            await Task.Run(() => CreateTaskUsingAsyncAwait());
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static async void SolveTheMath(int firstInt, int secondtInt)
        {
            int result = await Task.FromResult(Add(firstInt, secondtInt));
            await Task.Delay(1000);
            Console.WriteLine("Result = " + result.ToString());
        }

        static void Main(string[] args)
        {

            Task.Factory.StartNew(() => { Console.WriteLine("This Task is created using Factory Method.\n"); }); //Creating a Task using Factory Method

            Task actionTask = new Task(new Action(CreateTaskUsingAction)); //Creating a Task using Action
            actionTask.Wait(1000);
            actionTask.Start();

            Task delegateTask = new Task(delegate { CreateTaskUsingDelegate(); }); //Creating a Task using Delegate.
            delegateTask.Wait(1000);
            delegateTask.Start();

            Task lambdaAndNamedMethodTask = new Task(() => CreateTaskUsingLambdaAndNamedMethod()); //Creating a Task using Lambda and Named Method.
            lambdaAndNamedMethodTask.Wait(1000);
            lambdaAndNamedMethodTask.Start();

            Task lambdaAndAnonymousMethodTask = new Task(() => { CreateTaskUsingLambdaAndAnonymousMethod(); }); //Creating a Task using Lambda and Anonymous Method.
            lambdaAndAnonymousMethodTask.Wait(1000);
            lambdaAndAnonymousMethodTask.Start();

            CreateAsyncTask(); //Creating a Task using Async and Await.

            Console.Write("\nFirst Integer = ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Second Integer = ");
            int secondtInt = int.Parse(Console.ReadLine());

            SolveTheMath(firstInt, secondtInt); //Creating a Task using FromResult Method.

            Console.ReadKey();
        }


    }
}
