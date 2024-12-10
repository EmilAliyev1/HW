#region Exercise1

// int[] array = [1, 2, 3, 4, 5, 6, 7];
// int evenCount = 0;
// int oddCount = 0;
//
// foreach (int var in array)
// {
//     if (var % 2 == 0)
//     {
//         evenCount++;
//     }
//     else
//     {
//         oddCount++;
//     }
//     
// }
//
// Console.WriteLine($"Чётных элементов: {evenCount}");
// Console.WriteLine($"Нечётных элементов: {oddCount}");
// Console.WriteLine('\n');

#endregion

#region Exercise2

// int[] array = [ 3, 5, 8, 1, 7, 4, 6, 2, 9, 0 ];
//
//
// Console.Write("Введите число для сравнения: ");
// int userInput = int.TryParse(Console.ReadLine(), out userInput) ? userInput : 0;
//
// int count = 0;
//
// foreach (int var in array)
// {
//     if (var < userInput)
//     {
//         count++;
//     }
// }
//
// Console.WriteLine($"Количество чисел, меньших чем {userInput}: {count}");
// Console.WriteLine('\n');
#endregion

#region Exercise3

// Console.WriteLine("Введите 3 числа: ");
//
// int num1 = int.TryParse(Console.ReadLine(), out num1) ? num1 : 0;
// int num2 = int.TryParse(Console.ReadLine(), out num2) ? num2 : 0;
// int num3 = int.TryParse(Console.ReadLine(), out num3) ? num3 : 0;
//
// int[] array = [ 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 ];
//
// // Переменная для подсчёта количества повторений последовательности
// int count = 0;
//
// // Проход по массиву для поиска последовательности
// for (int i = 0; i < array.Length - 2; i++)
// {
//     if (array[i] == num1 && array[i + 1] == num2 && array[i + 2] == num3)
//     {
//         count++;
//     }
// }
//
// Console.WriteLine($"Количество повторений последовательности: {count}");
#endregion

#region Exercise4
// int[] array1 = [1, 2, 3, 4, 5];
// int[] array2 = [4, 5, 6, 7, 8];
// List<int> commonElements = new List<int>();
//
// for (int i = 0; i < array1.Length; i++)
// {
//     for (int j = 0; j < array2.Length; j++)
//     {
//         if (array1[i] == array2[j])
//         {
//             commonElements.Add(array1[i]);
//         }
//     }
// }
//
// Console.Write($"Общие элементы первых двух массивов: ");
// foreach (int var in commonElements)
// {
//     Console.Write($"{var} ");
// }
#endregion

#region Exercise5

// int[,] arr2D = new int[,]
// {
//     { 1, 2, 3 },
//     { 4, 5, 6 }
// };
//
// int minValue = arr2D.Cast<int>().Min();
// int maxValue = arr2D.Cast<int>().Max();
//
// Console.WriteLine($"Минимум: {minValue}");
// Console.WriteLine($"Максимум: {maxValue}");

#endregion

#region Exercise6

// Console.WriteLine("Введите предложение:");
// string input = Console.ReadLine();
//
// if (input != null)
// {
//     string[] words = input.Split(new char[] {' '});
//     Console.WriteLine("Количество слов в предложении: " + words.Length);
// }

#endregion

#region Exercise7

// Console.WriteLine("Введите предложение:");
// string input = Console.ReadLine();
//
// string[] words = input.Split(' ');
//
// for (int i = 0; i < words.Length; i++)
// {
//     char[] wordArray = words[i].ToCharArray(); 
//     Array.Reverse(wordArray);
//     words[i] = new string(wordArray);
// }
//
// string result = string.Join(" ", words);
// Console.WriteLine("Результат: " + result);

#endregion

#region Exercise8

// Console.WriteLine("Введите предложение: ");
// string input = Console.ReadLine();
//
// char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 
//     'a', 'e', 'i', 'o', 'u', 'y' };
//
// int vowelCount = 0;
// foreach (char c in input.ToLower())
// {
//     foreach (char vowel in vowels)
//     {
//         if (c == vowel)
//         {
//             vowelCount++;
//             break;
//         }
//     }
// }
//
// Console.WriteLine($"Количество гласных букв: {vowelCount}");

#endregion

#region Exercise9

Console.WriteLine("Введите текст:");
string text = Console.ReadLine().ToLower();

Console.WriteLine("Введите слово для поиска:");
string word = Console.ReadLine();

int count = 0;
int position = text.IndexOf(word);

while (position != -1)
{
    count++;
    position = text.IndexOf(word, position + 1);
}

Console.WriteLine($"Слов найдено {count}");

#endregion