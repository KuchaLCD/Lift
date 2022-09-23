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
        public void AddingPersonToElevator(int position)
        {

        }
        public string AboutLT()
        {
            string inf = $"\nЛифт\nимя: {nameElevator}" +
                          $"\nМаксимальная загруженность: {maxWeight}";
            inf = inf + $"\nПреподватели в преподовательском лифте лифте:";
            for (int i = 0; i < TeacherQueue.Count; i++)
            {
                Console.WriteLine(TeacherQueue[i].InfoString());
            }

            return inf;
        }
    }
}
