// Необходимо написать метод, который должен вернуть ближайшее
// к 10 число из входного массива чисел.
//     Если найдены несколько чисел равно удалённые к 10
// то вернуть максимальное. Например, среди чисел 9 и 11 вернуть 11.
//     Например, среди чисел 8 и 11 ближайшее к десяти 11.
//
//     Пример тестовых данных:
// [1, 2, 3, 4] -> 4
//     [10, 2, 3, 4] -> 10
//     [30, -10] -> 30
//     [7, 13] -> 13
//
// @param array массив целых чисел 
// @return ближайшее к десяти число
int[] inp = new[] { 1, 2, 3, 4, 10, 2, 3, 4 };
Console.WriteLine(NearToTen(inp));

int NearToTen(int[] arrays)
{
    int? minDiffValue = null;
    foreach (var elem in arrays)
    {
        if (minDiffValue == null)
        {
            minDiffValue = elem;
            continue;
        }

        if (Math.Abs((minDiffValue! - 10).Value) >= Math.Abs(elem - 10))
        {
            minDiffValue = minDiffValue > elem ? minDiffValue : elem;
        }
    }

    if (minDiffValue == null) throw new SystemException();
    return minDiffValue.Value;
}

