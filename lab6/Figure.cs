using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Figure
    {
       private int figure = 0; //Фигура
		private int color = 0; //Цвет

		public Figure() //Конструктор
		{
		figure = 0; //Фигура
		color = 0; //Цвет
		}
		public Figure(int FIGURE) //constructor 1
		{
			figure = FIGURE; //Figure
			color = 0; //color
		}

		public Figure(int FIGURE, int COLOR) //constructor all
		{
			figure = FIGURE; //Figure
			color = COLOR; //color
		}

		public void Setfigure(int FIGURE) //Set figure
		{
			figure = FIGURE; //Figure
		}

		public void Setcolor(int COLOR) //Set color
		{
			color = COLOR; //color
		}

		// Функции получения данных из полей
		public int Getfigure()
	{
		return this.figure;
	}
		public int Getcolor()
	{
		return this.color;
	}

		public void InitFigure(int FIGURE, int COLOR) //Инициализация фигуры
	{
		this.figure = FIGURE;
		this.color = COLOR;
	}

		public void InputFigure() //Изменение данных о фигуре
	{
			Console.WriteLine("\nPlease enter a figure(1 - Triangle, 2 - Circle, 3 - Square): ");
			figure = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nPlease enter a color(1 - Red, 2 - Green, 3 - Blue): ");
			color = Convert.ToInt32(Console.ReadLine());
		}

		public void OutputFigure() //Вывод данных о фигуре
	{
		if (figure == 0)
			Console.WriteLine("Figure: Empty\n");
		if (figure == 1)
			Console.WriteLine("Figure: Triangle\n");
		if (figure == 2)
			Console.WriteLine("Figure: Circle\n");
		if (figure == 3)
			Console.WriteLine("Figure: Square\n");
		if (color == 0)
			Console.WriteLine("Color: Empty\n");
		if (color == 1)
			Console.WriteLine("Color: Red\n");
		if (color == 2)
			Console.WriteLine("Color: Green\n");
		if (color == 3)
			Console.WriteLine("Color: Blue\n");
		Console.WriteLine("\n");
	}

		public void DeleteFigure() //Удаление фигуры
	{
		this.figure = 0;
		this.color = 0;
	}
}
}
