using System.Numerics;

namespace Console_Program
{
    class C_3
    {
        /// <summary>
        /// Принимает: 2-е точки с координатами в 3D пространстве
        /// Возвращает: Расстояние между 2-я точками в 3D пространстве
        /// </summary>
        public static double Distance3D(Vector3 A, Vector3 B) {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2) + Math.Pow((A.Z - B.Z), 2));
        }

        private static void Main(string[] args) {
            Vector3 A, B;
            // Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            Console.WriteLine("Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
            
            // A (3, 6, 8); B (2, 1, -7), -> 15.84
            A = new Vector3(3, 6, 8);
            B = new Vector3(2, 1, -7);
            Console.WriteLine($"Расстояние между точками A ({A.X}, {A.Y}, {A.Z}) и B ({B.X}, {B.Y}, {B.Z}) в 3D пространстве -> {Math.Round(Distance3D(A, B), 2)}\n");

            // A (7, -5, 0); B (1, -1, 9) -> 11.53
            A = new Vector3(7, -5, 0);
            B = new Vector3(1, -1, 9);
            Console.WriteLine($"Расстояние между точками A ({A.X}, {A.Y}, {A.Z}) и B ({B.X}, {B.Y}, {B.Z}) в 3D пространстве -> {Math.Round(Distance3D(A, B), 2)}\n");
        }
    }
}