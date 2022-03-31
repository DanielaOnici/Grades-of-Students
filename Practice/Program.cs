using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {

        static void Main(string[] args)
        {

            string input, grade1;
            int numberOfStudents, i, numberBelowAvg = 0, numberAboveAvg = 0, numberHighest = 0, numberLowest = 0;
            decimal Average = 0, highestGrade = -1, lowestGrade = 999;

            Console.WriteLine("Input the number of students: ");
            input = Console.ReadLine();
            numberOfStudents = int.Parse(input);

            decimal[] gradesOfStudents = new decimal [numberOfStudents];


            for (i = 0; i < numberOfStudents; i++)
            {
                // calculating average with the grades input
                Console.Write("\nInput the grade of the student {0}: ", i + 1);
                grade1 = Console.ReadLine();
                gradesOfStudents [i] = decimal.Parse(grade1);
                Average += gradesOfStudents [i] / numberOfStudents;

                // calculating the highest and lowest grade
                if (gradesOfStudents[i] > highestGrade)
                {
                    highestGrade = gradesOfStudents[i];
                }
                if (gradesOfStudents[i] < lowestGrade)
                {
                    lowestGrade = gradesOfStudents[i];
                }
            }
            Console.Write("\nThe average of the class is {0}", Average);

            for (i = 0; i < numberOfStudents; i++)
            {
                // counting abouve and below average students
                if (gradesOfStudents[i] > Average)
                {
                    numberAboveAvg++;
                }
                if (gradesOfStudents[i] < Average)
                {
                    numberBelowAvg++;
                }
                // counting number of highest and lowest grades
                if (gradesOfStudents[i] == highestGrade)
                {
                    numberHighest++;
                }
                if (gradesOfStudents[i] == lowestGrade)
                {
                    numberLowest++;
                }
            }

            int[] indexPosition = new int[numberLowest];
            int j = 0;

            for (i = 0; i < numberOfStudents; i++)
            {
                if (gradesOfStudents[i] == lowestGrade)
                {
                    indexPosition[j] = i;
                    j++;
                }
            }
             

            Console.Write("\nThe number of students above average is {0}", numberAboveAvg);
            Console.Write("\nThe number of students below average is {0}", numberBelowAvg);
            Console.Write("\nThe highest Grade is {0}", highestGrade);
            Console.Write("\nThe number of students with the highest grade is {0}", numberHighest);
            Console.Write("\nThe lowest Grade is {0}", lowestGrade);
            Console.Write("\nThe number of students with the lowest grade is {0}", numberLowest);
            foreach (int position in indexPosition)
            {
                Console.Write($"\nThe index of the student with the lowest grade is {position}");
            }

        }
    }
}
