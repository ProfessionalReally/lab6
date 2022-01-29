using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Friends
    {
       private string name = ""; //Имя
       private string surname = ""; //Фамилия
		
	public Friends() //Конструктор
	{
		name = ""; //Имя
		surname = ""; //Фамилия
	}

public Friends(String NAME) //constructor 1
{
	name = NAME; //name
	surname = ""; //surname
}

public Friends(String NAME, String SURNAME) //constructor all
{
	name = NAME; //name
	surname = SURNAME; //surname
}

public void Setname(String NAME) //Set name
{
	name = NAME; //name
}

public void Setsurname(String SURNAME) //Set surname
{
	surname = SURNAME; //surname
}

		// Функции получения данных из полей
	public string Getname()
	{
		return this.name;
	}

	public string Getsurname()
	{
		return this.surname;
	}

	public void InitFriends(string NAME, string SURNAME) //Инициализация друзей
	{
		this.name = NAME;
		this.surname = SURNAME;
	}

	public void InputFriends() //Изменение данных о друзьях
	{
			Console.WriteLine("\nPlease enter your friend's name: ");
			name = Console.ReadLine();
			Console.WriteLine("\nPlease enter your friend's surname: ");
			surname = Console.ReadLine();
	}

	public void OutputFriends() //Вывод данных о друзьях
	{
		if ((name == "") && (surname == ""))
		{
			Console.WriteLine("Your friend's name: Empty\n");
			Console.WriteLine("Your friend's surname: Empty\n");
		}
		else
		{
			Console.WriteLine("Your friend's name: " + name + "\n");
			Console.WriteLine("Your friend's surname: " + surname + "\n");
			}
		Console.WriteLine("\n");
	}

		public void DeleteFriends() //Удаление друзей
	{
		this.name = "";
		this.surname = "";
	}
		public string Name
		{
			get => name;
			set => name = value;
		}

		public string Surname
		{
			get => surname;
			set => surname = value;
		}

		//String processing
		public void AdditionSapces()
		{
			name = name + "  ";
			surname = surname + "  ";
		}

		//String return	
		public String returned()
		{
			return (name + surname);
		}

	}
}
