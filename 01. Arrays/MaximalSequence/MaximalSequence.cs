//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
//Example:

//input	                                        result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	                2, 2, 2

using System;
using System.Collections.Generic;



class MaximalSequence
{
    static void Main()
    {
        string str;
        int choice;
        int length;
        //asks for an array type
        do
        {
            Console.WriteLine("Please choose an array type: ");
            Console.WriteLine("integer array ==> 1");
            Console.WriteLine("char array ==> 2");
            Console.Write("Your choice: ");
            str = Console.ReadLine();
            Console.Clear();

        } while (!int.TryParse(str, out choice) || choice != 1 && choice != 2);

        //asks for the lenght of the array
        do
        {
            Console.Write("Please enter array lenght: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out length));
        
        //int array
        if (choice == 1)
        {
            int element = 0;
            //creates an array according to chosen type and lenght
            int[] chosenArray = new int[length];

            //asks for int array inputs and initializes array accordingly(inputs must be valid)
            for (int i = 0; i < length; i++)
            {
                Console.Write("Please enter int element {0} of the first array: ", i);

                chosenArray[i] = int.Parse(Console.ReadLine());
            }

            //checks for repeating elements and counts those
            int longestSequence = 1;

            for (int i = 0; i < chosenArray.Length; i++)
            {
                //element = chosenArray[i];
                if (i + 1 < chosenArray.Length)
                {
                    if (chosenArray[i] == chosenArray[i + 1])
                    {
                        int count = 2;
                        while (i + count < chosenArray.Length)
                        {
                            while (chosenArray[i + count - 1] == chosenArray[i + count])
                            {
                                count++;
                                if (i + count + 1 > chosenArray.Length)
                                {
                                    break;
                                }
                            }
                            break;
                        }

                        if (count > longestSequence)
                        {
                            longestSequence = count;
                            element = chosenArray[i];
                        }
                    }
                }
            }
            //creates a new array with the max sequence
            int[] longestSequenceArray = new int[longestSequence];

            //initiallizes the array with longest sequence
            if (longestSequence == 1)
            {
                Console.WriteLine("Maximal sequence of elements is 1");
                longestSequenceArray[0] = element;
            }

            else
            {
                for (int i = 0; i < longestSequenceArray.Length; i++)
                {
                    longestSequenceArray[i] = element;
                }

                //prints the array

                for (int i = 0; i < longestSequenceArray.Length; i++)
                {
                    if (i == longestSequenceArray.Length - 1)
                    {
                        Console.Write(longestSequenceArray[i]);
                    }
                    else
                    {
                        Console.Write(longestSequenceArray[i] + ", ");
                    }
                }

                Console.WriteLine();
            }

        }
        //char array
        else if (choice == 2)
        {
            char element=' ';
            //creates an array according to chosen type and lenght
            char[] chosenArray = new char[length];

            //asks for char array inputs and initializes array accordingly(inputs must be valid)
            for (int i = 0; i < length; i++)
            {
                Console.Write("Please enter char element {0} of the first array: ", i);

                chosenArray[i] = char.Parse(Console.ReadLine());
            }

            //checks for repeating elements and counts those
            int longestSequence = 1;

            for (int i = 0; i < chosenArray.Length; i++)
            {
                //element = chosenArray[i];
                if (i + 1 < chosenArray.Length)
                {
                    if (chosenArray[i] == chosenArray[i + 1])
                    {
                        int count = 2;
                        while (i + count + 1 < chosenArray.Length)
                        {
                            while (chosenArray[i + count - 1] == chosenArray[i + count])
                            {
                                count++;
                                if (i + count + 1 > chosenArray.Length)
                                {
                                    break;
                                }
                            }
                            break;
                        }

                        if (count > longestSequence)
                        {
                            longestSequence = count;
                            element = chosenArray[i];
                            //Console.WriteLine(element);
                        }
                    }
                }
            }
            //creates a new array with the max sequence
            char[] longestSequenceArray = new char[longestSequence];

            //initiallizes the array with longest sequence
            if (longestSequence == 1)
            {
                Console.WriteLine("Maximal sequence of elements is 1");
                longestSequenceArray[0] = element;
            }

            else
            {
                for (int i = 0; i < longestSequenceArray.Length; i++)
                {
                    longestSequenceArray[i] = element;
                }

                //prints the array

                for (int i = 0; i < longestSequenceArray.Length; i++)
                {
                    if (i == longestSequenceArray.Length - 1)
                    {
                        Console.Write(longestSequenceArray[i]);
                    }
                    else
                    {
                        Console.Write(longestSequenceArray[i] + ", ");
                    }
                }

                Console.WriteLine();
            }

        }

    }
}



