using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excursion
{
    class ElevatorForTeachers
    {
        string nameElevator;        //•	Имя лифта
        double maxWeight;   //•	Грузоподъемность (кг);
        List<Person> teacherQueue; //•	Список людей в лифте.

        public string NameElevator { get { return nameElevator; } }
        public double MaxWeight { get { return maxWeight; } }
        public List<Person> TeacherQueue { get { return teacherQueue; } }
        public int CountPersonsInElevator { get { return TeacherQueue.Count; } }
        //Методы
        public void AddingPersonToElevatorTEA(int position, Person p)
        {
            TeacherQueue.Insert(position, p);
        }
        public void RemovingPersonFromElevatorTEA(Person p)
        {
            TeacherQueue.Remove(p);
        }
        public void AboutTEA()
        {
            string inf = $"\nЛифт (преподавательский)\nимя: {nameElevator}" +
                          $"\nМаксимальная загруженность: {maxWeight}";
            inf = inf + $"\nПреподватели в преподовательском лифте:";
            Console.WriteLine(inf);
            double sum = 0;
            for (int i = 0; i < TeacherQueue.Count; i++)
            {
                sum += TeacherQueue[i].Mass;
            }
            for (int i = 0; i < TeacherQueue.Count; i++)
            {
                if (CountPersonsInElevator == 0)
                {
                    Console.WriteLine("Лифт пуст");
                    break;
                }
                if (sum >= maxWeight)
                {
                    Console.WriteLine("Лифт переполнен");
                    break;
                }
                else
                {
                    Console.WriteLine(TeacherQueue[i].InfoString());
                }
            }
        }
        public ElevatorForTeachers(string nameElevator, double maxWeight, List<Person> TeacherQueue)
        {
            this.nameElevator = nameElevator;
            this.maxWeight = maxWeight;
            this.teacherQueue = TeacherQueue;
        }
    }
}
