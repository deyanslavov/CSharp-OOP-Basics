namespace _10.ExplicitInterfaces
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var personInfo = line.Split();
                var citizen = new Citizen(personInfo[0], int.Parse(personInfo[2]));

                IResident r = citizen;
                IPerson p = citizen;
                Console.WriteLine(citizen.Name);
                Console.WriteLine(r.GetName() + " " + p.GetName());
            }
        }
    }
}
