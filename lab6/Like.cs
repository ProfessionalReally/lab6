using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Like
    {
        private int amount = 0;  // Количество оценок
        private static Like lastLike;  // Адрес последнего элемента списка
        private Like prev;             // На предыдущий элемент списка
        private Like next;             // На следующий элемент списка

        // Конструктор
    public Like()
    {
        amount = 0;
    }

        // Конструктор
     public Like(int AMOUNT)
    {
        this.amount = AMOUNT;
    }

        // Инициализация структуры 
    public void Set(int v)
    {
        amount = v;
    }

        // Получение количества
        public int Get()
    {
        return this.amount;
    }

        // Ввод данных в структуру 
        public void InpLike()
    {
        string Lik;
        Console.Write("Please enter a amount likes: ");
        Lik = Console.ReadLine(); 
        amount = Convert.ToInt32(Lik);
            Console.Write("\n");
        }

        // Вывод данных из структуры
        public void Displayamount()
    {
            Console.Write("Amount likes: " + amount);
    }


        // Новый список
        public void NewL()
        {
            lastLike = null;
        }


        // Добавление элемента в конец списка
     public  void Add()
    {
        if (lastLike == null)
            this.prev = null;
        else
        {
            lastLike.next = this;
            prev = lastLike;
        }
        lastLike = this;
        this.next = null;
    }

    // Вывод на дисплей содержимого списка
   public void reprint()
    {
        Like uk;   // Вспомогательная ссылка
        uk = lastLike;
        if (uk == null)
        {
            Console.Write("List is empty!");
            return;
        }
        else
            Console.Write("\nList content :\n");

        // Цикл печати в обратном порядке значений элементов списка:
        while (uk != null)
        {
            Console.Write(uk.Get());
             Console.Write("\n");
                uk = uk.prev;
        }
    }
        public void TestRef4(ref int amount)
        {
            amount = 4;
        }

        // Проверка возврата значения по out
        public void TestOut5(out int amount)
        {
            amount = 5;
        }
        public static Like operator +(Like operand1, Like operand2)
            => new Like(operand1.amount + operand2.amount);

        public static Like operator ++(Like operand1)
                    => new Like(operand1.amount + 1);


    }
}
