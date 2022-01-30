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
            this.amount = 0;
            if (IsRightLike(AMOUNT))
                this.amount = AMOUNT;

     }

        // Инициализация структуры 
        public void Set(int v)
    {
            this.amount = 0;
            if (IsRightLike(v))
                this.amount = v;

        }

        // Поверхностная копия
        public Like ShallowCopy()
        {
            return (Like)this;
        }

        // Глубокая копия
        public Like DeepCopy()
        {
            Like other = (Like)this.MemberwiseClone();
            other.Set(amount);
            return other;
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
            try                                                 // ищем исключения внутри этого блока и отправляем их в соответствующий обработчик catch          
            {
                for (int i = 0; i < Lik.Length; i++)
                {
                    if ((Lik[i] < '0') || (Lik[i] > '9'))
                        throw new Exception("It string is not number!");       // выбрасывается исключение
                }
                Set(Convert.ToInt32(Lik));
            }
            catch (Exception ex)                       // обработчик исключений типа const char*
            {
                Console.Write("Error: " + ex.Message + '\n');
            }
        }

        // Проверка числа на подходяее для оценки
        public bool IsRightLike(int like)
        {
            bool res = true;
            try                                                    // ищем исключения внутри этого блока и отправляем их в соответствующий обработчик catch
            {
                if (like < 0)                          // Если пользователь ввел неверное число, то выбрасывается исключение
                    throw new Exception("Incorrect value.");       // выбрасывается исключение типа const char*
                return res;
            }
            catch (Exception ex)           // обработчик исключений типа const char*
            {
                Console.WriteLine("Error: " + ex.Message + '\n');
                res = false;
                return res;
            }
        }


        // Вывод данных из структуры
        public void Displayamount()
    {
            Console.Write("Amount likes: " + amount);
    }


        // Новый список
        public static void NewL()
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
   public static void reprint()
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
