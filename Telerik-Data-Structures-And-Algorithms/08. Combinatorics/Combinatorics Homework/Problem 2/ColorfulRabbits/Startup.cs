namespace ColorfulRabbits
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Dictionary<int, int> rabbits = new Dictionary<int, int>(1000000);
            int numberOfRabbits = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int rabbit = int.Parse(Console.ReadLine());

                if (rabbits.ContainsKey(rabbit))
                {
                    int val = rabbits[rabbit];
                    if (val > rabbit)
                    {
                        numberOfRabbits += rabbit + 1;
                        rabbits.Remove(rabbit);
                    }
                    else
                    {
                        rabbits[rabbit] += 1;
                        if (val == rabbit)
                        {
                            rabbits.Remove(rabbit);
                        }
                    }
                }
                else
                {
                    rabbits.Add(rabbit, 1);
                    numberOfRabbits += rabbit + 1;
                }
            }

            Console.WriteLine(numberOfRabbits);
        }
    }
}