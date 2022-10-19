// Поиск повторяющихся элементов в массиве
//
//     Пример тестовых данных:
// [1,2,3,1] -> true
//     [1,2,3,4] -> false
//     [1,1,1,3,3,4,3,2,4,2] -> true

int[] inp = new[] {1,2,3,4 };
Console.WriteLine(IsHaveRepeating(inp));

bool IsHaveRepeating(int[] numbers)
{
    HashSet<int> set = new HashSet<int>();
    foreach (var number in numbers)
    {
        if (set.Contains(number))
            return true;
        set.Add(number);
    }

    return false;
}