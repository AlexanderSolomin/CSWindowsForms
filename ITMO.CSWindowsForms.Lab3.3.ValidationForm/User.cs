using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSWindowsForms.Lab3._4.ValidationForm
{
    class User
    {
        string Name { get; set; }
        DateTime DateBirth { get; set; }
        string PhoneNum { get; set; }
        string Gender { get; set; }

        int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - DateBirth.Year;
                if (DateBirth > now.AddYears(-age)) age--;
                return age;
            }

        }
        public User()
        { }
        public User(string name, DateTime dateBirth, string phoneNum, string gender)
        {
            this.Name = name;
            this.DateBirth = dateBirth;
            this.PhoneNum = phoneNum;
            this.Gender = gender;
        }
        public override string ToString()
        {
            return "\n Имя: " + Name + "\n Дата рождения: " + DateBirth.ToString("d") +
            "\n Возраст: " + Age + "\n Телефон: " + PhoneNum + "\n Пол: " + Gender;
        }
    }
}
