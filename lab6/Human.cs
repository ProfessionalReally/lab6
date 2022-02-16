using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    interface IHuman
    {
        // Ввод человека
        void InpHuman();

        // Вывод человека
        void DisplayInfo();

        // Виртуальная функция вывода сообщения на экран, кем является человек (неизвестный, пользователь, друг)
        string WhoIs();

        // Поверхностное копирование
        public Human ShallowCopy();

        // Глубокое копирование
        public Human DeepCopy();
    }



    //Class Human
    public class Human : IHuman
    {
        // Фамилия
        protected string surname;
        // Имя
        protected string name;


        public string SURNAME
        {
            get => surname;
            set => surname = value;
        }

        public string NAME
        {
            get => name;
            set => name = value;
        }

        // Конструктор
        public Human()
        {
            surname = "";
            name = "";
        }

        // Конструктор с одним параметром
        public Human(string NAME)
        {
            name = NAME;
            surname = "";
        }

        // Конструктор с параметрами
        public Human(string NAME, string SURNAME)
        {
            surname = SURNAME;
            name = NAME; 
        }

        // Фун-ии получения данных из полей
       
        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        // Установить фамилию
        public void SetSurname(string SURNAME)
        {
            surname = SURNAME;
        }

        // Установить имя
        public void SetName(string NAME)
        {
            name = NAME;
        }

        // Задание полей класса Human
        public void Set(string NAME, string SURNAME)
        {
            this.name = NAME;
            this.surname = SURNAME;
        }

        // Ввод человека
        public virtual void InpHuman()
        {
            Console.WriteLine("\nPlease enter your friend's name: ");
            name = Console.ReadLine();
            Console.WriteLine("\nPlease enter your friend's surname: ");
            surname = Console.ReadLine();
        }

        // Вывод человека
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Your friend's name: " + name + "\n");
            Console.WriteLine("Your friend's surname: " + surname + "\n");
        }

        // Обработка строк
        public void AdditionSapces()
        {
            name = name + "  ";
            surname = surname + "  ";
        }

        // Виртуальная функция вывода сообщения на экран, кем является человек (неизвестный, пользователь, друг)
        public virtual string WhoIs()
        {
            return "неизвестный";
        }

        // Сказать привет
        public void SayHello()
        {
            Console.WriteLine(WhoIs() + " говорит привет!");
        }

        // Поверхностное копирование
        public Human ShallowCopy()
        {
            return (Human)this.MemberwiseClone();
        }

        // Глубокое копирование
        public Human DeepCopy()
        {
            Human other = (Human)this.MemberwiseClone();
            other.name = String.Copy(name);
            other.surname = String.Copy(surname);
            return other;
        }
    }
}
