namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1Result = LinqTasks.Task1();
            Console.WriteLine(task1Result);

            var task2Result = LinqTasks.Task2();
            Console.WriteLine(task2Result);

            var task3Result = LinqTasks.Task3();
            Console.WriteLine(task3Result);

            var task4Result = LinqTasks.Task4();
            Console.WriteLine(task4Result);

            var task5Result = LinqTasks.Task5();
            Console.WriteLine(task5Result);

            var task6Result = LinqTasks.Task6();
            Console.WriteLine(task6Result);

            var task7Result = LinqTasks.Task7();
            Console.WriteLine(task7Result);

            var task8Result = LinqTasks.Task8();
            Console.WriteLine(task8Result);

            var task9Result = LinqTasks.Task9();
            Console.WriteLine(task9Result);

            var task10Result = LinqTasks.Task10();
            Console.WriteLine(task10Result);

            var task11Result = LinqTasks.Task11();
            Console.WriteLine(task11Result);

            var task12Result = LinqTasks.Task12();
            Console.WriteLine(task12Result);

            var task13Result = LinqTasks.Task13(new[] {1,1,1,1,1,1,10,1,1,1,1});
            Console.WriteLine(task13Result);

            var task14Result = LinqTasks.Task14();
            Console.WriteLine(task14Result);
        }
    }
}