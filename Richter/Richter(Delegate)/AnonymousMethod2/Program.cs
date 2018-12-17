using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnonymousMethod2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] names = { "Jeff", "Kristin", "Aidan", "Grant" };
            string temp = Array.Find(names, name => name == "Jeff");
            char ch = 'e';
            string[] temp2 = Array.FindAll(names, name => name.IndexOf(ch) >= 0);
            names = Array.ConvertAll(names, name => name.ToLower());
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(temp);
            AClass.UsingLocalVariablesInTheCallbackCode(10);
            AClassCompiler.UsingLocalVariablesInTheCallbackCode(10);
        }
    }

    internal sealed class AClass
    {
        public static void UsingLocalVariablesInTheCallbackCode(Int32 numToDo)
        {
            // Локальные переменные
            int[] squares = new int[numToDo];
            AutoResetEvent done = new AutoResetEvent(false);
            // Выполнение задач в других потоках
            for (int n = 0; n < squares.Length; n++)
            {
                ThreadPool.QueueUserWorkItem(
                obj =>
                {
                    int num = (int)obj;
                    // Обычно решение этой задачи требует больше времени
                    squares[num] = num * num;
                    // Если это последняя задача, продолжаем выполнять главный поток
                    if (Interlocked.Decrement(ref numToDo) == 0)
                        done.Set();
                },
                n);
            }
            // Ожидаем завершения остальных потоков
            done.WaitOne();
            // Вывод результатов
            for (Int32 n = 0; n < squares.Length; n++)
                Console.WriteLine("Index {0}, Square={1}", n, squares[n]);
        }
    }


    internal sealed class AClassCompiler
    {
        public static void UsingLocalVariablesInTheCallbackCode(int numToDo)
        {
            // Локальные переменные
            WaitCallback callback1 = null;
            // Создание экземпляра вспомогательного класса
            DisplayClass2 class1 = new DisplayClass2();
            // Инициализация полей вспомогательного класса
            class1.numToDo = numToDo;
            class1.squares = new int[class1.numToDo];
            class1.done = new AutoResetEvent(false);
            // Выполнение задач в других потоках
            for (Int32 n = 0; n < class1.squares.Length; n++)
            {
                if (callback1 == null)
                {
                    // Новый делегат привязывается к объекту вспомогательного класса
                    // и его анонимному экземплярному методу
                    callback1 = new WaitCallback(class1.UsingLocalVariablesInTheCallbackCode);
                }
                ThreadPool.QueueUserWorkItem(callback1, n);
            }

            // Ожидание завершения остальных потоков
            class1.done.WaitOne();
        // Вывод результатов
        for (Int32 n = 0; n < class1.squares.Length; n++)
                Console.WriteLine("Index {0}, Square={1}", n, class1.squares[n]);
        }
    }
    // Вспомогательному классу присваивается необычное имя, чтобы
    // избежать конфликтов и предотвратить доступ из класса AClass

    class DisplayClass2
    {
        // В коде обратного вызова для каждой локальной переменной
        // используется одно открытое поле
        public int[] squares;
        public int numToDo;
        public AutoResetEvent done;
        // Открытый конструктор без параметров
        public DisplayClass2() { }
        // Открытый экземплярный метод с кодом обратного вызова
        public void UsingLocalVariablesInTheCallbackCode(object obj)
        {
            int num = (int)obj;
            squares[num] = num * num;
            if (Interlocked.Decrement(ref numToDo) == 0)
                done.Set();
        }
    }
}


 

