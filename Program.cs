using System;

namespace Task12_4
{
    class Program
    {
        static void Run()
        {
            ICutDownNotifier[] arr = new ICutDownNotifier[3];
            arr[0] = new A(5, "Чтение задания");
            arr[1] = new B(5, "Выполнение задания");
            arr[2] = new C(5, "Проверка задания перед отправкой");

            arr[0].Init();
            arr[1].Init();
            arr[2].Init();

            arr[0].Run();
            arr[1].Run();
            arr[2].Run();
        }

        static void Main(string[] args)
        {
            Run();
            Console.ReadKey();
        }
    }
}
