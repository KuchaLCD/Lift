using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person("Ann", new DateTime(2000, 11, 12), "жен", 45);
            Console.WriteLine(per.InfoString());

            Person tc = new Teacher("Galya", new DateTime(1970, 10, 3), "жен", 67, 12);
            Console.WriteLine(tc.InfoString());

            Person tc1 = new Teacher("Robert", new DateTime(1980, 1, 4), "муж", 100, 12);
            Console.WriteLine(tc1.InfoString());

            Person st = new Student("Chel", new DateTime(1999, 1, 13), "муж", 67, 131);
            Console.WriteLine(st.InfoString());

            Person st1 = new Student("Fedya", new DateTime(1999, 7, 12), "муж", 58, 131);
            Console.WriteLine(st1.InfoString());

            Person st2 = new Student("Nataha", new DateTime(2000, 9, 20), "жен", 57, 131);
            Console.WriteLine(st2.InfoString());

            List<Person> Excursion = new List<Person>{ tc, tc1, st, st1, st2 };
            Console.WriteLine("\nНекоторая информация об экскурсии:");
            int count = 0;
            for (int i = 0; i < Excursion.Count; i++)
            {
                Console.WriteLine(Excursion[i].InfoString());
                if (Excursion[i] is Student)
                {
                    count++;
                }
            }
            Console.WriteLine("\nВсего студентов на экскурсии: " + count);
            // test lifts(Elevators)
            Console.WriteLine("\nЭкспперимент с лифтами");

            List<Person> studentQueue = new List<Person> { };
            List<Person> teacherQueue = new List<Person> { };

            studentQueue.Add(st);
            studentQueue.Add(st1);
            studentQueue.Add(st2);
            teacherQueue.Add(tc);
            teacherQueue.Add(tc1);

            ElevatorForStudents StudElevator = new ElevatorForStudents("STU", 230, studentQueue);
            ElevatorForTeachers TeachElevator = new ElevatorForTeachers("TEA", 240, teacherQueue)
            //test output

            StudElevator.AboutSTU();
            TeachElevator.AboutTEA();

            Console.ReadLine();
        }
    }
}
