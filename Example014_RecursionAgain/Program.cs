// Второе занятие по рекурсивным методам.
Console.Clear();

// 1. Собрать строку от a до b, a <= b.

/* string SecuenceRec(int a, int b)
{
    if (a <= b) return  $"{a}" + ' ' + SecuenceRec(a + 1, b);
    return string.Empty;
}
Console.WriteLine(SecuenceRec(1, 10)); */

// 2. Сумма чисел о 1 до n.

/* int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(10)); */

// 3. Факториал числа.

/* int FactorialRec(int n)
{
    if ((n == 1) || (n == 0)) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(10)); */

// 4. Вычисление а**n.

/* int PowerRec(int a, int n)
{
    return n == 0 ? 1 :  (PowerRec(a, n - 1) * a);
    //if (n == 0) return 1;
    //else return (PowerRec(a, n - 1) * a);
}
Console.WriteLine(PowerRec(2, 10)); */

// 5. Перебор "слов", состоящих из T количества букв.
int n = 1;
void FindWordsRec(string alphabet, char[] word, int lenght = 0)
{
    if (lenght == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[lenght] = alphabet[i];
        FindWordsRec(alphabet, word, lenght + 1);
    }
}
FindWordsRec("аист", new char[4]);