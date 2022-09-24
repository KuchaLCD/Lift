using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excursion
{
    class ElevatorForStudents
    {
        string nameElevator;        //•	Имя лифта
        double maxWeight;   //•	Грузоподъемность (кг);
        List<Person> studentQueue; //•	Список людей в лифте.

        public string NameElevator { get { return nameElevator; } }
        public double MaxWeight { get { return maxWeight; } }
        public List<Person> StudentQueue { get { return studentQueue; } }
        public int CountPersonsInElevator { get { return StudentQueue.Count; } }
        //Методы
        public void AddingPersonToElevatorSTU(Person p)
        {
            StudentQueue.Add(p);
        }
        public void RemovingPersonFromElevatorSTU(Person p)
        {
            StudentQueue.Remove(p);
        }
        public void AboutSTU()
        {
            string inf = $"\nЛифт (студенческий)\nимя: {nameElevator}" +
                         $"\nМаксимальная загруженность: {maxWeight}";
            inf = inf + $"\nСтуденты в студенческом лифте:";
            Console.WriteLine(inf);
            double sum = 0;
            //Подсчёт веса
            for (int i = 0; i < StudentQueue.Count; i++)
            {
                sum += StudentQueue[i].Mass;
            }
            //Вывод информации о лифте 
            for (int i = 0; i < StudentQueue.Count; i++)
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
                    Console.WriteLine(StudentQueue[i].InfoString());
                }
            }
        }
        public ElevatorForStudents(string nameElevator, double maxWeight, List<Person> studentQueue)
        {
            this.nameElevator = nameElevator;
            this.maxWeight = maxWeight;
            this.studentQueue = studentQueue;
        }
    }
}
