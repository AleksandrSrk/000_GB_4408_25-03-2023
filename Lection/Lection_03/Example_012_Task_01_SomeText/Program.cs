// Работа с текстом. В тексте нужно все пробелы завменить черточками. Маленькие буквы к заменить большими. А большие С заменить маленькими.

string text = " - Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
// s[3]  - выдаст символ r

string Replace (string text, char oldValue, char newValue)
{
    string res = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) res = res + $"{newValue}";
        else res = res + $"{text[i]}";
    }
    return res;
}

string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);