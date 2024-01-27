using System.Collections;
using System.Diagnostics;

namespace HW2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int>();
            var ArList = new ArrayList();
            var LiList = new LinkedList<int>();
            var rand = new Random(1000000);
            Stopwatch time = new Stopwatch();
            time.Start();
            for (int i = 0; i < 1000000; i++)
            {
                List.Add(rand.Next());
            }
            time.Stop();
            Console.WriteLine($"Длина = {List.LongCount()}. Время заполнения List = {time.ElapsedMilliseconds}");

            time.Reset();
            time.Start();
            for (int i = 0; i < 1000000; i++)
            {
                ArList.Add(rand.Next());
            }
            time.Stop();
            Console.WriteLine($"Длина = {ArList.Count}. Время заполнения ArList = {time.ElapsedMilliseconds}");
            
            time.Reset();
            time.Start();
            for (int i = 0; i < 1000000; i++)
            {
                LiList.AddLast(rand.Next());
            }
            time.Stop();
            Console.WriteLine($"Длина = {LiList.Count()}. Время заполнения LiList = {time.ElapsedMilliseconds}");
           // Время доступа к элементу
            time.Start();
            Console.WriteLine($"Элемент List №496753 = {List[496753]}");
            time.Stop();
            Console.WriteLine($"Время поиска элемента List = {time.ElapsedMilliseconds}");

            time.Reset();
            time.Start();
            Console.WriteLine($"Элемент ArList №496753 = {ArList[496753]}");
            time.Stop();
            Console.WriteLine($"Время поиска элемента  ArList = {time.ElapsedMilliseconds}");

            time.Reset();
            time.Start();
            Console.WriteLine($"Элемент LiList №496753 = {LiList.ElementAt(496753)}");
            time.Stop();
            Console.WriteLine($"Время поиска элемента  LiList = {time.ElapsedMilliseconds}");

            // Время поиска элементов без остатка делящихся на 777 

            time.Reset();
            time.Start();
            foreach (int ListN in List)
            {
                if (ListN % 777 == 0)
                {
                    Console.WriteLine(ListN);
                } 
            }
            time.Stop();
            Console.WriteLine($"Время поиска элементов List без остатка делящихся на 777 = {time.ElapsedMilliseconds}");

            time.Reset();
            time.Start();
            foreach (int ArListN in ArList)
            {
                if (ArListN % 777 == 0)
                {
                    Console.WriteLine(ArListN);
                }
            }
            time.Stop();
            Console.WriteLine($"Время поиска элементов ArList без остатка делящихся на 777 = {time.ElapsedMilliseconds}");

            time.Reset();
            time.Start();
            foreach (int LiListN in LiList)
            {
                if (LiListN % 777 == 0)
                {
                    Console.WriteLine(LiListN);
                }
            }
            time.Stop();
            Console.WriteLine($"Время поиска элементов LiList без остатка делящихся на 777 = {time.ElapsedMilliseconds}");

        }


    }
}