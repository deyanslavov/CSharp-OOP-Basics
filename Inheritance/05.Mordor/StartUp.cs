namespace _05.Mordor
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            int moodValue = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var food = new Food(input[i]);
                moodValue += food.GetPoints(food.Name);
            }

            Console.WriteLine(moodValue);
            if (moodValue < -5)
            {
                Console.WriteLine("Angry");
            }
            else if (moodValue >= -5 && moodValue <= 0)
            {
                Console.WriteLine("Sad");
            }
            else if (moodValue >= 1 && moodValue <= 15)
            {
                Console.WriteLine("Happy");
            }
            else if (moodValue > 15)
            {
                Console.WriteLine("JavaScript");
            }
        }
    }
}
