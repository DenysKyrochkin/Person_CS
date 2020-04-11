using System;
namespace Zodiac.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public Dates Birthday { get; set; }

        public bool IsAdult => Birthday.Age >= 18;
        public string SunSign => Birthday.ZodiacW;
        public string ChineseSign => Birthday.ZodiacC;
        public bool IsBirthday => Birthday.isBirthday();

        public Person(string name, string surname, string email, Dates birthday)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Birthday = birthday;
        }

        public Person(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Birthday = default;
        }

        public Person(string name, string surname, Dates birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Email = default;
        }
    }
}
