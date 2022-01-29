﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    public class Messages
    {
        private string toWhom = ""; //Кому сообщение
        private string fromWhom = ""; //От кого сообщение
        private string message = ""; //Текст сообщения

	public Messages() //Конструктор
	{
	toWhom = ""; //Кому сообщение
	fromWhom = ""; //От кого сообщение
	message = ""; //Текст сообщения
	}

		public Messages(String TOWHOM) //constructor 1
		{
			toWhom = TOWHOM; //to whom message
			fromWhom = ""; //from whom message
			message = ""; //text message
		}

		public Messages(String TOWHOM, String FROMWHOM, String MESSAGE) //constructor all
		{
			toWhom = TOWHOM; //to whom message
			fromWhom = FROMWHOM; //from whom message
			message = MESSAGE; //text message
		}

		public void SettoWhom(String TOWHOM) //Set to whom message
		{
			toWhom = TOWHOM; //to whom message
		}

		public void SetfromWhom(String FROMWHOM) //Set from whom message
		{
			fromWhom = FROMWHOM; //from whom message
		}

		void Setmessage(String MESSAGE) //Set text message
		{
			message = MESSAGE; //text message
		}
		// Функции получения данных из полей
		public string GettoWhom()
	{
		return this.toWhom;
	}

		public string GetfromWhom()
	{
		return this.fromWhom;
	}

		public string Getmessage()
	{
		return this.message;
	}

		public void InitMessages(string TOWHOM, string FROMWHOM, string MESSAGE) //Инициализация сообщения
	{
		this.toWhom = TOWHOM;
		this.fromWhom = FROMWHOM;
		this.message = MESSAGE;
	}

		public void InputMessages() //Изменение данных о сообщении
	{
		Console.WriteLine("Please enter a to whom the message: ");
			toWhom = Console.ReadLine(); 
		Console.WriteLine("Please enter a from whom the message: ");
			fromWhom = Console.ReadLine(); 
		Console.WriteLine("Please enter a message: ");
			message = Console.ReadLine(); 
	}

		public void OutputMessages() //Вывод данных о сообщении
	{
		if ((toWhom == "") && (fromWhom == "") && (message == ""))
		{
			Console.WriteLine("To whom the message: Empty\n");
			Console.WriteLine("From whom the message: Empty\n");
			Console.WriteLine("Message: Empty\n");
		}
		else
		{
				Console.WriteLine("To whom the message: " + toWhom + "\n");
				Console.WriteLine("From whom the message: " + fromWhom + "\n");
				Console.WriteLine("Message: " + message + "\n");
			}
		Console.WriteLine("\n");
	}

		public void DeleteMessages() //Удаление данных о сообщении
	{
		this.toWhom = "";
		this.fromWhom = "";
		this.message = "";
	}
}
}
