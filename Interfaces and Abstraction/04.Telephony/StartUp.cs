namespace _04.Telephony
{
    using System;
    
    class StartUp
    {
        static void Main()
        {
            var smartphone = new Smartphone();

            var numbersInput = Console.ReadLine().Split();
            var urlsInput = Console.ReadLine().Split();

            foreach (var number in numbersInput)
            {
                smartphone.Call(number);
            }
            foreach (var url in urlsInput)
            {
                smartphone.Browse(url);
            }
        }
    }
}
