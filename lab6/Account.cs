using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
   public class Account
    {
	//ACCOUNT
	private string name = ""; //Имя
	private string surname = ""; //Фамилия
	private string email = ""; //Почта
	private string password = ""; //Пароль
	//FIGURE
		public int FigureFigure = 0; //Фигура
		public int FigureColor = 0; //Цвет
	//FRIENDS
		public string[] FriendsName = new string[2]; //Имя
		public string[] FriendsSurname = new string[2]; //Фамилия
	//MUSIC
		public string[] MusicTitle = new string[2]; //Название
		public string[] MusicExecutor = new string[2]; //Исполнитель
	//MESSAGES
		public string MessagestoWhom = ""; //Кому сообщение
		public string MessagesfromWhom = ""; //От кого сообщение
		public string Messagesmessage = ""; //Текст сообщения

	public Account() //Конструктор
{
	name = ""; //Имя
	 surname = ""; //Фамилия
	 email = ""; //Почта
	 password = ""; //Пароль
	 FigureFigure = 0;
	 FigureColor = 0;
	 for (int i = 0; i< 2; i++)
	 {
		 FriendsName[i] = "";
		 FriendsSurname[i] = "";
		 MusicTitle[i] = "";
		 MusicExecutor[i] = "";
	 }
	MessagestoWhom = "";
	 MessagesfromWhom = "";
	 Messagesmessage = "";
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
public string Getemail()
{
	return this.email;
}
public string Getpassword()
{
	return this.password;
}

public void InitAccount(string NAME, string SURNAME, string EMAIL, string PASSWORD) //Инициализация аккаунта
{
	this.name = NAME;
	this.surname = SURNAME;
	this.email = EMAIL;
	this.password = PASSWORD;
}

public void InputAccount() //Изменение данных о аккаунте
{
			Console.WriteLine("\nPlease enter a name: ");
			name = Console.ReadLine();
			Console.WriteLine("\nPlease enter a surname: ");
			surname = Console.ReadLine(); 
			Console.WriteLine("\nPlease enter a email: ");
			email = Console.ReadLine(); 
			Console.WriteLine("\nPlease enter a password: ");
			password = Console.ReadLine();
}

public void OutputAccount() //Вывод данных о аккаунте
{
	Console.WriteLine("\t\t\tACCOUNT\n");
	if ((name == "") && (surname == "") && (email == "") && (password == ""))
	{
		Console.WriteLine("\nName: empty");
		Console.WriteLine("\nSurname: empty");
		Console.WriteLine("\nEmail: empty");
		Console.WriteLine("\nPassword: empty");
	}
	else
	{
				Console.WriteLine("Name: " + name + "\n");
				Console.WriteLine("Surname: " + surname + "\n");
				Console.WriteLine("Email: " + email + "\n");
				Console.WriteLine("Password: " + password + "\n");
	}
	Console.WriteLine("\n\t\t\tFIGURE\n");
	if (FigureFigure == 0)
		Console.WriteLine("Figure: Empty\n");
	if (FigureFigure == 1)
		Console.WriteLine("Figure: Triangle\n");
	if (FigureFigure == 2)
		Console.WriteLine("Figure: Circle\n");
	if (FigureFigure == 3)
		Console.WriteLine("Figure: Square\n");
	if (FigureColor == 0)
		Console.WriteLine("Color: Empty\n");
	if (FigureColor == 1)
		Console.WriteLine("Color: Red\n");
	if (FigureColor == 2)
		Console.WriteLine("Color: Green\n");
	if (FigureColor == 3)
		Console.WriteLine("Color: Blue\n");
	Console.WriteLine("\n\t\t\tFRIENDS\n");
	for (int i = 0; i < 2; i++)
	{
		if ((FriendsName[i] == "") && (FriendsSurname[i] == ""))
		{
					Console.WriteLine($"{i + 1}" + "\n");
					Console.WriteLine("Your friend's name: Empty\n");
			Console.WriteLine("Your friend's surname: Empty\n");
		}
		else
		{
					Console.WriteLine($"{i + 1}" + "\n");
					Console.WriteLine("Your friend's name: " + FriendsName[i] + "\n");
			Console.WriteLine("Your friend's surname: " + FriendsSurname[i] + "\n");
		}
	}
	Console.WriteLine("\n\t\t\tMUSIC\n");
	for (int i = 0; i < 2; i++)
	{
		if ((MusicExecutor[i] == "") && (MusicTitle[i] == ""))
		{
					Console.WriteLine($"{i+1}" + "\n");
					Console.WriteLine("Empty - Empty\n");
		}
		else
		{
					Console.WriteLine($"{i + 1}" + "\n");
					Console.WriteLine(MusicExecutor[i] + " - " + MusicTitle[i] + "\n"); ;
		}
	}
	Console.WriteLine("\n\t\t\tMESSAGES\n");
	if ((MessagestoWhom == "") && (MessagesfromWhom == "") && (Messagesmessage == ""))
	{
		Console.WriteLine("To whom the message: Empty\n");
		Console.WriteLine("From whom the message: Empty\n");
		Console.WriteLine("Message: Empty\n");
	}
	else
	{
				Console.WriteLine("To whom the message: " + MessagestoWhom + "\n"); ;
				Console.WriteLine("From whom the message: " + MessagesfromWhom + "\n"); ;
				Console.WriteLine("Message: " + Messagesmessage + "\n"); ;
			}
	Console.WriteLine("\n");
}

public void DeleteAccount() //Удаление аккаунта
{

	this.name = "";
	this.surname = "";
	this.email = "";
	this.password = "";
	this.FigureFigure = 0;
	this.FigureColor = 0;
	for (int i = 0; i < 2; i++)
	{
		this.FriendsName[i] = "";
		this.FriendsSurname[i] = "";
		this.MusicTitle[i] = "";
		this.MusicExecutor[i] = "";
	}
	this.MessagestoWhom = "";
	this.MessagesfromWhom = "";
	this.Messagesmessage = "";
}
	}
}
