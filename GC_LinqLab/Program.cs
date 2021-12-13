using System;
using System.Collections.Generic;
using System.Linq;

namespace GC_LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Edgar", 45)); //Added to test finding vowels
            students.Add(new Student("Idiocracy", 25)); //Added to test finding vowels
            students.Add(new Student("adam", 25)); //Added to test finding vowels
            students.Add(new Student("Curtis", 10));

            int result;
            List<int> results = new List<int>();
            Student studentResult = new Student(null, 0);
            List<Student> studentResults = new List<Student>();

            Console.WriteLine("\n-----NUMS LIST-----");

            Console.WriteLine("\nFind the Min Value");
            result = nums.Min();
            Console.WriteLine(result);

            Console.WriteLine("\nFind the Max value");
            result = nums.Max();
            Console.WriteLine(result);

            Console.WriteLine("\nFind Max less than 10,000");
            result = nums.Where(x => x < 10000).Max();
            Console.WriteLine(result);

            Console.WriteLine("\nFind all values between 10 and 100");
            results = nums.Where(x => x > 10 && x < 100).ToList();
            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"Count of list: {results.Count} <---There are no matches");

            Console.WriteLine("\nFind all values between 100000 and 999999 inclusive");
            results = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            foreach (var num in results)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nCount all the even numbers");
            result = nums.Count(x => x % 2 == 0);
            Console.WriteLine(result);

            Console.WriteLine("\n\n-----STUDENT LIST-----");

            Console.WriteLine("\nFind all the students age of 21 and over");
            studentResults = students.Where(x => x.Age >= 21).ToList();
            foreach (var s in studentResults)
            {
                Console.WriteLine($"Name: {s.Name} Age: {s.Age}");
            }

            Console.WriteLine("\nFind the oldest student");
            int oldestStudent = students.Max(x => x.Age);
            studentResult = students.Where(x => x.Age == oldestStudent).ToList().First();
            Console.WriteLine($"Name: {studentResult.Name} Age: {studentResult.Age}");

            Console.WriteLine("\nFind the youngest student");
            int youngestStudent = students.Min(x => x.Age);
            studentResult = students.Where(x => x.Age == youngestStudent).ToList().First();
            Console.WriteLine($"Name: {studentResult.Name} Age: {studentResult.Age}");

            Console.WriteLine("\nFind the oldest student under the age of 25");
            int oldestUnder25 = students.Where(x=> x.Age < 25).Max(x => x.Age);
            studentResult = students.Where(x => x.Age == oldestUnder25).ToList().First();
            Console.WriteLine($"Name: {studentResult.Name} Age: {studentResult.Age}");

            Console.WriteLine("\nFind all students over 21 with even ages");
            studentResults = students.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();
            foreach (var s in studentResults)
            {
                Console.WriteLine($"Name: {s.Name} Age: {s.Age}");
            }

            Console.WriteLine("\nFind all teenage students ages 13-19 inclusive");
            studentResults = students.Where(x => x.Age >= 13  && x.Age <= 19).ToList();
            foreach (var s in studentResults)
            {
                Console.WriteLine($"Name: {s.Name} Age: {s.Age}");
            }

            Console.WriteLine("\nFind all students whose name starts with a vowel");
            char[] vowels = new char[10] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            studentResults = students.Where(x => x.Name.IndexOfAny(vowels,0,1) != -1).ToList();
            foreach (var s in studentResults)
            {
                Console.WriteLine($"Name: {s.Name} Age: {s.Age}");
            }
        }
    }
}
