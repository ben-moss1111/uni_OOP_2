using System;
using System.IO;


namespace OOP_Review_Code
{
    class Program
    {
        private static string input { get; set; }
        private static string[] file1 { get; set; }
        private static string[] file2 { get; set; }
        static void Main(string[] args)
        {
            MainDisplay();
        }
        static bool IsSame()
        {
            if (file1.Length == file2.Length) //Checks if files have an equal number of lines
            {
                for (int i = 0; i < file1.Length; i++) //for every line
                {
                    if (file1[i] != file2[i]) //if the lines do not match
                    {
                        return false; 
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        static string[] initFileArr(string file)
        {
            string[] array;
            while (true)
            {
                try
                {
                    array = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\../../\" + file + ".txt"); //try and see if input is a file 
                    return array;
                }
                catch (FileNotFoundException e) // if it is not, catch error and prompt user
                {
                    Console.WriteLine("Please input a file in this directory");
                    file = Console.ReadLine();
                }
            }
            
        }

 
        static void MainDisplay()
        {
            Console.WriteLine("Please input the files:");
            input = Console.ReadLine();
            file1 = initFileArr(input);
            Console.WriteLine("Please input the second file:");
            input = Console.ReadLine();
            file2 = initFileArr(input);
            bool EqualsCheck = IsSame();
            if (EqualsCheck == true)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }


        }
        


    }
}
