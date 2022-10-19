// Найти наибольший общий префикс.
//
//  Пример тестовых данных:
// ["flower","flow","flight"] -> "fl"
//  ["dog","racecar","car"] -> ""

// string[] inp = new[] {"dog","racecar","car"};

string[] inp = new[] {"flower","flow","flight"};
Console.Write(FindMaxPrefix(inp));

string FindMaxPrefix(string[] words)
{
    if (words.Length == 0) return "";
    string prefix = words[0];
    for (int i = 1; i < words.Length; i++)
    {
        while (words[i].IndexOf(prefix, StringComparison.Ordinal) != 0)
        {
            prefix = prefix.Substring(0, prefix.Length - 1);
            if (prefix == "") return "";
        }
    }

    return prefix;
}
