using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Delegate_8_1
{
    public delegate string RestDelegate();

    public class Person
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public RestDelegate RestMethod { get; set; }
        // Конструктор
        public Person(string name, string status)
        {
            Name = name;
            Status = status;
            switch (status)
            {
                case "студент":
                    RestMethod = Studying;
                    break;
                case "школяр":
                case "робітник":
                    RestMethod = Resting;
                    break;
            }
        }
        // Методи
        public void ChangeStatus(string newStatus)// Зміна статусу
        {
            Status = newStatus;
            switch (newStatus)
            {
                case "студент":
                    RestMethod = Studying;
                    break;
                case "школяр":
                case "робітник":
                    RestMethod = Resting;
                    break;
            }
        }
        // Методи, що викликаються делегатом
        private string Resting()
        {
            return $"{Name} відпочиває";
        }
        // Методи, що викликаються делегатом
        private string Studying()
        {
            return $"{Name} вчиться";
        }
    }
}