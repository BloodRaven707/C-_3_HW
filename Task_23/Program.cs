namespace Console_Program
{
    class C_3
    {
        /// <summary>
        /// Принимает: Число N - типа int32
        /// Возвращает: Строку - Список кубов чисел от 1 до N
        /// </summary>
        public static string ListOfCubes(int someNumber) {
            List<int> someList = new List<int>();
            for (int i = 1; i <= someNumber; i++) {
                someList.Add(i * i * i);
            }
            return string.Join(", ", someList);
        }


        private static void Main(string[] args) {
            int N;
            // Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            Console.WriteLine($"Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

            // 3 -> 1, 8, 27
            N = 3;
            Console.WriteLine($"Список кубов чисел от 1 до {N} -> {ListOfCubes(N)}\n");
            
            // 5 -> 1, 8, 27, 64, 125
            N = 5;
            Console.WriteLine($"Список кубов чисел от 1 до {N} -> {ListOfCubes(N)}\n");
        }
    }
}