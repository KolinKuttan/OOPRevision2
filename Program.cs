/* Program      : Object Oriented Programming Revision Week 2 Year 2
   Author       : Kolin Thazhathupuram
   Date Created : 01/10/2026
   Purpose      : File Handling revision using foreach statements, arrays and methods to work with file data*/

using System;
using static System.Console;
namespace OOPRevision2
{
    internal class Program
    {
        //file path made static so can be accessed in the whole class
        static string path = "../../../results.txt";
        static string[] grades = new string[7];
        static void Main(string[] args)
        {

            //QUESTION 1 - Calculate the total points and append this total to the original file -----------
            using (StreamReader sr = File.OpenText(path))
            {
                string line = "";
                int totalPoints = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int x = 0; x < line.Length; x++)
                    {
                        grades[x] = line;
                        totalPoints += int.Parse(line);
                    }
                    WriteLine(totalPoints);
                    
                }
            }
        }
    }
}
