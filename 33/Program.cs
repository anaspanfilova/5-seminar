// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetArray(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

bool CheckArray(int[] array, num)
{
    foreach (int el in array)
    {
        if(el == num)
        {
            return true;
        }
    }
    return false;
}

Console.Clear();
string input = Console.ReadLine();
int[] numArray = GetArray(input);
int[] n = int.Parse(Console.ReadLine()!);

if(CheckArray(numArray, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}