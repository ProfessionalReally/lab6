﻿using System;

namespace lab6
{

	class Program
	{

		static void Main(string[] args)
		{
			/*Console.Write("10) Для полей добавить свойства и продемонстрировать работу с ними\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере класса Friends\n");
			Friends friend = new Friends();
			friend.Name = "Alex";
			friend.Surname = "John";

			Console.WriteLine("Friend: " + friend.Name + " " + friend.Surname);

			Console.Write("11) Cоздать массив объектов и продемонстрировать работу с ним\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере класса Учитель\n");
			Music[] M = new Music[2];
			for (int j = 0; j < 2; j++)
				M[j] = new Music();

			M[0].MUSICinit("Kukushka", "Choi");
			M[1].MUSICinit("Grigoriy Leps", "London");


			Console.Write("Output all:\n");
			for (int i = 0; i < 2; i++)
				M[i].OutputMusic();
			Console.Write("12) В отдельной ветке проекта заменить класс (class) \nна структуру (struct). Продемонстрировать различие \nмежду присваиванием объектов класса и структуры\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере класса Like и структуры Figure\n");
			Figure good = new Figure();
			Figure good2 = new Figure();
			Like cool = new Like();
			Like cool2 = new Like();
			cool2.Set(7);
			good.InitFigure(1, 2);
			cool.Set(10);
			Console.WriteLine("\nЭлемент структуры до копирования:");
			good.OutputFigure();
			Console.WriteLine("\nЭлемент класса до копирования:");
			cool.Displayamount();

			Console.WriteLine("\nЭлемент структуры копируется на:");
			good2.OutputFigure();

			Console.WriteLine("\nЭлемент класса копируется на:");
			cool2.Displayamount();

			good = good2;
			cool = cool2;
			Console.WriteLine("\nЭлемент структуры после копирования:");
			good.OutputFigure();

			Console.WriteLine("\nЭлемент класса после копирования:");
			cool.Displayamount();

			Console.WriteLine("\nЕсли изменить те объекты, на которые менялись объект класса и структуры:");
			good2.InitFigure(3, 3);
			cool2.Set(9);
			good2.OutputFigure();
			cool2.Displayamount();

			Console.WriteLine("\nТо новые объекты будут таковыми:");
			good.OutputFigure();
			cool.Displayamount();
			Console.WriteLine("\n\nОбъект класса изменился, потому что копируется ссылка \nна объект, а объект структуры не изменился, т.к. \nкопируются значения полей.");

			Console.Write("\n\n");

			Console.Write("13) Продемонстрировать работу с массивом объектов\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере структуры Оценка\n");
			Like[] likesTest = new Like[5];
			Console.Write("Массив лайков:\n");
			for (int j = 0; j < 5; j++)
			{
				likesTest[j] = new Like();
				likesTest[j].Set(j + 1);
				likesTest[j].Displayamount();
				Console.Write("\n");
			}
			Console.Write("14) Продемонстрировать возврат значения через параметр out и через\nпараметр ref. Показать различие этих механизмов\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере структуры оценка\n");
			// Инициализация объектов структуры
			Like likeForRef = new Like();
			Like likeForOut = new Like();

			// Инициализация переменной для передачи по ref
			int ArgRef = 2;
			// Описание переменной для передачи по out
			int ArgOut;

			likeForRef.Set(1);
			// Передача аргумента по ref
			likeForRef.TestRef4(ref ArgRef);
			Console.WriteLine("Аргумент функции после использования по ref: " + ArgRef);

			likeForOut.Set(2);
			// Передача аргумента по out
			likeForOut.TestOut5(out ArgOut);
			Console.WriteLine("Аргумент функции после использования по out: " + ArgOut);

			Console.Write("15) Продемонстрировать разумное использование оператора this\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере класса Like, двусвязанный список\n\n");

			//Set Like:
			Like[] A = new Like[4];
			A[0] = new Like();
			A[1] = new Like();
			A[2] = new Like();
			A[3] = new Like();

			A[0].Set(1);
			A[1].Set(2);
			A[2].Set(3);
			A[3].Set(4);


			//Init
			A[0].NewL();

			//reprint
			A[2].reprint();

			//Add
			A[0].Add(); A[1].Add(); A[2].Add(); A[3].Add();

			//reprint:
			A[2].reprint();

			Console.Write("16) Продемонстрировать перегрузку операторов '+', '++'\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере структуры Оценка\n");
			Like like1 = new Like();
			Like like2 = new Like();
			Console.Write("Оценка 1 и оценка 2:\n");
			like1.Set(1);
			like2.Set(2);
			like1.Displayamount();
			Console.Write("\n");
			like2.Displayamount();
			Console.Write("\n\nСумма оценок через оператор \'+\':\n");
			like1 = like1 + like2;
			like2 = like1;
			like1.Displayamount();
			Console.Write("\nПрибавление к сумме 1 через постфиксный оператор \'++\': ");
			(like1++).Displayamount(); 
			Console.Write("\nПрибавление к сумме 1 через префиксный оператор \'++\': ");
			(++like2).Displayamount();

			Console.Write("\n\n17) Продемонстрировать обработку строк (string)\n");
			Console.Write("==================================================================\n");
			Console.Write("На примере класса Учитель, добавление ко всем полям пробелов\n");
			friend.InitFriends("Alex", "John");
			friend.AdditionSapces();
			Console.Write("Friend: ");
			Console.Write(friend.returned());
			*/
			/*Console.Write("Лабраторная 8:\n\n");
			Console.Write("=========\nМодифицировать ваши проекты на С++, C# и Java путем добавления в один из классов\nкак минимум одного статического поля и одного статического метода.\n=========\n\n");

			Console.Write("(Использовались статический член класса\'Teacher\' \'lastTeacher\'и\nстатические методы класса \'NewList\' и \'reprint\')\n\n");

			// Формирование объектов класса Teacher:
			Like[] A = new Like[4];
			A[0] = new Like();
			A[1] = new Like();
			A[2] = new Like();
			A[3] = new Like();

			A[0].Set(1);
			A[1].Set(2);
			A[2].Set(3);
			A[3].Set(4);

			Console.Write("Вызов статической компанентной функции: \'Новый список\'\n\n");
			// Вызов статической компанентной функции:			
			Like.NewL();

			Console.Write("Вызов статической компанентной функции: \'Напечатать список\'\n\n");
			// Вызов статической компанентной функции:
			Like.reprint();

			Console.Write("\n");

			Console.Write("Добавление элементов в список.\n\n");
			// Включение созданных компанентов в двусвязанный список:
				A[0].Add(); A[1].Add(); A[2].Add(); A[3].Add();

			Console.Write("Вызов статической компанентной функции: \'Напечатать список\'\n\n");
			Console.Write("===================================\n");
			// Печать в обратном порядке значений элементов списка:
			Like.reprint();*/

			Account account1 = new Account();
			Account account2 = new Account("Artur");
			Account account3 = new Account("Nikolay", "Ivanov", "NikolayIvanov@yandex.ru", "123");

			Console.WriteLine("Лабораторная 9");
			Console.WriteLine();
			Console.WriteLine("Конструкторы класса Account:");
			Console.WriteLine("1) Конструктор без параметров:");
			account1.OutputAccount();
			Console.WriteLine("2) Конструктор с 1-им параметром:");
			account2.OutputAccount();
			Console.WriteLine("3) Конструктор с параметрами:");
			account3.OutputAccount();
			Console.WriteLine("\n\n");

			Figure figure1 = new Figure();
			Figure figure2 = new Figure(1);
			Figure figure3 = new Figure(2,3);

			Console.WriteLine("Лабораторная 9");
			Console.WriteLine();
			Console.WriteLine("Конструкторы класса Figure:");
			Console.WriteLine("1) Конструктор без параметров:");
			figure1.OutputFigure();
			Console.WriteLine("2) Конструктор с 1-им параметром:");
			figure2.OutputFigure();
			Console.WriteLine("3) Конструктор с параметрами:");
			figure3.OutputFigure();
			Console.WriteLine("\n\n");

			Friends friend1 = new Friends();
			Friends friend2 = new Friends("Egor");
			Friends friend3 = new Friends("Gloria", "Jean");

			Console.WriteLine("Лабораторная 9");
			Console.WriteLine();
			Console.WriteLine("Конструкторы класса Friends:");
			Console.WriteLine("1) Конструктор без параметров:");
			friend1.OutputFriends();
			Console.WriteLine("2) Конструктор с 1-им параметром:");
			friend2.OutputFriends();
			Console.WriteLine("3) Конструктор с параметрами:");
			friend3.OutputFriends();
			Console.WriteLine("\n\n");

			Music music1 = new Music();
			Music music2 = new Music("Not Afraid");
			Music music3 = new Music("Here We Go", "Eminem");

			Console.WriteLine("Лабораторная 9");
			Console.WriteLine();
			Console.WriteLine("Конструкторы класса Music:");
			Console.WriteLine("1) Конструктор без параметров:");
			music1.OutputMusic();
			Console.WriteLine("2) Конструктор с 1-им параметром:");
			music2.OutputMusic();
			Console.WriteLine("3) Конструктор с параметрами:");
			music3.OutputMusic();
			Console.WriteLine("\n\n");

			Messages message1 = new Messages();
			Messages message2 = new Messages("Nikolay Krasnov");
			Messages message3 = new Messages("My teacher", "Student", "Good morning!");

			Console.WriteLine("Лабораторная 9");
			Console.WriteLine();
			Console.WriteLine("Конструкторы класса Messages:");
			Console.WriteLine("1) Конструктор без параметров:");
			message1.OutputMessages();
			Console.WriteLine("2) Конструктор с 1-им параметром:");
			message2.OutputMessages();
			Console.WriteLine("3) Конструктор с параметрами:");
			message3.OutputMessages();
			Console.WriteLine("\n\n");

			Like like1 = new Like(), like2 = new Like(3);

			Console.WriteLine("Лабораторная 9");
			Console.WriteLine();
			Console.WriteLine("Конструкторы класса Like:");
			Console.WriteLine("1) Конструктор без параметров:");
			like1.Displayamount();
			Console.WriteLine("\n");
			Console.WriteLine("2) Конструктор с 1-им параметром, он же с параметрами:");
			like2.Displayamount();
			Console.WriteLine("\n\n");

			Console.WriteLine("Лабораторная 9");
			Console.WriteLine();
			Friends[] friends = new Friends[3];
			for (int j = 0; j < 3; j++)
				friends[j] = new Friends("Ivanov" + (j + 1));
			Console.WriteLine("Инициализировать небольшой массив конструктором с одним параметром:");
			for (int j = 0; j < 3; j++)
				friends[j].OutputFriends();
			Console.WriteLine("\n\n");

			Console.WriteLine("Лабораторная 9");
			Console.WriteLine();
			Console.WriteLine("Продемонстрировать различие между мелким и глубоким копированием:");
			Like likeTestCopy1 = new Like(4), likeTestCopy2 = new Like(5);


			likeTestCopy2 = likeTestCopy1;

			Console.WriteLine("Поверхностная копия 1-го объекта во 2-ой:");
			likeTestCopy1.Displayamount();
			Console.WriteLine("\n");
			likeTestCopy2.Displayamount();
			Console.WriteLine("");
			Console.WriteLine("Изменение 1-го объекта, а 2-ой не трогается:");
			likeTestCopy1.Set(3);
			likeTestCopy1.Displayamount();
			Console.WriteLine("\n");
			likeTestCopy2.Displayamount();
			Console.WriteLine("");

			likeTestCopy1.Set(4);
			likeTestCopy2 = likeTestCopy1.DeepCopy();

			Console.WriteLine("Глубокая копия 1-го объекта во 2-ой:");
			likeTestCopy1.Displayamount();
			Console.WriteLine("\n");
			likeTestCopy2.Displayamount();
			Console.WriteLine("");
			Console.WriteLine("Изменение 1-го объекта, а 2-ой не трогается:");
			likeTestCopy1.Set(3);
			likeTestCopy1.Displayamount();
			Console.WriteLine("\n");
			likeTestCopy2.Displayamount();
			Console.WriteLine("\n\n");




		}
	}
}
