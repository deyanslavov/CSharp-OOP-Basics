namespace _09.Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            double countRectangles = nums[0];
            double intersectionChecks = nums[1];
            var rectangles = new List<Rectangle>();

            for (int i = 0; i < countRectangles; i++)
            {
                var readRectCommand = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string id = readRectCommand[0];
                double width = double.Parse(readRectCommand[1]);
                double height = double.Parse(readRectCommand[2]);
                var point = new Point { X = double.Parse(readRectCommand[3]), Y = double.Parse(readRectCommand[4]) };
                var rectangle = new Rectangle();
                rectangle.Id = id;
                rectangle.Width = width;
                rectangle.Height = height;
                rectangle.TopLeft = point;
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < intersectionChecks; i++)
            {
                var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var rect1 = rectangles.Where(a => a.Id == command[0]).First();
                var rect2 = rectangles.Where(a => a.Id == command[1]).First(); ;
                Console.WriteLine(rect1.IntersectsWith(rect2).ToString().ToLower());
            }
        }
    }
}
