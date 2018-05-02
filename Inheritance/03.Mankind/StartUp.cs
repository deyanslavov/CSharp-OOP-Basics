namespace _03.Mankind
{
    using System;

    class StartUp
    {
        static void Main()
        {
            try
            {
                var studentInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var student = new Student(studentInput[2], studentInput[0], studentInput[1]);
                var workerInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var worker = new Worker(decimal.Parse(workerInput[2]), int.Parse(workerInput[3]), workerInput[0], workerInput[1]);

                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
