namespace _09.CollectionHierarchy
{
    using System;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            var strings = Console.ReadLine().Split();
            int numberOfRemoveOperations = int.Parse(Console.ReadLine());

            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var sbAddCollOutput = new StringBuilder();

            foreach (var item in strings)
            {
                sbAddCollOutput.Append(addCollection.Add(item) + " ");
            }

            var sbAddRemCollOutput = new StringBuilder();

            foreach (var item in strings)
            {
                sbAddRemCollOutput.Append(addRemoveCollection.Add(item) + " ");
            }

            var sbMyListOutput = new StringBuilder();

            foreach (var item in strings)
            {
                sbMyListOutput.Append(myList.Add(item) + " ");
            }

            var sbAddRemCollRemovedItems = new StringBuilder();

            for (int i = 0; i < numberOfRemoveOperations; i++)
            {
                sbAddRemCollRemovedItems.Append(addRemoveCollection.Remove() + " ");
            }

            var sbMyListRemovedItems = new StringBuilder();

            for (int i = 0; i < numberOfRemoveOperations; i++)
            {
                sbMyListRemovedItems.Append(myList.Remove() + " ");
            }

            Console.WriteLine(sbAddCollOutput.ToString().TrimEnd());
            Console.WriteLine(sbAddRemCollOutput.ToString().TrimEnd());
            Console.WriteLine(sbMyListOutput.ToString().TrimEnd());
            Console.WriteLine(sbAddRemCollRemovedItems.ToString().TrimEnd());
            Console.WriteLine(sbMyListRemovedItems.ToString().TrimEnd());
        }
    }
}
