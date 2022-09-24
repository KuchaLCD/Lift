using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excursion
{
    class Student : Person
    {
        decimal scolarship; // стипендия

        // Свойство
        public decimal Scolarship
        {
            get { return scolarship; }
            set { scolarship = value; }
        }

        // Конструктор
        // Поля name, dateBirth, sex - наследуемые
        public Student(string name, DateTime dateBirth, string sex, double mass, decimal scolarship)
             : base(name, dateBirth, sex, mass)
        {
            this.scolarship = scolarship;
        }

        // Переопределяем метод базового класса InfoString()
        public override string InfoString()
        {
            string inf = $"\nСтудент\nимя: {Name}" +
                 $"\nдата рождения: {DateBirth.ToShortDateString()}" +
                 $"\nпол: {Sex}";

            // Новая информационная строка
            inf = inf + $"\nСтипендия: {scolarship} BYN";
            return inf;
        }
    }
}
