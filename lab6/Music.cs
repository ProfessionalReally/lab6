using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Music
    {
		private string title = ""; //Название
		private string executor = ""; //Исполнитель

	public Music() //Конструктор
	{
	title = ""; //Название
	executor = ""; //Исполнитель
	}
		public Music(String TITLE) //constructor 1
		{
			title = TITLE; //title
			executor = ""; //executor
		}

		public Music(String TITLE, String EXECUTOR) //constructor all
		{
			title = TITLE; //title
			executor = EXECUTOR; //executor
		}

		public void Settitle(String TITLE) //Set title
		{
			title = TITLE; //title
		}

		public void Setexecutor(String EXECUTOR) //Set executor
		{
			executor = EXECUTOR; //executor
		}

		// Функции получения данных из полей
		public string Gettitle()
	{
		return this.title;
	}

	public string Getexecutor()
	{
		return this.executor;
	}

	public void MUSICinit(string EXECUTOR, string TITLE) //Инициализация музыки
	{
		this.executor = EXECUTOR;
		this.title = TITLE;
	}

	public void MUSICinput() //Изменение данных о музыке
	{
		Console.WriteLine("Please enter a executor: ");
			executor = Console.ReadLine();
		Console.WriteLine("Please enter a title: ");
			title = Console.ReadLine();
		}

	public void OutputMusic() //Вывод данных о музыке
	{
		if ((executor == "") && (title == ""))
		{
			Console.WriteLine("Empty - Empty\n");
		}
		else
		{
				Console.WriteLine(executor + " - " + title + "\n");
			}
		Console.WriteLine("\n");
	}

	public void DeleteMusic() //Удаление музыки
	{
		this.title = "";
		this.executor = "";
	}
}
}
