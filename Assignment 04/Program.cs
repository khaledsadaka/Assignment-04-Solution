namespace Assignment_04
{
    internal class Program
    {

         static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            /*

            Console.Write("Please Enter Number: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                Console.WriteLine($"Numbers from 1 to {number}:");
                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"{i} ");
                }
            }

            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }


            */

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.


            /*

            Console.Write("Please Enter Number: ");

            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                Console.WriteLine($"Multiplication table for {number}:");

                for (int i = 1; i <= 12; i++)
                {
                    int result = number * i;
                    Console.WriteLine($"{number} x {i} = {result}");
                }

            }
            else
            {
                Console.WriteLine("Enter Valid Number");
            }


            */

            #endregion



            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            /*

            Console.Write("Enter a number: ");
            int num;

            while (!int.TryParse(Console.ReadLine(), out num) || num < 1)
            {
                Console.Write("Please enter a valid  Number !?");
            }

            Console.WriteLine($"Even Numbers Between 1 And {num}:");
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }


            */


            #endregion


            #region 4- Write a program that takes two integers then prints the power.


            /*

            Console.Write("Enter the base number: ");
            int baseNumber;
            while (!int.TryParse(Console.ReadLine(), out baseNumber))
            {
                Console.Write("Please Enter Invalid Number For The Base: ");
            }

            Console.Write("Enter The Power: ");
            int power;
            while (!int.TryParse(Console.ReadLine(), out power))
            {
                Console.Write("Please Enter Invalid Number For The Power: ");
            }

            double result = Math.Pow(baseNumber, power);


            Console.WriteLine($"{baseNumber} raised to the power of {power} is {result}");

            */

            #endregion


            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage

            /*

            int[] marks = new int[5]; //0 1 2 3 4
            int totalMarks = 0;
            const int maxMark = 100; 

            Console.WriteLine("Enter marks for 5 subjects From 100 :");
            for (int i = 0; i <= 4; i++)
            {
                Console.Write($"Subject {i + 1 }: ");
                while (!int.TryParse(Console.ReadLine(), out marks[i]) || marks[i] < 1 || marks[i] > maxMark)
                {
                    Console.Write($"Invalid Mark. Please enter marks between 0 and {maxMark} for Subject {i + 1 }: ");
                }
                totalMarks += marks[i];
            }

            double average = totalMarks / 5.0;
            double percentage = (totalMarks / (5.0 * maxMark)) * 100;

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Average Marks: {average:F2}");
            Console.WriteLine($"Percentage: {percentage:F2}%");


            */


            #endregion


            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.

            /*

            Console.Write("Enter a String: ");
            string st = Console.ReadLine();


            char[] charArray = st.ToCharArray(); 
            Array.Reverse(charArray);              
            string reversedString = new string(charArray);

            Console.WriteLine($"Reversed string: {reversedString}");

            */

            #endregion


            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.






            #endregion


            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.

            /*

            Console.Write("Input starting number of range: ");
            int start = int.Parse(Console.ReadLine());


            Console.Write("Input ending number of range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"The prime numbers between {start} and {end} are:");

            for (int i = start; i <= end; i++)
            {
                if (i <= 1) continue; 

                bool isPrime = true; 
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0) 
                    {
                        isPrime = false; 
                        break; 
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " "); 
                }
            }

            */

            #endregion




            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.


            /*

            Console.Write("Enter a number to convert: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("The Binary of 0 is 0.");
                return;
            }

            string binary = ""; 

            while (number > 0)
            {
                int remainder = number % 2; 
                binary += remainder; 
                number /= 2; 
            }

            Console.WriteLine($"The Binary is {binary}.");


            */

            #endregion


            //not ans
            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.





            #endregion


            //not ans
            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.


            #endregion


            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.

            /*

            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element[{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }

            Console.WriteLine($"The sum of elements in array is: {sum}");

            
            */

            #endregion


            //not answer
            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.




            #endregion



            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.


            /*

            Console.Write("Enter the number elements of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];


            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> frequency = new Dictionary<int, int>();


            foreach (int num in arr)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            Console.WriteLine("\nFrequency of elements:");
            foreach (var item in frequency)
            {
                Console.WriteLine($"Element {item.Key} appears {item.Value} times.");
            }

            */

            #endregion




            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array

            /*

            Console.Write("Enter the number elements of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];

            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine($"\nMaximum element in the array: {max}");
            Console.WriteLine($"Minimum element in the array: {min}");

            */

            #endregion




            #region 16- Write a program in C# Sharp to find the second largest element in an array.

            /*

            Console.Write("Enter the number elements of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];


            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }



            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            if (secondLargest == int.MinValue)
            {
                Console.WriteLine("There is no second largest element.");
            }
            else
            {
                Console.WriteLine($"\nThe second largest element in the array is: {secondLargest}");
            }

            */

            #endregion



            //not
            #region 17-. Consider an Array of Integer values with size N, having values as in this Example



            #endregion


            #region 18- Given a list of space separated words, reverse the order of the words.


            #endregion




            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            /*

            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] firstArray = new int[rows, columns];
            int[,] secondArray = new int[rows, columns];

            Console.WriteLine("Enter the elements for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter element for position ({i + 1}, {j + 1}): ");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    secondArray[i, j] = firstArray[i, j];
                }
            }

            Console.WriteLine("\nSecond Array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(secondArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            */

            #endregion


            #region 20- Write a Program to Print One Dimensional Array in Reverse Order

            /*

            Console.Write("Enter the number elements of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray in reverse :");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            */
            #endregion
        }

    }
}
