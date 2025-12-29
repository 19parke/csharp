using System;

namespace ArraySample
{
    class MainApp
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        static void Main(string[] args)
        {
            /*
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            foreach (int score in scores)
                Console.WriteLine(score);

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score : {average}");
            */


            // 배열 초기화 방법 3가지 
            /*
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };
            Console.WriteLine("array1...");
            foreach (string greeting in array1)
                Console.WriteLine(greeting);

            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray2...");
            foreach (string greeting in array2)
                Console.WriteLine(greeting);

            string[] array3 = { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray3...");
            foreach (string greeting in array3)
                Console.WriteLine(greeting);
            */

            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}");

            Console.WriteLine($"Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");

            Console.WriteLine($"Linear Search : 90 is at " + $"{Array.IndexOf(scores, 81)}");

            Console.WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            // FindIndex 는 특정 조건에 부합하는 메소드를 > 매개변수로 받음. 
            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            scores[index] = 61;
            Console.WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            Console.WriteLine("Old length of scores : " + $"{scores.GetLength(0)}");

            // 5였던 배열의 용량을 10으로 재조정
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            int[] sliced = new int[3];
            // scores 배열의 0번째부터 3개 요소를 sliced 배열의 0번째~2번째 요소에 차례대로 복사
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}