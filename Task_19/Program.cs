namespace Console_Program
{
    class C_3
    {
        /// <summary>
        /// Принимает: Произвольную строку
        /// Возвращает: true(палиндром) : false(не палиндром)
        /// </summary>
        public static bool Palindrome(string someString) {
            char[] SomeArray = someString.ToCharArray();
            Array.Reverse(SomeArray);
            return new String(SomeArray) == someString;
        }

        private static void Main(string[] args) {
            string someString;
            // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

            // 14212 -> нет
            someString = Convert.ToString(14212);
            Console.WriteLine($"Число {someString} палиндромом -> {(Palindrome(someString) ? "Да" : "Нет")}\n");

            // 12821 -> да
            someString = Convert.ToString(12821);
            Console.WriteLine($"Число {someString} палиндромом -> {(Palindrome(someString) ? "Да" : "Нет")}\n");

            // 23432 -> да
            someString = Convert.ToString(23432);
            // Без метода + медленный способ разворота строки
            Console.WriteLine($"Число {someString} палиндромом -> {((new String(someString.Reverse().ToArray()) == someString) ? "Да" : "Нет")}\n");
        }
    }
}