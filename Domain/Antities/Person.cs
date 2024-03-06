using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Antities
{
    /// <summary>
    /// Основная сущность персоны(человека)
    /// </summary>
    public class Person : BaseEntitiys
    {
        string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        string surname;
        int age { get; set; }
        DateTime birthday { get; }
        /// <summary>
        /// Макс полно описать сущность персона(нужна для того чтобы собирать инфу о человеке(собрать параметры о человеке др и тд))
        /// Сделать добавление через конструктор
        /// </summary>
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public Person(string name, string surname, DateTime birthday)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            DateTime now = DateTime.Today;
            this.age = now.Year - birthday.Year - 1 + ((now.Month > birthday.Month || now.Month == birthday.Month && now.Day >= birthday.Day) ? 1 : 0);
        }
    }
}

