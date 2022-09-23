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
        public void AddingPersonToElevator(int position)
        {
            StudentQueue.Insert(position, Person);
        }
        public void RemovingPersonFromElevator(int position)
        {
            StudentQueue.Remove(position, Person);
        }
        public string AboutLS()
        {
            string inf = $"\nЛифт\nимя: {nameElevator}" +
                         $"\nМаксимальная загруженность: {maxWeight}";
            inf = inf + $"\nСтуденты в студенческом лифте:";
            for (int i = 0; i < StudentQueue.Count; i++)
            {
                Console.WriteLine(StudentQueue[i].InfoString());
            }

            return inf;
        }
        public ElevatorForStudents(string nameElevator, double maxWeight, List<Person> studentQueue)
        {
            this.nameElevator = nameElevator;
            this.maxWeight = maxWeight;
            this.studentQueue = studentQueue;
        }

    }
}
